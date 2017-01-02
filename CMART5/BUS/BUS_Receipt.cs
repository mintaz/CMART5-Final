using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMART5.BUS
{
    class BUS_Receipt
    {
        Cmart5DataContext dbt, dbu, dbl;
        public void AddInfo(string idreceipt, string idproduct, int quantity)
        {
            try
            {
                dbt = new Cmart5DataContext();
                //Price cal
                List<LICHSUGIA> priceList = dbt.LICHSUGIAs.ToList().Where(st => st.idSANPHAM == idproduct).ToList();
                DateTime currentValidated = priceList.Max(st => st.NGAYHIEULUC);
                foreach (LICHSUGIA priceTMP in priceList)
                {
                    if (DateTime.Now >= priceTMP.NGAYHIEULUC)
                    {
                        currentValidated = priceTMP.NGAYHIEULUC;
                    }
                }
                LICHSUGIA price = priceList.Single(st => st.NGAYHIEULUC == currentValidated);
                //KHUYENMAI cal
                float KHUYENMAI_amount = 0;

                List<KHUYENMAI> KHUYENMAIList = dbt.KHUYENMAIs.ToList().Where(st => st.idSANPHAM == idproduct).ToList();
                if (KHUYENMAIList.Count() > 0)
                {
                    string currrentKHUYENMAI = KHUYENMAIList.First().idKHUYENMAI;
                    foreach (KHUYENMAI KHUYENMAITMP in KHUYENMAIList)
                    {
                        if (KHUYENMAITMP.TG_BATDAU <= DateTime.Now && DateTime.Now <= KHUYENMAITMP.TG_KETTHUC)
                        {
                            currrentKHUYENMAI = KHUYENMAITMP.idKHUYENMAI;
                        }
                    }
                    KHUYENMAI dc = KHUYENMAIList.Single(st => st.idKHUYENMAI.Contains(currrentKHUYENMAI));
                    KHUYENMAI_amount = (float)dc.GIA_KM;
                }

                CTHOADON s = new CTHOADON();
                s.idHOADON = idreceipt;
                s.idSANPHAM = idproduct;
                s.SOLUONG = quantity;
                s.DONGIA = quantity * (price.GIABAN - KHUYENMAI_amount);
                dbt.CTHOADONs.InsertOnSubmit(s);
                dbt.SubmitChanges();
                //update receipt
                List<CTHOADON> listRe = dbt.CTHOADONs.Where(st => st.idHOADON == idreceipt).ToList();
                HOADON re = dbt.HOADONs.Single(st => st.idHOADON == idreceipt);
                re.TONGTIEN = int.Parse(listRe.Sum(t => t.DONGIA).ToString());
                re.TONGSOLUONG = int.Parse(listRe.Sum(t => t.SOLUONG).ToString());
                dbt.SubmitChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi:\n" + e.Message + "\n vui lòng kiểm tra lại");
            }
        }
        public void UpdateInfo(string idreceipt, string idproduct, int quantity)
        {
            try
            {
                dbu = new Cmart5DataContext();
                //Price cal
                List<LICHSUGIA> priceList = dbu.LICHSUGIAs.ToList().Where(st => st.idSANPHAM == idproduct).ToList();
                DateTime currentValidated = priceList.Max(st => st.NGAYHIEULUC);
                foreach (LICHSUGIA priceTMP in priceList)
                {
                    if (DateTime.Now >= priceTMP.NGAYHIEULUC)
                    {
                        currentValidated = priceTMP.NGAYHIEULUC;
                    }
                }
                LICHSUGIA price = dbu.LICHSUGIAs.Single(st => st.NGAYHIEULUC == currentValidated);
                //Discoutn cal
                List<KHUYENMAI> KHUYENMAIList = dbu.KHUYENMAIs.ToList().Where(st => st.idSANPHAM  == idproduct).ToList();
                string currrentdiscount = KHUYENMAIList.Max(st => st.idKHUYENMAI);
                foreach (KHUYENMAI discountTMP in KHUYENMAIList)
                {
                    if (discountTMP.TG_BATDAU <= DateTime.Now && DateTime.Now <= discountTMP.TG_KETTHUC)
                    {
                        currrentdiscount = discountTMP.idKHUYENMAI;
                    }
                }
                KHUYENMAI dc = dbu.KHUYENMAIs.Single(st => st.idKHUYENMAI == currrentdiscount);
                float discount_amount = (float)dc.GIA_KM;
                CTHOADON s = dbu.CTHOADONs.Single(st => st.idHOADON == idreceipt && st.idSANPHAM == idproduct);
                if (quantity <= 0)
                {
                    dbu.CTHOADONs.DeleteOnSubmit(s);
                    dbu.SubmitChanges();
                }
                else
                {
                    s.SOLUONG = quantity;
                    s.DONGIA = quantity * (price.GIABAN - discount_amount);
                    dbu.SubmitChanges();
                }
                //update receipt
                List<CTHOADON> listRe = dbu.CTHOADONs.Where(st => st.idHOADON == idreceipt).ToList();

                HOADON re = dbu.HOADONs.Single(st => st.idHOADON == idreceipt);
                re.TONGTIEN = int.Parse(listRe.Sum(t => t.DONGIA).ToString());
                re.TONGSOLUONG = int.Parse(listRe.Sum(t => t.SOLUONG).ToString());

                dbu.SubmitChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi:\n" + e.Message + "\n vui lòng kiểm tra lại");
            }
        }

        public void UpdateInfo(string idreceipt, int cash)
        {
            try
            {
                dbl = new Cmart5DataContext();
                //update receipt
                List<CTHOADON> listRe = dbl.CTHOADONs.Where(st => st.idHOADON == idreceipt).ToList();
                HOADON re = dbl.HOADONs.Single(st => st.idHOADON == idreceipt);
                re.TIENKHACHDUA = cash;
                re.TIENTRALAI= cash - re.TONGTIEN;
                dbl.SubmitChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi:\n" + e.Message + "\n vui lòng kiểm tra lại");
            }
        }
        public void AddReceipt(string idAccount, int pos)
        {
            try
            {
                dbt = new Cmart5DataContext();
                HOADON s = new HOADON();
                string day = DateTime.Now.ToString("dd");
                string month = DateTime.Now.ToString("MM");
                string year = DateTime.Now.ToString("yy");
                string posNumber = pos.ToString().PadLeft(2, '0');

                try
                {
                    List<HOADON> r = dbt.HOADONs.ToList().Where(st => st.idHOADON.Substring(2, 2) == posNumber).ToList();
                    string max = r.Max(t => t.idHOADON);
                    int idnumber = int.Parse(max.Substring(10, 4)) + 1;
                    string maxId = "HD" + posNumber + year + month + day + idnumber.ToString().PadLeft(4, '0');
                    s.idHOADON = maxId;
                }
                catch (NullReferenceException)
                {
                    s.idHOADON = "HD" + posNumber + year + month + day + "0001";
                }
                s.NGAYBAN = DateTime.Now;
                s.TONGTIEN = 0;
                s.idTAIKHOAN = idAccount;
                s.TIENKHACHDUA = 0;
                s.TIENTRALAI= 0;
                s.TONGSOLUONG = 0;
                s.SOPOS = pos;
                dbt.HOADONs.InsertOnSubmit(s);
                dbt.SubmitChanges();
                MessageBox.Show("Thêm Thành Công");
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi:\n" + e.Message + "\n vui lòng kiểm tra lại");
            }
        }

    }
}

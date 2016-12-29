using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMART5.BUS
{
    class BUS_Tickets
    {
        public void AddHQTicket(string idRequest, string idAccount)
        {
            try
            {
                Cmart5DataContext db = new Cmart5DataContext();
                PHIEUNHAPHANGTRUSO HQT = new PHIEUNHAPHANGTRUSO();
                PHIEUDEXUAT RQT = db.PHIEUDEXUATs.Single(st => st.idPHIEUDEXUAT.Contains(idRequest));

                string year = (DateTime.Now.Year % 100).ToString();
                try
                {
                    
                    List<PHIEUNHAPHANGTRUSO> r = db.PHIEUNHAPHANGTRUSOs.ToList().Where(st => st.idPHIEUTRUSO.Substring(2, 2) == year).ToList();
                    string max = r.Max(t => t.idPHIEUTRUSO);
                    int idnumber = int.Parse(max.Substring(4, 4)) + 1;
                    string maxId = "TS" + year + idnumber.ToString().PadLeft(4, '0');
                    HQT.idPHIEUTRUSO = maxId;
                }
                catch (NullReferenceException)
                {
                    HQT.idPHIEUTRUSO = "TS" + year + "0001";
                }
                HQT.idPHIEUDEXUAT = idRequest;
                HQT.NGAYNHAP = RQT.NGAYDEXUAT;
                HQT.TONGTIEN = 0;
                HQT.idTAIKHOAN = idAccount;
                db.PHIEUNHAPHANGTRUSOs.InsertOnSubmit(HQT);
                db.SubmitChanges();
            }
            catch (Exception)
            {
            }
        }
        public void AddHQTicketInfo(string idHQTicket, string idProduct, int quantity, string status, int price, DateTime expdate)
        {
            try
            {
                Cmart5DataContext dbinfo = new Cmart5DataContext();
                CTPHIEUNHAPHANGTRUSO HQTI = new CTPHIEUNHAPHANGTRUSO();

                HQTI.idPHIEUTRUSO = idHQTicket;
                HQTI.idSANPHAM = idProduct;
                HQTI.SOLUONG = quantity;
                HQTI.GIANHAP = price;
                HQTI.HANSD = expdate;
                HQTI.TINHTRANG = status;
                dbinfo.CTPHIEUNHAPHANGTRUSOs.InsertOnSubmit(HQTI);
                dbinfo.SubmitChanges();
            }
            catch (Exception)
            {
            }
        }
        public void UpdateHQTicketInfo(string idTicket, string idProduct, int quantity, string status, int price, DateTime expiredate)
        {
            try
            {
                Cmart5DataContext dbu = new Cmart5DataContext();
                CTPHIEUNHAPHANGTRUSO s = dbu.CTPHIEUNHAPHANGTRUSOs.Single(st => st.idPHIEUTRUSO == idTicket && st.idSANPHAM == idProduct);
                List<CTPHIEUNHAPHANGTRUSO> list = dbu.CTPHIEUNHAPHANGTRUSOs.ToList().Where(st => st.idPHIEUTRUSO == idTicket).ToList();
                PHIEUNHAPHANGTRUSO hq = dbu.PHIEUNHAPHANGTRUSOs.Single(st => st.idPHIEUTRUSO == idTicket);
                hq.TONGTIEN = list.Sum(t => t.SOLUONG); //database sai, dich nham amount thanh tien 

                s.SOLUONG = quantity;
                s.GIANHAP = price;
                s.HANSD = expiredate;
                s.TINHTRANG = status;
                dbu.SubmitChanges();
               
            }
            catch (Exception)
            {

            }
        }
        public void AddBRTicket(string idHeadticket, int idBranch, string idAccount)
        {
            try
            {
                Cmart5DataContext dbBR = new Cmart5DataContext();
                PHIEUNHAPHANGCHINHANH BRT = new PHIEUNHAPHANGCHINHANH();
                PHIEUNHAPHANGTRUSO hq = dbBR.PHIEUNHAPHANGTRUSOs.Single(st => st.idPHIEUTRUSO.Contains(idHeadticket));
                string year = (DateTime.Now.Year % 100).ToString();
                try
                {
                    List<PHIEUNHAPHANGCHINHANH> r = dbBR.PHIEUNHAPHANGCHINHANHs.ToList().Where(st => st.idPHIEUCHINHANH.Substring(2, 2) == year).ToList();
                    string max = r.Max(t => t.idPHIEUCHINHANH);
                    int idnumber = int.Parse(max.Substring(4, 4)) + 1;
                    string maxId = "CN" + year + idnumber.ToString().PadLeft(4, '0');
                    BRT.idPHIEUCHINHANH = maxId;
                }
                catch (NullReferenceException)
                {
                    BRT.idPHIEUCHINHANH = "CN" + year + "0001";
                }
                BRT.idPHIEUTRUSO = idHeadticket;
                BRT.idCHINHANH = idBranch;
                BRT.NGAYNHAP = hq.NGAYNHAP;
                BRT.idTAIKHOAN = idAccount;
                dbBR.PHIEUNHAPHANGCHINHANHs.InsertOnSubmit(BRT);
                dbBR.SubmitChanges();

            }
            catch (Exception)
            {

            }
        }
        //Branch Import Ticket Info
        public void AddTBRicketInfo(string idTicket, string idProduct, int quantity, string status)
        {
            try
            {
                Cmart5DataContext BRTI = new Cmart5DataContext();
                CTPHIEUNHAPHANGCHINHANH BRI = new CTPHIEUNHAPHANGCHINHANH();
                BRI.idPHIEUCHINHANH = idTicket;
                BRI.idSANPHAM = idProduct;
                BRI.SOLUONG = quantity;
                BRI.TINHTRANG = status;
                BRTI.CTPHIEUNHAPHANGCHINHANHs.InsertOnSubmit(BRI);
                BRTI.SubmitChanges();
            }
            catch (Exception)
            {
            }
        }
        public void UpdateBRTicketInfo(string idTicket, string idProduct, int quantity, string status)
        {
            try
            {
                Cmart5DataContext bru = new Cmart5DataContext();
                CTPHIEUNHAPHANGCHINHANH s = bru.CTPHIEUNHAPHANGCHINHANHs.Single(st => st.idPHIEUCHINHANH == idTicket && st.idSANPHAM == idProduct);
                s.SOLUONG = quantity;
                s.TINHTRANG = status;
                bru.SubmitChanges();
            }
            catch (Exception)
            {
            }
        }


    }
}

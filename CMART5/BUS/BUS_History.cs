using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMART5.BUS
{
    class BUS_History
    {
        Cmart5DataContext dba, dbe, dbd;
        public void AddHistory(bool check, string idproduct, int price, DateTime date)
        {
            dba = new Cmart5DataContext();
            LICHSUGIA ls;
            if (check == true)
            {
                ls = new LICHSUGIA();
                ls.idSANPHAM = idproduct;
            }
            else
            {
                ls = dba.LICHSUGIAs.Single( a => (a.idSANPHAM == idproduct) && (a.GIABAN == price) && (a.NGAYHIEULUC == date));
            }
            ls.GIABAN = price;
            ls.NGAYHIEULUC = date;
            if(check == true)
            {
                dba.LICHSUGIAs.InsertOnSubmit(ls);
                dba.SubmitChanges();
                MessageBox.Show("Thêm lịch sử giá thành công");
            }
            else
            {
                dba.SubmitChanges();
                MessageBox.Show("Cập nhập lịch sử giá thành công");
            }
        }
        public void loadHistory (string id, int price, DateTime dt,ComboBox cboSP,TextBox pricce, DateTimePicker dtp)
        {
            dbe = new Cmart5DataContext();
            LICHSUGIA lsload = dbe.LICHSUGIAs.Where(st => st.idSANPHAM == id && st.GIABAN == price && st.NGAYHIEULUC == dt).SingleOrDefault();
            cboSP.SelectedValue = lsload.idSANPHAM.ToString();
            pricce.Text = lsload.GIABAN.ToString();
            dtp.Value = lsload.NGAYHIEULUC;
        }
        public void delHistory (string id,int price,DateTime dt)
        {
            dbd = new Cmart5DataContext();
            LICHSUGIA lsdel = dbd.LICHSUGIAs.Where(st => st.idSANPHAM == id && st.GIABAN == price && st.NGAYHIEULUC == dt).SingleOrDefault();
            dbd.LICHSUGIAs.DeleteOnSubmit(lsdel);
            dbd.SubmitChanges();
            MessageBox.Show("Xóa thành công");
        }
    }
}

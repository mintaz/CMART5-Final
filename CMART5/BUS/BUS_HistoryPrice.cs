using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMART5.BUS
{
    class BUS_HistoryPrice
    {
        Cmart5DataContext dbt;
        public void AddHistory (string idSP,TextBox txtprice,DateTimePicker dtv)
        {
            dbt = new Cmart5DataContext();
            try
            {
                LICHSUGIA ls = new LICHSUGIA();
                ls.idSANPHAM = idSP;
                ls.GIABAN = int.Parse(txtprice.Text);
                ls.NGAYHIEULUC = dtv.Value;
                dbt.LICHSUGIAs.InsertOnSubmit(ls);
                dbt.SubmitChanges();
                MessageBox.Show("Thêm thành công");
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi: \n" + e.Message + "\n vui lòng kiểm tra lại");
            }
        }
        public void UpdatePrice(string idproduct, int am, DateTime dt, string price1, int price2, DateTime price3)
        {
            try
            {
                var s =(from hs in dbt.LICHSUGIAs
                    where hs.idSANPHAM == idproduct && hs.GIABAN == price2 && hs.NGAYHIEULUC == price3
                    select hs).SingleOrDefault();
                s.GIABAN = am;
                s.NGAYHIEULUC = dt;
                dbt.SubmitChanges();
                MessageBox.Show("Cập nhập thành công ");
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: \n" + e.Message + "\n vui lòng kiểm tra lại");
            }
        }
        public void DeletePrice(string id)
        {
            try
            {
                LICHSUGIA s = dbt.LICHSUGIAs.Single(st => st.idSANPHAM == id);
                dbt.LICHSUGIAs.DeleteOnSubmit(s);
                dbt.SubmitChanges();
                MessageBox.Show("Xóa thành công ");
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: \n" + e.Message + "\n vui lòng kiểm tra lại");
            }
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMART5.BUS
{
    class BUS_Discount
    {
        Cmart5DataContext dbt, dbl;
        public void AddEditDiscount(bool check, string idDC,ComboBox cboSP , DevExpress.XtraEditors.TextEdit txtpath, DevExpress.XtraEditors.TextEdit txtprice, DevExpress.XtraEditors.TextEdit txtcontent, DateTimePicker dts, DateTimePicker dtend)
        {
            dbt = new Cmart5DataContext();
            KHUYENMAI km;
            if (check == true)
            {
                km = new KHUYENMAI();
                string year = (DateTime.Now.Year % 100).ToString();
                try
                {
                    List<KHUYENMAI> r = dbt.KHUYENMAIs.ToList().Where(st => st.idKHUYENMAI.Substring(2, 2) == year).ToList();
                    string max = r.Max(t => t.idKHUYENMAI);
                    int idnumber = int.Parse(max.Substring(4, 4)) + 1;
                    string maxId = "KM" + year + idnumber.ToString().PadLeft(4, '0');
                    km.idKHUYENMAI = maxId;
                }
                catch (NullReferenceException)
                {
                    km.idKHUYENMAI = "KM" + year + "0001";
                }
            }
            else
            {
                km = dbt.KHUYENMAIs.Where(a => a.idKHUYENMAI == idDC).SingleOrDefault();
            }
            km.idSANPHAM = cboSP.SelectedValue.ToString();
            km.GIA_KM = double.Parse(txtprice.EditValue.ToString());
            km.HINHANH = txtpath.EditValue.ToString();
            km.NOIDUNG = txtcontent.EditValue.ToString();
            km.TG_BATDAU = dts.Value;
            km.TG_KETTHUC = dtend.Value;
            if (check == true)
            {
                dbt.KHUYENMAIs.InsertOnSubmit(km);
                dbt.SubmitChanges();
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                dbt.SubmitChanges();
                MessageBox.Show("Sửa thành công");
            }


        }
        public void loadDisount(string idDC, ComboBox cboSP, DevExpress.XtraEditors.TextEdit txtpath, DevExpress.XtraEditors.TextEdit txtprice, DevExpress.XtraEditors.TextEdit txtcontent, DateTimePicker dts, DateTimePicker dtend)
        {
            dbl = new Cmart5DataContext();
            var km = dbl.KHUYENMAIs.Where(a => a.idKHUYENMAI == idDC).SingleOrDefault();
            cboSP.SelectedValue = km.idSANPHAM;
            txtcontent.EditValue = km.NOIDUNG;
            txtpath.EditValue = km.HINHANH;
            txtprice.EditValue = km.GIA_KM.ToString();
            dts.Text = km.TG_BATDAU.ToString();
            dtend.Text = km.TG_KETTHUC.ToString();
        }
    }
}

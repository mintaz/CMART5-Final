using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMART5.BUS
{
    class BUS_Supplier
    {
        Cmart5DataContext dbt, dbl;


        public void AddEditSupplier(bool check, string idSup, DevExpress.XtraEditors.TextEdit txtname, DevExpress.XtraEditors.TextEdit txtadd, DevExpress.XtraEditors.TextEdit txtphone)
        {
            dbt = new Cmart5DataContext();
            NHACUNGCAP sup;


            if (check == true)
            {

                sup = new NHACUNGCAP();


                try
                {
                    List<NHACUNGCAP> r = dbt.NHACUNGCAPs.ToList().Where(st => st.idNHACUNGCAP.Substring(0, 3) == "NCC").ToList();
                    string max = r.Max(t => t.idNHACUNGCAP);
                    int idnumber = int.Parse(max.Substring(3, 4)) + 1;
                    string maxId = "NCC" + idnumber.ToString().PadLeft(4, '0');
                    sup.idNHACUNGCAP = maxId;
                }
                catch (NullReferenceException)
                {
                    sup.idNHACUNGCAP = "NCC" + "0001";
                }
            }
            else
            {
                sup = dbt.NHACUNGCAPs.Where(a => a.idNHACUNGCAP == idSup).SingleOrDefault();
            }
            sup.TENNHACUNGCAP = txtname.EditValue.ToString();
            sup.DIACHINHACUNGCAP = txtadd.EditValue.ToString();
            sup.SDT = txtphone.EditValue.ToString();
            if (check == true)
            {
                dbt.NHACUNGCAPs.InsertOnSubmit(sup);
                dbt.SubmitChanges();
                MessageBox.Show("Thêm loại sản phẩm thành công");

            }
            else
            {
                dbt.SubmitChanges();
                MessageBox.Show("Sửa loại sản phẩm thành công");
            }


        }
        public void loadSupplier(string idSup, DevExpress.XtraEditors.TextEdit txtname, DevExpress.XtraEditors.TextEdit txtadd, DevExpress.XtraEditors.TextEdit txtphone)
        {
            dbl = new Cmart5DataContext();
            var ncc = dbl.NHACUNGCAPs.Where(a => a.idNHACUNGCAP == idSup).SingleOrDefault();
            txtname.EditValue = ncc.TENNHACUNGCAP;
            txtadd.EditValue = ncc.DIACHINHACUNGCAP;
            txtphone.EditValue = ncc.SDT;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMART5.BUS
{
    class BUS_Product
    {
        Cmart5DataContext dbt, dbl;


        public void AddEditProduct(bool check, string idSP, DevExpress.XtraEditors.TextEdit txtname, DevExpress.XtraEditors.TextEdit txtpath, ComboBox idprotype, ComboBox idsup)
        {
            dbt = new Cmart5DataContext();
            SANPHAM sp;


            if (check == true)
            {

                sp = new SANPHAM();
                string year = (DateTime.Now.Year % 100).ToString();

                try
                {
                    List<SANPHAM> r = dbt.SANPHAMs.ToList().Where(st => st.idSANPHAM.Substring(2, 2) == year).ToList();
                    string max = r.Max(t => t.idSANPHAM);
                    int idnumber = int.Parse(max.Substring(4, 4)) + 1;
                    string maxId = "MH" + year + idnumber.ToString().PadLeft(4, '0');
                    sp.idSANPHAM = maxId;
                }
                catch (NullReferenceException)
                {
                    sp.idSANPHAM = "MH" + year + "0001";
                }
            }
            else
            {
                sp = dbt.SANPHAMs.Where(a => a.idSANPHAM == idSP).SingleOrDefault();
            }
            sp.TENSP = txtname.Text.ToString();
            sp.HINHANH = txtpath.EditValue.ToString() ;
            sp.idLOAISANPHAM = idprotype.SelectedValue.ToString();
            sp.idNHACUNGCAP = idsup.SelectedValue.ToString();
            if (check == true)
            {
                dbt.SANPHAMs.InsertOnSubmit(sp);
                dbt.SubmitChanges();
                MessageBox.Show("Thêm thành công");

            }
            else
            {
                dbt.SubmitChanges();
                MessageBox.Show("Sửa thành công");
            }
                

        }
        public void loadProduct(string idSP, DevExpress.XtraEditors.TextEdit txtname, DevExpress.XtraEditors.TextEdit txtpath, ComboBox idPDT, ComboBox idSupplier)
        {
            dbl = new Cmart5DataContext();
            var sp = dbl.SANPHAMs.Where(a => a.idSANPHAM == idSP).SingleOrDefault();
            txtname.EditValue = sp.TENSP;
            txtpath.EditValue = sp.HINHANH;
            idPDT.SelectedValue = sp.idLOAISANPHAM;
            idSupplier.SelectedValue = sp.idNHACUNGCAP;
        }
    }
}

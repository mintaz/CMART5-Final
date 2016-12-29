using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMART5.BUS
{
    class BUS_Supplier
    {
        Cmart5DataContext dbt, dbl;


        public void AddEditSupplier(bool check, string idSup, DevExpress.XtraEditors.TextEdit txtname, DevExpress.XtraEditors.TextEdit txtsoluong)
        {
            dbt = new Cmart5DataContext();
            NHACUNGCAP sup;


            if (check == true)
            {

                sup = new NHACUNGCAP();


                //try
                //{
                //    List<NHACUNGCAP> r = dbt.NHACUNGCAP.ToList().Where(st => st.idNHACUNGCAP.Substring(0, 3) == "LSP").ToList();
                //    string max = r.Max(t => t.idLOAISANPHAM);
                //    int idnumber = int.Parse(max.Substring(3, 2)) + 1;
                //    string maxId = "LSP" + idnumber.ToString().PadLeft(2, '0');
                //    sup.idLOAISANPHAM = maxId;
                //}
                //catch (NullReferenceException)
                //{
                //    sup.idLOAISANPHAM = "LSP" + "01";
                //}
            }
            else
            {
            //    sup = dbt.LOAISANPHAMs.Where(a => a.idLOAISANPHAM == idSup).SingleOrDefault();
            //}
            //sup.TENLOAI = txtname.EditValue.ToString();
            //sup.SOLUONG = Int32.Parse(txtsoluong.EditValue.ToString());
            //if (check == true)
            //{
            //    dbt.LOAISANPHAMs.InsertOnSubmit(sup);
            //    dbt.SubmitChanges();
            //    MessageBox.Show("Thêm loại sản phẩm thành công");

            //}
            //else
            //{
            //    dbt.SubmitChanges();
            //    MessageBox.Show("Sửa loại sản phẩm thành công");
            }


        }
        public void loadProductType(string idLSP, DevExpress.XtraEditors.TextEdit txtname, DevExpress.XtraEditors.TextEdit txtsoluong)
        {
            dbl = new Cmart5DataContext();
            var loaisp = dbl.LOAISANPHAMs.Where(a => a.idLOAISANPHAM == idLSP).SingleOrDefault();
            txtname.EditValue = loaisp.TENLOAI;
            txtsoluong.EditValue = loaisp.SOLUONG;

        }
    }
}

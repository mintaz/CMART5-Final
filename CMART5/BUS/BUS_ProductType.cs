using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CMART5.BUS
{
    class BUS_ProductType
    {
        Cmart5DataContext dbt, dbl;


        public void AddEditProductType(bool check, string idLSP, DevExpress.XtraEditors.TextEdit txtname, DevExpress.XtraEditors.TextEdit txtsoluong )
        {
            dbt = new Cmart5DataContext();
            LOAISANPHAM lsp;


            if (check == true)
            {

                lsp = new LOAISANPHAM();
                

                try
                {
                    List<LOAISANPHAM> r = dbt.LOAISANPHAMs.ToList().Where(st => st.idLOAISANPHAM.Substring(0,3)=="LSP").ToList();
                    string max = r.Max(t => t.idLOAISANPHAM);
                    int idnumber = int.Parse(max.Substring(3, 2)) + 1;
                    string maxId = "LSP"+idnumber.ToString().PadLeft(2, '0');
                    lsp.idLOAISANPHAM = maxId;
                }
                catch (NullReferenceException)
                {
                    lsp.idLOAISANPHAM = "LSP" + "01";
                }
            }
            else
            {
                lsp = dbt.LOAISANPHAMs.Where(a => a.idLOAISANPHAM == idLSP).SingleOrDefault();
            }
            lsp.TENLOAI = txtname.EditValue.ToString();
            lsp.SOLUONG = Int32.Parse(txtsoluong.EditValue.ToString());
            if (check == true)
            {
                dbt.LOAISANPHAMs.InsertOnSubmit(lsp);
                dbt.SubmitChanges();
                MessageBox.Show("Thêm loại sản phẩm thành công");

            }
            else
            {
                dbt.SubmitChanges();
                MessageBox.Show("Sửa loại sản phẩm thành công");
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

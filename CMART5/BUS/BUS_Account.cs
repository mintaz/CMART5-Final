using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CMART5.BUS
{
    class BUS_Account
    {
        Cmart5DataContext dbt,dbl;


        public void AddEditAccount(bool check,string idTK,DevExpress.XtraEditors.TextEdit txtname, DevExpress.XtraEditors.TextEdit txtaddress, DevExpress.XtraEditors.TextEdit txtphone, DevExpress.XtraEditors.TextEdit txtcmnd, DevExpress.XtraEditors.TextEdit txtuser, DevExpress.XtraEditors.TextEdit txtpass, int authority)
        {
            dbt = new Cmart5DataContext();
            TAIKHOAN tk;
            
                
                if (check == true)
                   {

                    tk = new TAIKHOAN();
                    string year = (DateTime.Now.Year % 100).ToString();

                    try
                    {
                        List<TAIKHOAN> r = dbt.TAIKHOANs.ToList().Where(st => st.idTAIKHOAN.Substring(2, 2) == year).ToList();
                        string max = r.Max(t => t.idTAIKHOAN);
                        int idnumber = int.Parse(max.Substring(4, 4)) + 1;
                        string maxId = "TK" + year + idnumber.ToString().PadLeft(4, '0');
                        tk.idTAIKHOAN = maxId;
                    }
                    catch (NullReferenceException)
                    {
                        tk.idTAIKHOAN = "TK" + year + "0001";
                    }
                }else
                    {
                        tk = dbt.TAIKHOANs.Where(a => a.idTAIKHOAN == idTK).SingleOrDefault();
                    }
                    tk.HOTEN = txtname.Text.ToString();
                    tk.DIACHI = txtaddress.Text.ToString();
                    tk.SDT = txtphone.Text.ToString();
                    tk.CMND = txtcmnd.Text.ToString();
                    tk.TENDANGNHAP = txtuser.Text.ToString();
                    tk.MATKHAU = txtpass.Text.ToString();
                    tk.QUYEN = authority;
                    if(check==true){
                    dbt.TAIKHOANs.InsertOnSubmit(tk);
                    dbt.SubmitChanges();
                    MessageBox.Show("Thêm tài khoản thành công");
                        
                    }else{
                    dbt.SubmitChanges();
                    MessageBox.Show("Sửa tài khoản thành công");
                    }
                

        }
        public void loadAccount(string idTK, DevExpress.XtraEditors.TextEdit txtname, DevExpress.XtraEditors.TextEdit txtaddress, DevExpress.XtraEditors.TextEdit txtphone, DevExpress.XtraEditors.TextEdit txtcmnd, DevExpress.XtraEditors.TextEdit txtuser, DevExpress.XtraEditors.TextEdit txtpass, ComboBox authority)
        {
            dbl = new Cmart5DataContext();
            var taikhoan = dbl.TAIKHOANs.Where(a => a.idTAIKHOAN == idTK).SingleOrDefault();
            txtname.EditValue = taikhoan.HOTEN;
            txtaddress.EditValue = taikhoan.DIACHI;
            txtphone.EditValue = taikhoan.SDT;
            txtcmnd.EditValue = taikhoan.CMND;
            txtuser.EditValue = taikhoan.TENDANGNHAP;
            txtpass.EditValue = taikhoan.MATKHAU;
            authority.SelectedValue = taikhoan.QUYEN.ToString();

        }
     

       
    }
}

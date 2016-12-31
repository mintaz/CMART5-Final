using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMART5.BUS
{
    class BUS_ChangePass
    {
        Cmart5DataContext dbauth, dbupdate;
        public string getAuth (string id)
        {
            dbauth = new Cmart5DataContext();
            TAIKHOAN tktemp = dbauth.TAIKHOANs.Where(st => st.idTAIKHOAN == id).Single();
            if (tktemp.QUYEN == 1)
            {
                return "Giám Đốc";
            }
            else if (tktemp.QUYEN == 2)
            {
                return "Quản lý chi nhánh";
            }
            else if (tktemp.QUYEN == 3)
            {
                return "Quản lý trụ sở";
            }
            else if (tktemp.QUYEN == 4)
            {
                return "Nhân viên bán hàng";
            }
            else
            {
                return "Thư ký";
            }

        }
        public void UpdatePass(string id,DevExpress.XtraEditors.TextEdit txtpass)
        {
            try
            {
                dbupdate = new Cmart5DataContext();
                TAIKHOAN tkupdatepass = dbauth.TAIKHOANs.Where(st => st.idTAIKHOAN == id).Single();
                tkupdatepass.MATKHAU = txtpass.EditValue.ToString();
                dbupdate.SubmitChanges();
                MessageBox.Show("Đổi mật khẩu thành công");
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi:\n" + e.Message);
            }
                
        }
    }
}

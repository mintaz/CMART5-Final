using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CMART5.BUS
{
    class BUS_Login
    {
        BUS.BUS_Validation valid = new BUS_Validation();
        Cmart5DataContext dbvalid, dbid;
        public int Authorize(DevExpress.XtraEditors.TextEdit user, DevExpress.XtraEditors.TextEdit pass)
        {
            dbvalid = new Cmart5DataContext(); 
            try
            {
                TAIKHOAN account = dbvalid.TAIKHOANs.Single(st => st.TENDANGNHAP == user.Text.ToString());
                if (pass.Text.ToString() == account.MATKHAU)
                {
                    return account.QUYEN;
                }
                else return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public string getID(DevExpress.XtraEditors.TextEdit user, DevExpress.XtraEditors.TextEdit pass)
        {
            dbid = new Cmart5DataContext();
            TAIKHOAN account = dbvalid.TAIKHOANs.Single(st => st.TENDANGNHAP == user.Text.ToString());
            if (pass.Text.ToString() == account.MATKHAU)
            {
                return account.idTAIKHOAN;
            }
            else return null;


        }
        public bool validate(DevExpress.XtraEditors.TextEdit username, DevExpress.XtraEditors.TextEdit password)
        {
            if (!valid.Required(username) && !valid.Required(password))
            {
                return false;
            }
            return true;
        }
    }
}

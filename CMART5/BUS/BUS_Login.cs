using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CMART5.BUS
{
    public class BUS_Login
    {
        BUS.BUS_Validation valid = new BUS_Validation();
        Cmart5DataContext dbvalid, dbid;
        public int Authorize(string user, string pass)
        {
            dbvalid = new Cmart5DataContext(); 
            try
            {
                TAIKHOAN account = dbvalid.TAIKHOANs.Single(st => st.TENDANGNHAP == user);
                if (pass == account.MATKHAU)
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
        public string getID(string user, string pass)
        {
            try
            {
                dbid = new Cmart5DataContext();
                TAIKHOAN id = dbid.TAIKHOANs.Single(st => st.TENDANGNHAP == user);
                if (pass == id.MATKHAU)
                {
                    return id.idTAIKHOAN;
                }
                else
                    return "";
            }
            catch(Exception)
            {
                return "";
            }


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

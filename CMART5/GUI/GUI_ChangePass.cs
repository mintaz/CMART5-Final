using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMART5
{
    public partial class GUI_ChangePass : Form
    {
        public GUI_ChangePass()
        {
            InitializeComponent();
        }
        public string id;
        public string oldpass;
        BUS.BUS_Validation vl = new BUS.BUS_Validation();
        BUS.BUS_ChangePass buscp = new BUS.BUS_ChangePass();
        private void GUI_ChangePass_Load(object sender, EventArgs e)
        {
            
            
            using (Cmart5DataContext dbtemp = new Cmart5DataContext())
            {
                TAIKHOAN acc;
                acc = dbtemp.TAIKHOANs.Where(s => s.idTAIKHOAN == id).Single();
                lblID.Text = "ID: " + acc.idTAIKHOAN;
                lblFullName.Text = "Họ Tên: " + acc.HOTEN;
                lblAdd.Text = "Địa Chỉ: " + acc.DIACHI;
                lblphone.Text = "Phone: " + acc.SDT;
                lblcmnd.Text = "CMND: " + acc.CMND;
                lblusername.Text = "Tên Đăng Nhập: " + acc.TENDANGNHAP;
                lblauth.Text = "Chức Vụ: " + buscp.getAuth(id);
                oldpass = acc.MATKHAU;
            }
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            if (vl.Compare(txtoldpass, oldpass))
            {
                if (vl.Compare(txtnewpass, txtcofpass) == true)
                {
                    buscp.UpdatePass(id, txtnewpass);
                }
                else
                {
                    MessageBox.Show("Mật khẩu xác nhận không đúng, vui lòng nhập lại");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng, vui lòng nhập lại");
            }
            
        }

            
    }
}

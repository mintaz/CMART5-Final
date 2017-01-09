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
    public partial class GUI_Login : Form
    {
        public GUI_Login()
        {
            InitializeComponent();
        }
        BUS.BUS_Login loginval = new BUS.BUS_Login();


        private void GUI_Login_Load(object sender, EventArgs e)
        {

        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            try
            {
                if (loginval.validate(txtusename,txtpass))
                {
                    string name = txtusename.EditValue.ToString();
                    string pass = txtpass.EditValue.ToString();
                    int i = loginval.Authorize(name, pass);
                    string idac = loginval.getID(name, pass);
                    if (i == 0)
                    {
                        MessageBox.Show("Sai Tên đăng nhập hoặc mật khẩu");
                    }
                    else
                    {
                        Main mainform = new Main();
                        mainform.auth = i;
                        mainform.idacc = idac;
                        mainform.FormClosing += delegate { this.Show(); };
                        mainform.Show();
                        this.Hide();
                    }
                }
                else{
                    MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu");
                }
        }
            catch (Exception)
            {
                MessageBox.Show("Đăng nhập thất bại do lỗi đường truyền đến server");
            }
        }
    }
}


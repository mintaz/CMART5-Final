using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CMART5
{
    public partial class GUI_CRUDAccount : Form
    {
        public GUI_CRUDAccount()
        {
            InitializeComponent();
        }
        BUS.BUS_Validation valid = new BUS.BUS_Validation();
        BUS.BUS_Account bus = new BUS.BUS_Account();
        public string idTK;
        public bool isthem;
        private void GUI_CRUDAccount_Load(object sender, EventArgs e)
        {
            var authority = new[]
            {
                new { Text = "Director",Value ="1"},
                new { Text = "Branch Manager",Value ="2"},
                new { Text = "Store Manager",Value ="3"},
                new { Text = "Seller",Value ="4"},
                new { Text = "Secretary",Value ="5"}
            };
            cboquyen.DisplayMember = "Text";
            cboquyen.ValueMember = "Value";
            cboquyen.DataSource = authority;
            if (!isthem)
            {
                bus.loadAccount(idTK, txtname, txtaddress, txtphone, txtcmnd, txtuser, txtpass, cboquyen);
            }
            else
            {
                txtname.EditValue = "";
                txtaddress.EditValue = "";
                txtphone.EditValue = "";
                txtcmnd.EditValue = "";
                txtuser.EditValue = "";
                txtpass.EditValue = "cmart123";
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if(!valid.Required(txtname))
            {
                MessageBox.Show("Vui lòng nhập họ tên tài khoản");
            }
            else if(!valid.Required(txtaddress))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ");
            }
            else if(!valid.Required(txtcmnd))
            {
                MessageBox.Show("Vui lòng nhập số chứng minh nhân dân");
            }
            else if (!valid.Required(txtphone))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại");
            }
            else if (!valid.Required(txtuser))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập");
            }
            else if (!valid.Required(txtpass))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
            }
            else
            {
                if (valid.IsNum(txtcmnd) == false)
                {
                    MessageBox.Show("Số chứng minh nhân dân sai định dạng, vui lòng nhập lại");
                }else if(valid.IsNum(txtphone)==false)
                {
                    MessageBox.Show("Số điện thoại sai định dạng, vui lòng nhập lại");
                }
                else
                {
                    int authority = int.Parse(cboquyen.SelectedValue.ToString());
                    bus.AddEditAccount(isthem, idTK, txtname, txtaddress, txtphone, txtcmnd, txtuser, txtpass, authority);
                }
            }
                
        }

    }
}

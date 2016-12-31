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
                txtpass.EditValue = "";
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                int authority = int.Parse(cboquyen.SelectedValue.ToString());
                bus.AddEditAccount(isthem,idTK,txtname, txtaddress, txtphone, txtcmnd, txtuser, txtpass, authority);
        }

    }
}

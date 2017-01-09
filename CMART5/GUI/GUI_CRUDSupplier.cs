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
    public partial class GUI_CRUDSupplier : Form
    {
        public GUI_CRUDSupplier()
        {
            InitializeComponent();
        }
        BUS.BUS_Supplier bussup = new BUS.BUS_Supplier();
        BUS.BUS_Validation valid = new BUS.BUS_Validation();
        public string idSup;
        public bool isthem;

        private void GUI_CRUDSupplier_Load(object sender, EventArgs e)
        {
            if (!isthem)
            {
                bussup.loadSupplier(idSup,txtname,txtaddress,txtphone);
            }
            else
            {
                txtname.EditValue = "";
                txtaddress.EditValue = "";
                txtphone.EditValue = "";

            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (valid.Required(txtname) == false)
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp");
            }else if(valid.Required(txtphone)==false)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại nhà cung cấp");
            }
            else if(valid.Required(txtaddress)==false)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ nhà cung cấp");
            }
            else
            {
                if (valid.IsNum(txtphone) == false)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng kiểm tra lại số điện thoại");
                }else
                bussup.AddEditSupplier(isthem, idSup, txtname, txtaddress, txtphone);
            }
        }

    }
}

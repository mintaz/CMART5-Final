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
    public partial class GUI_CRUDProductType : Form
    {
        public GUI_CRUDProductType()
        {
            InitializeComponent();
        }
        BUS.BUS_ProductType bus = new BUS.BUS_ProductType();
        BUS.BUS_Validation valid = new BUS.BUS_Validation();
        public string idLSP;
        public bool isthem;

       
        private void GUI_CRUDProductType_Load(object sender, EventArgs e)
        {
            txtsoluong.Enabled = false;
            if(!isthem)
            {
                
                bus.loadProductType(idLSP, txtname,txtsoluong);
            }
            else
            {
                txtname.EditValue = "";
                
            }
        }
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(valid.Required(txtname)==false)
            {
                MessageBox.Show("Vui lòng nhập tên loại sản phẩm");
            }
            else
            {
                bus.AddEditProductType(isthem, idLSP, txtname);
            }
            

        }

    }
}

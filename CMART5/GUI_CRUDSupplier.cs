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
        string idSup;
        bool isthem;

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
            bussup.AddEditSupplier(isthem, idSup, txtname, txtaddress, txtphone);

        }

    }
}

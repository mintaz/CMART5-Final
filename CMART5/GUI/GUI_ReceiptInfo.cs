using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMART5.GUI
{
    public partial class GUI_ReceiptInfo : Form
    {
        Cmart5DataContext dbt, dbl;
        public GUI_ReceiptInfo()
        {
            InitializeComponent();
            lookUpEdit1.Properties.DataSource = new CMART5.Cmart5DataContext().SANPHAMs;
            lookUpEdit1.Properties.DisplayMember = "TENSP";
            lookUpEdit1.Properties.ValueMember = "idSANPHAM";
        }

        public string IDrec;
        private void loadData()
        {
            dbl = new Cmart5DataContext();
            var ds = dbl.CTHOADONs.Where(st => st.idHOADON.Contains(this.IDrec)).ToList();
            gcInfo.DataSource = ds;
            lookUpEdit1.Properties.ValueMember = "idSANPHAM";
            lookUpEdit1.Properties.DisplayMember = "TENSP";
            lookUpEdit1.ItemIndex = 1;
        }
        private void GUI_ReceiptInfo_Load(object sender, EventArgs e)
        {
            loadData();
        }
        int index;
        BUS.BUS_Receipt busz, buz;

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = true;
            string idpro = lookUpEdit1.EditValue.ToString();
            int qt = int.Parse(numb.Value.ToString());
            if (numb.Value <= 0)
            {
                MessageBox.Show("vui lòng nhập số lượng lớn hơn 0");
                check = false;
            }
            else if (idpro == null)
            {
                MessageBox.Show("Vui lòng chọn 1 sản phẩm");
                check = false;
            }
            if (check == true)
            {
                buz = new BUS.BUS_Receipt();
                buz.AddInfo(this.IDrec, idpro, qt);
                loadData();

            }
        }

        private void gvInfo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
        }

        private void gcInfo_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int cash = int.Parse(txtdua.Text);
            busz.UpdateInfo(IDrec, cash);

        }

    }
}

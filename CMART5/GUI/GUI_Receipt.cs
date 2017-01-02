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
    public partial class GUI_Receipt : Form
    {
        public GUI_Receipt()
        {
            InitializeComponent();
        }
        int index;
        public string idaccount;
        public int pos;
        BUS.BUS_Receipt brc = new BUS.BUS_Receipt();
        private void loadData()
        {
            Cmart5DataContext dbl = new Cmart5DataContext();
            var ds = dbl.HOADONs.ToList();
            gcReceipt.DataSource = ds;
        }

        private void GUI_HQTicket_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void gvHQticket_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
        }

        private void gvHQticket_DoubleClick(object sender, EventArgs e)
        {
            GUI.GUI_ReceiptInfo frc = new GUI.GUI_ReceiptInfo();
            frc.IDrec = gvReceipt.GetRowCellValue(index, this.ID).ToString();
            frc.ShowDialog();
            btnAdd.Enabled = false;
            loadData();
            btnAdd.Enabled = true;
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            GUI.GUI_ReceiptInfo frc = new GUI.GUI_ReceiptInfo();
            frc.IDrec = gvReceipt.GetRowCellValue(index, this.ID).ToString();
            frc.ShowDialog();
            btnAdd.Enabled = false;
            loadData();
            btnAdd.Enabled = true;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            brc.AddReceipt(idaccount, pos);
            loadData();
        }
    }
}

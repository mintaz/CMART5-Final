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
    public partial class GUI_HQTicket : Form
    {
        public GUI_HQTicket()
        {
            InitializeComponent();
        }
        int index;
        private void loadData()
        {
            Cmart5DataContext dbl = new Cmart5DataContext();
            var ds = dbl.PHIEUNHAPHANGTRUSOs.ToList();
            gcHQticket.DataSource = ds;
            lkRequest.Properties.DataSource = new Cmart5DataContext().PHIEUDEXUATs;
            lkRequest.Properties.ValueMember = "idPHIEUDEXUAT";
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
            GUI_HQTicketInfo fhq = new GUI_HQTicketInfo();
            fhq.IDtick = gvHQticket.GetRowCellValue(index, this.IDHQ).ToString();
            fhq.ShowDialog();
            btn_AddTick.Enabled = false;
            loadData();
            btn_AddTick.Enabled = true;
        }

        private void btn_AddTick_Click(object sender, EventArgs e)
        {
            string idRequest = lkRequest.EditValue.ToString();
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            GUI_HQTicketInfo fhq = new GUI_HQTicketInfo();
            fhq.IDtick = gvHQticket.GetRowCellValue(index, this.IDHQ).ToString();
            btn_AddTick.Enabled = false;
            fhq.ShowDialog();
            loadData();
            btn_AddTick.Enabled = true;
        }
    }
}

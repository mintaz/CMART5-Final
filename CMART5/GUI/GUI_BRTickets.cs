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
    public partial class GUI_BRTickets : Form
    {
        public GUI_BRTickets()
        {
            InitializeComponent();
        }
        int index;
        BUS.BUS_Validation valid = new BUS.BUS_Validation();
        public string idaccount;
        BUS.BUS_Tickets busbr = new BUS.BUS_Tickets();   
        private void loadData()
        {
            Cmart5DataContext dbl = new Cmart5DataContext();
            var ds = dbl.PHIEUNHAPHANGCHINHANHs.ToList();
            gcBRticket.DataSource = ds;
            cborequest.DataSource = dbl.PHIEUNHAPHANGTRUSOs.ToList();
            cborequest.ValueMember = "idPHIEUTRUSO";
            var br = new[]
                {
                new { Text ="1",Value ="1"},
                new { Text ="2",Value ="2"},
                 };
            cbBR.DataSource = br;
            cbBR.DisplayMember = "Text";
            cbBR.ValueMember = "Value";
            
        }

        private void GUI_HQTicket_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void gvBRticket_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
        }

        private void gvBRticket_DoubleClick(object sender, EventArgs e)
        {
            GUI_BRTicketInfo fbr = new GUI_BRTicketInfo();
            fbr.IDtick = gvBRticket.GetRowCellValue(index, this.IDBR).ToString();
            fbr.ShowDialog();
            btn_AddTick.Enabled = false;
            loadData();
            btn_AddTick.Enabled = true;
        }

        private void btn_AddTick_Click(object sender, EventArgs e)
        {
            string idRequest = cborequest.SelectedValue.ToString();
            int ibranch = int.Parse(cbBR.SelectedValue.ToString());
            if (valid.Required(cborequest)==false)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập hàng trụ sở");
            }
            else
            {
                busbr.AddBRTicket(idRequest, ibranch, idaccount);
                loadData();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            GUI_BRTicketInfo fbr = new GUI_BRTicketInfo();
            fbr.IDtick = gvBRticket.GetRowCellValue(index, this.IDBR).ToString();
            btn_AddTick.Enabled = false;
            fbr.ShowDialog();
            //this.Enabled = false;
            loadData();
            btn_AddTick.Enabled = true;
        }
    }
}

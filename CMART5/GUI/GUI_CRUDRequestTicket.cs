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
    public partial class GUI_CRUDRequestTicket : Form
    {
        public GUI_CRUDRequestTicket()
        {
            InitializeComponent();
        }
        public string id;
        Cmart5DataContext dbload;
        BUS.BUS_Tickets busreq;
        private void GUI_CRUDRequestTicket_Load(object sender, EventArgs e)
        {
            dbload = new Cmart5DataContext();
            var ncc = dbload.NHACUNGCAPs.ToList();
            cboncc.DataSource = ncc;
            cboncc.DisplayMember = "TENNHACUNGCAP";
            cboncc.ValueMember = "idNHACUNGCAP"; 
        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            busreq = new BUS.BUS_Tickets();
            busreq.AddRQTicket(cboncc, id);
        }

    }
}

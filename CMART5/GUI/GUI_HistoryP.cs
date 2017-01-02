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
    public partial class GUI_HistoryP : Form
    {
        public GUI_HistoryP()
        {
            InitializeComponent();
        }
        Cmart5DataContext dbhis;
        public void loadData()
        {
            dbhis = new Cmart5DataContext();
            var history = dbhis.LICHSUGIAs.ToList();
            gcHistory.DataSource = history;
            cboSP.DataSource = dbhis.SANPHAMs.ToList();
            cboSP.DisplayMember = "TENSP";
            cboSP.ValueMember = "idSANPHAM";
            dthis.Value = DateTime.Now;
        }
        private void GUI_HistoryP_Load(object sender, EventArgs e)
        {
            loadData();
            btnSave.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
        }
        public bool isthem;
        int index;
        BUS.BUS_History bushistory;
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isthem = true;
            bushistory = new BUS.BUS_History();
            string idpro = cboSP.SelectedValue.ToString();
            int price = int.Parse(txtprice.Text);
            DateTime dta = dthis.Value;
            bushistory.AddHistory(isthem, idpro,price, dta);
            loadData();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isthem = false;
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            bushistory = new BUS.BUS_History();
            string idproduct = gvHistory.GetRowCellValue(index,this.IDSP).ToString();
            int price2 = int.Parse(gvHistory.GetRowCellValue(index,this.GIA).ToString());
            DateTime dtexp = (DateTime)gvHistory.GetRowCellValue(index,this.EXP);
            bushistory.loadHistory(idproduct,price2,dtexp,cboSP,txtprice,dthis);
            cboSP.Enabled = false;
        }

        private void gvHistory_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isthem = false;
            bushistory = new BUS.BUS_History();
            string idpro = cboSP.SelectedValue.ToString();
            int price = int.Parse(txtprice.Text);
            DateTime dta = dthis.Value;
            bushistory.AddHistory(isthem, idpro, price, dta);
            loadData();
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnDel.Enabled = true;
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bushistory = new BUS.BUS_History();
             string iddel = gvHistory.GetRowCellValue(index,this.IDSP).ToString();
            int price3 = int.Parse(gvHistory.GetRowCellValue(index,this.GIA).ToString());
            DateTime dtexp1 = (DateTime)gvHistory.GetRowCellValue(index,this.EXP);
            bushistory.delHistory(iddel, price3, dtexp1);
            loadData();
        }
    }
}

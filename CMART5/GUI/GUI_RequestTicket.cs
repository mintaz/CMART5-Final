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
    public partial class GUI_RequestTicket : Form
    {
        public GUI_RequestTicket()
        {
            InitializeComponent();
        }
        Cmart5DataContext dbl;
        public string idacc;
        int index;
        private void loadData()
        {
            dbl = new Cmart5DataContext();
            var ds = dbl.PHIEUDEXUATs.ToList();
            gcRequestTicket.DataSource = ds;
        }
        private void GUI_RequestTicket_Load(object sender, EventArgs e)
        {
            loadData();

        }

        private void btn_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_CRUDRequestTicket frmrequest = new GUI_CRUDRequestTicket();
            frmrequest.id = idacc;
            frmrequest.ShowDialog();
            loadData();
        }

        private void gvRequestTicket_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
        }

        private void gcRequestTicket_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GUI_RequestInfo frmRQinfo = new GUI_RequestInfo();
                frmRQinfo.IDtick = gvRequestTicket.GetRowCellValue(index, this.ID).ToString();
                frmRQinfo.ShowDialog();
                loadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn chưa chọn đối tượng, hoặc danh sách trống. Vui lòng kiểm tra lại");
            }
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                GUI_RequestInfo frmRQinfo = new GUI_RequestInfo();
                frmRQinfo.IDtick = gvRequestTicket.GetRowCellValue(index, this.ID).ToString();
                frmRQinfo.ShowDialog();
                loadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn chưa chọn đối tượng, hoặc danh sách trống. Vui lòng kiểm tra lại");
            }
            
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CMART5
{
    public partial class GUI_ProductType : Form
    {
        public GUI_ProductType()
        {
            InitializeComponent();
        }
        Cmart5DataContext dbl;
        int index;
        private void loadData()
        {
            dbl = new Cmart5DataContext();
            var ds = dbl.LOAISANPHAMs.ToList();
            gcProductype.DataSource = ds;
        }

        private void GUI_ProductType_Load(object sender, EventArgs e)
        {
            loadData();

        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_CRUDProductType fzm = new GUI_CRUDProductType();
            fzm.isthem = true;
            fzm.ShowDialog();
            loadData();
        }

        private void gvProductype_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;

        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_CRUDProductType frm = new GUI_CRUDProductType();
            frm.isthem = false;
            frm.idLSP = gvProductype.GetRowCellValue(index, this.ID).ToString();
            frm.ShowDialog();
            loadData();

        }

        private void gvProductype_DoubleClick(object sender, EventArgs e)
        {
            GUI_CRUDProductType fnm = new GUI_CRUDProductType();
            fnm.isthem = false;
            fnm.idLSP = gvProductype.GetRowCellValue(index, this.ID).ToString();
            fnm.ShowDialog();
            loadData();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Bạn có chắc chắn xóa loại sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cmart5DataContext dbx = new Cmart5DataContext();
                    var loaispham = dbx.LOAISANPHAMs.Where(a => a.idLOAISANPHAM == gvProductype.GetRowCellValue(index, this.ID).ToString()).SingleOrDefault();
                    dbx.LOAISANPHAMs.DeleteOnSubmit(loaispham);
                    dbx.SubmitChanges();
                    XtraMessageBox.Show("Đã xóa thành công", "Thông Báo");
                }
            }
            catch (Exception er)
            {
                XtraMessageBox.Show("Lỗi:\n" + er.Message, "Thông báo");
            }
            loadData();
        }

        private void btnreload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
        }
    }
}

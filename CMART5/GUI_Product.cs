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
    public partial class GUI_Product : Form
    {
        public GUI_Product()
        {
            InitializeComponent();
        }
        Cmart5DataContext dbl;
        int index;
        private void loadData()
        {
            dbl = new Cmart5DataContext();
            var ds = dbl.SANPHAMs.ToList();
            gcProduct.DataSource = ds;
        }

        private void GUI_Product_Load(object sender, EventArgs e)
        {
            loadData();

        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_CRUDAccount fzm = new GUI_CRUDAccount();
            fzm.isthem = true;
            fzm.ShowDialog();
            loadData();
        }

        private void gvProduct_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;

        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_CRUDAccount frm = new GUI_CRUDAccount();
            frm.isthem = false;
            frm.idSP = gvProduct.GetRowCellValue(index, this.ID).ToString();
            frm.ShowDialog();
            loadData();

        }

        private void gvProduct_DoubleClick(object sender, EventArgs e)
        {
            GUI_CRUDAccount fnm = new GUI_CRUDAccount();
            fnm.isthem = false;
            fnm.idSP = gvProduct.GetRowCellValue(index, this.ID).ToString();
            fnm.ShowDialog();
            loadData();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Bạn có chắc chắn xóa sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cmart5DataContext dbx = new Cmart5DataContext();
                    var taikhoan = dbx.SANPHAMs.Where(a => a.idSANPHAM == gvProduct.GetRowCellValue(index, this.ID).ToString()).SingleOrDefault();
                    dbx.SANPHAMs.DeleteOnSubmit(taikhoan);
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

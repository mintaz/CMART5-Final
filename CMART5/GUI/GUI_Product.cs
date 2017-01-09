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
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;

namespace CMART5
{
    public partial class GUI_Product : Form
    {
        public GUI_Product()
        {
            InitializeComponent();
        }
        Cmart5DataContext dbl;
        BUS.BUS_Validation valid = new BUS.BUS_Validation();
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
            GUI_CRUDProduct fzm = new GUI_CRUDProduct();
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
            GUI_CRUDProduct frm = new GUI_CRUDProduct();
            frm.isthem = false;
            try
            {
                string tmpid = gvProduct.GetRowCellValue(index, this.ID).ToString();
                if (valid.Required(tmpid) == false)
                {
                    MessageBox.Show("Bạn chưa chọn đối tượng, hoặc danh sách trống. Vui lòng kiểm tra lại");
                }
                else
                {
                    frm.idSP = tmpid;
                    frm.ShowDialog();
                    loadData();
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Bạn chưa chọn đối tượng, hoặc danh sách trống. Vui lòng kiểm tra lại");
            }
           

        }

        private void gvProduct_DoubleClick(object sender, EventArgs e)
        {
            GUI_CRUDProduct fnm = new GUI_CRUDProduct();
            fnm.isthem = false;
            fnm.idSP = gvProduct.GetRowCellValue(index, this.ID).ToString();
            fnm.ShowDialog();
            loadData();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string tmpid = gvProduct.GetRowCellValue(index, this.ID).ToString();
                if (XtraMessageBox.Show("Bạn có chắc chắn xóa sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cmart5DataContext dbx = new Cmart5DataContext();
                    var sanpham = dbx.SANPHAMs.Where(a => a.idSANPHAM == tmpid ).SingleOrDefault();
                    dbx.SANPHAMs.DeleteOnSubmit(sanpham);
                    dbx.SubmitChanges();
                    XtraMessageBox.Show("Đã xóa thành công", "Thông Báo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn chưa chọn đối tượng, hoặc danh sách trống. Vui lòng kiểm tra lại");
            }
            loadData();
        }

        private void btnreload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
        }

        
        
    }
}

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
    public partial class GUI_Supplier : Form
    {
        public GUI_Supplier()
        {
            InitializeComponent();
        }
        Cmart5DataContext dbl;
        BUS.BUS_Validation valid = new BUS.BUS_Validation();
        int index;
        private void loadData()
        {
            dbl = new Cmart5DataContext();
            var ds = dbl.NHACUNGCAPs.ToList();
            gcSupplier.DataSource = ds;
        }

        private void GUI_Supplier_Load(object sender, EventArgs e)
        {
            loadData();

        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_CRUDSupplier fzm = new GUI_CRUDSupplier();
            fzm.isthem = true;
            fzm.ShowDialog();
            loadData();
        }

        private void gvSupplier_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;

        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_CRUDSupplier frm = new GUI_CRUDSupplier();
            frm.isthem = false;
            try
            {
                string tmpid = gvSupplier.GetRowCellValue(index, this.ID).ToString();
                if (valid.Required(tmpid) == false)
                {
                    MessageBox.Show("Bạn chưa chọn đối tượng, hoặc danh sách trống. Vui lòng kiểm tra lại");
                }
                else
                {
                    frm.idSup = tmpid;
                    frm.ShowDialog();
            loadData();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn chưa chọn đối tượng, hoặc danh sách trống. Vui lòng kiểm tra lại");
            }
            

        }

        private void gvSupplier_DoubleClick(object sender, EventArgs e)
        {
            GUI_CRUDSupplier fnm = new GUI_CRUDSupplier();
            fnm.isthem = false;
            fnm.idSup = gvSupplier.GetRowCellValue(index, this.ID).ToString();
            fnm.ShowDialog();
            loadData();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string tmpid = gvSupplier.GetRowCellValue(index, this.ID).ToString();
                if (valid.Required(tmpid) == false)
                {
                    MessageBox.Show("Bạn chưa chọn đối tượng, hoặc danh sách trống. Vui lòng kiểm tra lại");
                }
                else
                {
                    if (XtraMessageBox.Show("Bạn có chắc chắn xóa  không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Cmart5DataContext dbx = new Cmart5DataContext();
                        var NHACUNGCAP = dbx.NHACUNGCAPs.Where(a => a.idNHACUNGCAP == tmpid).SingleOrDefault();
                        dbx.NHACUNGCAPs.DeleteOnSubmit(NHACUNGCAP);
                        dbx.SubmitChanges();
                        XtraMessageBox.Show("Đã xóa thành công", "Thông Báo");
                    }
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Bạn chưa chọn đối tượng, hoặc danh sách trống. Vui lòng kiểm tra lại", "Thông báo");
            }
            loadData();
        }

        private void btnreload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
        }
    }
}

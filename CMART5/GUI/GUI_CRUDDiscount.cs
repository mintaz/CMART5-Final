using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMART5
{
    public partial class GUI_CRUDDiscount : Form
    {
        public GUI_CRUDDiscount()
        {
            InitializeComponent();
        }
        BUS.BUS_Validation valid = new BUS.BUS_Validation();
        public bool isthem;
        public string idDC;
        string crfilename;
        public string maxId;
        public string picturepath = "";
        string apath = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
        BUS.BUS_Discount busdiscount = new BUS.BUS_Discount();
        private void GUI_CRUDDiscount_Load(object sender, EventArgs e)
        {
            txtpath.Enabled = false;
            using (Cmart5DataContext temp = new Cmart5DataContext())
            {
                var item = temp.SANPHAMs.ToList();
                cboSP.DataSource = item;
                cboSP.DisplayMember = "TENSP";
                cboSP.ValueMember = "idSANPHAM";
            }
            if(!isthem)
            {
                busdiscount.loadDisount(idDC, cboSP, txtpath, txtprice, txtND, dtStart, dtEnd);
                picturepath = txtpath.EditValue.ToString();
                ptDiscount.ImageLocation = apath + "\\" + picturepath;
                ptDiscount.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                cboSP.SelectedIndex = 1;
                txtND.EditValue = "";
                txtpath.EditValue = "";
                txtprice.EditValue = "";
                dtStart.Value = DateTime.Now;
                dtEnd.Value = DateTime.Now;
            }
        }

        private void btnAddHinhKM_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "C:\\";
            open.Filter = "Hình Ảnh (*.jpg) | *.jpg";
            open.FilterIndex = 1;
            open.Multiselect = false;
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (open.CheckFileExists)
                {
                    crfilename = Path.GetFileName(open.FileName);
                    File.Delete(apath + "\\Images\\" + crfilename);
                    File.Copy(open.FileName, apath + "\\Images\\" + crfilename);
                }
                if (isthem == true)
                {
                    using (Cmart5DataContext temz = new Cmart5DataContext())
                    {
                        string year = (DateTime.Now.Year % 100).ToString();
                        try
                        {
                            List<KHUYENMAI> r = temz.KHUYENMAIs.ToList().Where(st => st.idKHUYENMAI.Substring(2, 2) == year).ToList();
                            string max = r.Max(t => t.idKHUYENMAI);
                            int idnumber = int.Parse(max.Substring(4, 4)) + 1;
                            maxId = "KM" + year + idnumber.ToString().PadLeft(4, '0');
                        }
                        catch (NullReferenceException)
                        {
                            maxId = "KM" + year + "0001";
                        }
                    }
                    txtpath.EditValue = ("\\Images\\" + maxId + ".jpg");
                }
                else
                {
                    txtpath.EditValue = ("\\Images\\" + idDC + ".jpg");
                }
                ptDiscount.ImageLocation = (apath + "\\Images\\" + crfilename);
                ptDiscount.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                txtpath.EditValue = "";
            }
           
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (valid.Required(txtprice) == false)
            {
                MessageBox.Show("vui lòng nhập giá khuyến mãi");
            }
            else if(valid.Required(txtND)==false)
            {
                MessageBox.Show("Vui lòng nhập nội dung khuyến mãi");
            }
            else if (valid.Compare(dtStart, dtEnd) == false)
            {
                MessageBox.Show("Ngày bắt đầu không được trễ hơn ngày kết thúc, vui lòng kiểm tra lại");
            }
            else
            {
                if (valid.IsNum(txtprice) == false)
                {
                    MessageBox.Show("Giá sản phẩm không hợp lệ, vui lòng nhập lại.");
                }
                else
                {

                    if (isthem == true)
                    {
                        File.Delete(apath + "\\Images\\" + maxId + ".jpg");
                        File.Move(apath + "\\Images\\" + crfilename, apath + "\\Images\\" + maxId + ".jpg");
                    }
                    else
                    {
                        File.Delete(apath + "\\Images\\" + idDC + ".jpg");
                        File.Move(apath + "\\Images\\" + crfilename, apath + "\\Images\\" + idDC + ".jpg");
                    }
                    busdiscount.AddEditDiscount(isthem, idDC, cboSP, txtpath, txtprice, txtND, dtStart, dtEnd);
                }
            }
        }

    }
}

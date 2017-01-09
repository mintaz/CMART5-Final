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
    public partial class GUI_CRUDProduct : Form
    {
        public GUI_CRUDProduct()
        {
            InitializeComponent();
        }
        public string idSP;
        public bool isthem;
        public string picturepath= "";
        public string idproducttype;
        public string idsupplier;
        string crfilename;
        public string maxId;
        string apath = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
        BUS.BUS_Product busproduct = new BUS.BUS_Product();
        BUS.BUS_Validation valid = new BUS.BUS_Validation();
        private void GUI_CRUDProduct_Load(object sender, EventArgs e)
        {
            txtpath.Enabled = false;

             using(Cmart5DataContext temp = new Cmart5DataContext())
             {
                 cboproducttype.DataSource = temp.LOAISANPHAMs.ToList();
                 cboproducttype.ValueMember = "idLOAISANPHAM";
                 cboproducttype.DisplayMember = "TENLOAI";

             }
             using (Cmart5DataContext temp = new Cmart5DataContext())
             {
                 cbonhacc.DataSource = temp.NHACUNGCAPs.ToList();
                 cbonhacc.ValueMember = "idNHACUNGCAP";
                 cboproducttype.DisplayMember = "TENNHACUNGCAP";
             }
             if (!isthem)
             {
                 busproduct.loadProduct(idSP, txtname,txtpath,cboproducttype,cbonhacc);
                 picturepath = txtpath.EditValue.ToString();
                 picturebox.ImageLocation =apath+"\\"+picturepath;
                 picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
             }
             else
             {
                 txtname.EditValue = "";
                 txtpath.EditValue = "";

             }
        
        }

        private void btnaddphoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "C:\\";
            open.Filter = "Hình Ảnh (*.jpg) | *.jpg";
            open.FilterIndex = 1;
            open.Multiselect = false;
            if(open.ShowDialog()== DialogResult.OK)
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
                            List<SANPHAM> r = temz.SANPHAMs.ToList().Where(st => st.idSANPHAM.Substring(2, 2) == year).ToList();
                            string max = r.Max(t => t.idSANPHAM);
                            int idnumber = int.Parse(max.Substring(4, 4)) + 1;
                            maxId = "MH" + year + idnumber.ToString().PadLeft(4, '0');
                        }catch(NullReferenceException)
                        {
                            maxId = "MH" + year + "0001";
                        }
                    }
                    txtpath.EditValue = ("\\Images\\" + maxId + ".jpg");
                }
                else
                {
                    txtpath.EditValue = ("\\Images\\" + idSP + ".jpg");
                }
                picturebox.ImageLocation = (apath + "\\Images\\" + crfilename);
                picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                txtpath.EditValue = "";
            }
            
            
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (valid.Required(txtname) == false)
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm");
            }
            else
            {


            if (txtpath.EditValue.ToString() != "")
            {
                idproducttype = cboproducttype.SelectedValue.ToString();
                idsupplier = cbonhacc.SelectedValue.ToString();
                if (isthem == true)
                {

                    File.Delete(apath + "\\Images\\" + maxId + ".jpg");
                    File.Move(apath + "\\Images\\" + crfilename, apath + "\\Images\\" + maxId + ".jpg");

                }
                else
                {
                    File.Delete(apath + "\\Images\\" + idSP + ".jpg");
                    File.Move(apath + "\\Images\\" + crfilename, apath + "\\Images\\" + idSP + ".jpg");
                }
            }
                busproduct.AddEditProduct(isthem, idSP, txtname, txtpath, cboproducttype, cbonhacc);
            }
        }
    }
}

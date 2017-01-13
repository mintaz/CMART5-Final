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
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
namespace CMART5.GUI
{
    public partial class GUI_Stat : Form
    {
        public GUI_Stat()
        {
            InitializeComponent();
        }
        Cmart5DataContext dbl;
        public string idaccount;
        public void Loaddata()
        {
            dbl = new Cmart5DataContext();
            gcStat.DataSource = dbl.HOADONs.ToList();
        }
        public void LoadData(DateTime d1, DateTime d2)
        {
            dbl = new Cmart5DataContext();
            gcStat.DataSource = dbl.HOADONs.Where(st => st.NGAYBAN.Value >= d1 && st.NGAYBAN <= d2).ToList();
        }
        public void LoadData(DateTime d1)
        {
            dbl = new Cmart5DataContext();
            gcStat.DataSource = dbl.HOADONs.Where(st => st.NGAYBAN.Value.Date == d1).ToList();
        }
        public void PrintData()
        {
            dbl = new Cmart5DataContext();
            Report.Stat report = new Report.Stat();
            report.DataSource =  dbl.HOADONs.ToList();
            report.ShowPreviewDialog();
        }
        public void PrintData(DateTime d1, DateTime d2)
        {
            dbl = new Cmart5DataContext();
            Report.Stat report = new Report.Stat();
            report.DataSource = dbl.HOADONs.Where(st => st.NGAYBAN.Value >= d1 && st.NGAYBAN <= d2).ToList();
            report.ShowPreviewDialog();
        }
        public void PrintData(DateTime d1)
        {
            dbl = new Cmart5DataContext();
            Report.Stat report = new Report.Stat();
            report.DataSource = dbl.HOADONs.Where(st => st.NGAYBAN.Value.Date == d1).ToList();
            report.ShowPreviewDialog();
        }
        int caseswitch;
        
        private void rbdate_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control c in gbDate.Controls)
            {
                c.Enabled = true;
                caseswitch = 1;
            }
            foreach (Control c in groupBox2.Controls)
            {
                c.Enabled = false;
            }
            foreach (Control c in groupBox3.Controls)
            {
                c.Enabled = false;
            }
            foreach (Control c in groupBox4.Controls)
            {
                c.Enabled = false;
            }
        }

        private void GUI_Stat_Load(object sender, EventArgs e)
        {
            rbdate.Checked = true;
            Loaddata();
        }

        private void rbMonth_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control c in gbDate.Controls)
            {
                c.Enabled = false;
            }
            foreach (Control c in groupBox2.Controls)
            {
                c.Enabled = true;
                caseswitch = 2;
            }
            foreach (Control c in groupBox3.Controls)
            {
                c.Enabled = false;
            }
            foreach (Control c in groupBox4.Controls)
            {
                c.Enabled = false;
            }
        }

        private void rbYear_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control c in gbDate.Controls)
            {
                c.Enabled = false;
            }
            foreach (Control c in groupBox2.Controls)
            {
                c.Enabled = false;
            }
            foreach (Control c in groupBox3.Controls)
            {
                c.Enabled = true;
                caseswitch =3;
            }
            foreach (Control c in groupBox4.Controls)
            {
                c.Enabled = false;
            }
        }

        private void rbTime_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control c in gbDate.Controls)
            {
                c.Enabled = false;
            }
            foreach (Control c in groupBox2.Controls)
            {
                c.Enabled = false;
            }
            foreach (Control c in groupBox3.Controls)
            {
                c.Enabled = false;
            }
            foreach (Control c in groupBox4.Controls)
            {
                c.Enabled = true;
                caseswitch = 4;
            }
        }
        public void SumT()
        {
            var sum = gvStat.Columns["TT"].SummaryItem.SummaryValue.ToString();
            lblT.Text = sum;
        }
        public void SumA()
        {
            var sum = gvStat.Columns["SL"].SummaryItem.SummaryValue.ToString();
            lblSL.Text = sum;
        }
        private void btnStat_Click(object sender, EventArgs e)
        {
            switch (caseswitch)
            {
                case 1:
                    LoadData(dtDate.Value);
                    SumT();
                    SumA();
                    break;
                case 2:
                    LoadData(dtMonth1.Value, dtMonth2.Value);
                    SumT();
                    SumA();
                    break;
                case 3:
                    LoadData(dtYear1.Value, dtYear2.Value);
                    SumT();
                    SumA();
                    break;
                case 4:
                    LoadData(dtTime1.Value, dtTime2.Value);
                    SumT();
                    SumA();
                    break;
                default:
                    Loaddata();
                    break;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            switch (caseswitch)
            {
                case 1:
                    LoadData(dtDate.Value);
                    SumT();
                    SumA();
                    PrintData(dtDate.Value);
                    break;
                case 2:
                    LoadData(dtMonth1.Value, dtMonth2.Value);
                    SumT();
                    SumA();
                    PrintData(dtMonth1.Value, dtMonth2.Value);
                    break;
                case 3:
                    LoadData(dtYear1.Value, dtYear2.Value);
                    SumT();
                    SumA();
                    PrintData(dtMonth1.Value, dtMonth2.Value);
                    break;
                case 4:
                    LoadData(dtTime1.Value, dtTime2.Value);
                    SumT();
                    SumA();
                    PrintData(dtTime1.Value, dtTime2.Value);
                    break;
                default:
                    Loaddata();
                    PrintData();
                    break;
            }
        }
    }
}

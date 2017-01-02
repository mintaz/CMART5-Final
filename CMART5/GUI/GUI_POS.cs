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
    public partial class GUI_POS : Form
    {
        public GUI_POS()
        {
            InitializeComponent();
        }
        public string idaccount;
        GUI_Receipt rc;

        private void GUI_POS_Load(object sender, EventArgs e)
        {
            var pos = new[]
            {
                new { Text = "1",Value ="1"},
                new { Text = "2",Value ="2"},
                new { Text = "3",Value ="3"},
                new { Text = "4",Value ="4"},
            };
            cbopos.DataSource = pos;
            cbopos.DisplayMember = "Text";
            cbopos.ValueMember = "Value";
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(cbopos.SelectedValue.ToString());        
            rc = new GUI_Receipt();
            rc.idaccount = idaccount;
            rc.pos = pos;
            rc.FormClosing += delegate { this.Close(); };
            rc.Show();
            this.Hide();
        }
    }
}

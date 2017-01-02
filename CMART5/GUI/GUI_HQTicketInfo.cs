﻿using System;
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
    public partial class GUI_HQTicketInfo : Form
    {
        public GUI_HQTicketInfo()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            lookUpEdit1.Properties.DataSource = new CMART5.Cmart5DataContext().SANPHAMs;
            lookUpEdit1.Properties.DisplayMember = "TENSP";
            lookUpEdit1.Properties.ValueMember = "idSANPHAM";
            var status = new[]
                {
                new { Text = "Đủ",Value ="Đủ"},
                new { Text = "Thiếu",Value ="Thiếu"},
                new { Text = "Hư",Value ="Hư"},
                 };
            cbostatus.DisplayMember = "Text";
            cbostatus.ValueMember = "Value";
            cbostatus.DataSource = status;
        }
        public string IDtick;

        
        Cmart5DataContext dbl;
        int index;

        private void loadData()
        {
            dbl = new Cmart5DataContext();
            var ds = dbl.CTPHIEUNHAPHANGTRUSOs.Where(st => st.idPHIEUTRUSO.Contains(this.IDtick)).ToList();
            gcHQticketInfo.DataSource = ds;
            lookUpEdit1.Properties.ValueMember = "idSANPHAM";
            lookUpEdit1.ItemIndex = 1;
            txtprice.Text = "";
            dtexp.Value = DateTime.Now;
            cbostatus.SelectedIndex = 0;
            numb.ResetText();
        }

        private void GUI_HQTicketInfo_Load(object sender, EventArgs e)
        {
            loadData();
            btnSave.Enabled = false;

        }
       
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = true;
            string idpro = lookUpEdit1.EditValue.ToString();
            int qt = int.Parse(numb.Value.ToString());
            string st = cbostatus.SelectedValue.ToString();
            double pri = double.Parse(txtprice.Text.ToString());
            DateTime exp = dtexp.Value;
            if(idpro==null || qt==0 || st == null || pri ==0)
            { MessageBox.Show("Err");
            check = false;
            };
            if (check==true){
            BUS.BUS_Tickets buz = new BUS.BUS_Tickets();
            buz.AddHQTicketInfo(this.IDtick,idpro,qt,st,pri,exp);
            loadData();
            }
            
        }

        private void gvHQticketInfo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;

        }



        private void gvHQticketInfo_DoubleClick(object sender, EventArgs e)
        {
            lookUpEdit1.EditValue = gvHQticketInfo.GetRowCellValue(index, this.IDSP);
            lookUpEdit1.Enabled = false;
            btnAdd.Enabled = false;
            cbostatus.SelectedValue = gvHQticketInfo.GetRowCellValue(index, this.STATUS).ToString();
            dtexp.Value = (DateTime)gvHQticketInfo.GetRowCellValue(index, this.EXP);
            txtprice.Text = gvHQticketInfo.GetRowCellValue(index, this.GIA).ToString();
            numb.Value = (int)gvHQticketInfo.GetRowCellValue(index, this.SOLUONG);
        }


        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string idp = lookUpEdit1.EditValue.ToString();
            int qa = int.Parse(numb.Value.ToString());
            DateTime expt = dtexp.Value;
            int price = int.Parse(txtprice.Text);
            string st = cbostatus.SelectedValue.ToString();
            BUS.BUS_Tickets buzu = new BUS.BUS_Tickets();
            buzu.UpdateHQTicketInfo(IDtick, idp, qa, st, price, expt);
            loadData();
            btnAdd.Enabled = true;
            lookUpEdit1.Enabled = true;
            btnSave.Enabled = false;
        }

        private void btn_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            //string idHQT = gvHQticketInfo.GetRowCellValue(index, this.IDHQ).ToString();
            lookUpEdit1.EditValue = gvHQticketInfo.GetRowCellValue(index, this.IDSP);
            lookUpEdit1.Enabled = false;
            cbostatus.SelectedValue = gvHQticketInfo.GetRowCellValue(index, this.STATUS).ToString();
            dtexp.Value = (DateTime)gvHQticketInfo.GetRowCellValue(index, this.EXP);
            txtprice.Text = gvHQticketInfo.GetRowCellValue(index, this.GIA).ToString();
            numb.Value = (int)gvHQticketInfo.GetRowCellValue(index, this.SOLUONG);

        }
    }
}

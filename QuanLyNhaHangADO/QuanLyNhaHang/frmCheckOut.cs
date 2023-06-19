﻿using QuanLyNhaHang.BS_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class frmCheckOut : Form
    {
        BLTblMain dbTblMain = new BLTblMain();
        DataTable dtTblMain = null;
        string err;
        public frmCheckOut()
        {
            InitializeComponent();
        }
        public double amt = 0;
        public double received = 0;
        public double change = 0;
        public int billID = 0;
        

        private void frmCheckOut_Load(object sender, EventArgs e)
        {
            txtBillAmount.Text = amt.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (dbTblMain.UpdateCheckOut(billID, amt, received, change, "Paid", ref err))
            {
                //   guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Show("Lưu thành công");
                this.Close();
            }
            else
            {
                guna2MessageDialog1.Show("Lưu không thành công");                
            }
        }

        private void txtReceived_TextChanged_1(object sender, EventArgs e)
        {
            double.TryParse(txtBillAmount.Text, out amt);
            double.TryParse(txtReceived.Text, out received);
            change = Math.Abs(amt - received);
            txtChange.Text = change.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

﻿using QuanLyNhaHang.BS_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class tableForm : Form
    {
        DataTable dtT = null;
        string err;
        BLTable dbT = new BLTable();
        public tableForm()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dtT = new DataTable();
                dtT.Clear();
                DataSet ds = dbT.LayTable();
                dtT = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvTable.DataSource = dtT;
                // Thay đổi độ rộng cột
                dgvTable.AutoResizeColumns();
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi rồi!!!");
            }
        }

        private void tableForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmTableAdd frm = new frmTableAdd();
            frm.txtTableID.ReadOnly = false;
            frm.txtTableName.ReadOnly = false;
            List<string> listTstate = new List<string>();
            listTstate.Add("Bàn trống");
            listTstate.Add("Đã đặt");
            frm.cbbTstate.DataSource = listTstate;
            frm.ShowDialog();
            LoadData();
        }

        private void txtSearchTable_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtT = new DataTable();
                dtT.Clear();
                DataSet ds = dbT.TimKiemTable(txtSearchTable.Text);
                dtT = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvTable.DataSource = dtT;
                // Thay đổi độ rộng cột
                dgvTable.AutoResizeColumns();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không lấy được nội dung trong table BAN. Lỗi: " + ex);
            }
        }

        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTable.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                frmTableAdd frm = new frmTableAdd();
                frm.txtTableID.ReadOnly = true;
                frm.txtTableName.ReadOnly = true;
                List<string> listTstate = new List<string>();
                listTstate.Add("Bàn trống");
                listTstate.Add("Đã đặt");
                frm.cbbTstate.DataSource = listTstate;
                frm.txtTableID.Text = dgvTable.CurrentRow.Cells["dgvTid"].Value.ToString();
                frm.txtTableName.Text = dgvTable.CurrentRow.Cells["dgvTname"].Value.ToString();
                frm.cbbTstate.Text = dgvTable.CurrentRow.Cells["dgvTstate"].Value.ToString();
                frm.ShowDialog();
                if (txtSearchTable.Text != "")
                {
                    dgvTable.DataSource = dbT.TimKiemTable(txtSearchTable.Text);
                }
                else
                {
                    LoadData();
                }
            }
            else if (dgvTable.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xoá dòng này không?", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (dbT.XoaTable(dgvTable.CurrentRow.Cells["dgvTid"].Value.ToString(), ref err))
                    {

                        txtSearchTable.Text = "";
                        LoadData();
                        MessageBox.Show("Xoá thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xoá không thành công. Lỗi: '" + err + "'");
                    }
                }

            }

        }
    }
}

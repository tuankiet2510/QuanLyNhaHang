﻿namespace QuanLyNhaHang
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.lblHello = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.img3 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.img2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.img1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home Page";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 54);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.lblQuyen);
            this.panel2.Controls.Add(this.lblHello);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1400, 159);
            this.panel2.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(1031, 96);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(64, 31);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "label";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(1031, 23);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(64, 31);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "label";
            // 
            // lblQuyen
            // 
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuyen.ForeColor = System.Drawing.Color.White;
            this.lblQuyen.Location = new System.Drawing.Point(105, 96);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(91, 31);
            this.lblQuyen.TabIndex = 1;
            this.lblQuyen.Text = "Quyền: ";
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.ForeColor = System.Drawing.Color.White;
            this.lblHello.Location = new System.Drawing.Point(83, 23);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(113, 31);
            this.lblHello.TabIndex = 0;
            this.lblHello.Text = "Xin chào: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::QuanLyNhaHang.Properties.Resources.imgHOme;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.img3);
            this.panel3.Controls.Add(this.img2);
            this.panel3.Controls.Add(this.img1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1400, 519);
            this.panel3.TabIndex = 11;
            // 
            // img3
            // 
            this.img3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.img3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.img3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.img3.CheckedState.FillColor = System.Drawing.Color.DarkTurquoise;
            this.img3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.img3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.img3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.img3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.img3.FillColor = System.Drawing.SystemColors.ControlDark;
            this.img3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.img3.ForeColor = System.Drawing.Color.White;
            this.img3.Location = new System.Drawing.Point(722, 486);
            this.img3.Name = "img3";
            this.img3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.img3.Size = new System.Drawing.Size(30, 30);
            this.img3.TabIndex = 13;
            this.img3.Click += new System.EventHandler(this.img3_Click);
            // 
            // img2
            // 
            this.img2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.img2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.img2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.img2.CheckedState.FillColor = System.Drawing.Color.DarkTurquoise;
            this.img2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.img2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.img2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.img2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.img2.FillColor = System.Drawing.SystemColors.ControlDark;
            this.img2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.img2.ForeColor = System.Drawing.Color.White;
            this.img2.Location = new System.Drawing.Point(669, 486);
            this.img2.Name = "img2";
            this.img2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.img2.Size = new System.Drawing.Size(30, 30);
            this.img2.TabIndex = 12;
            this.img2.Click += new System.EventHandler(this.img2_Click);
            // 
            // img1
            // 
            this.img1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.img1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.img1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.img1.Checked = true;
            this.img1.CheckedState.FillColor = System.Drawing.Color.DarkTurquoise;
            this.img1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.img1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.img1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.img1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.img1.FillColor = System.Drawing.SystemColors.ControlDark;
            this.img1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.img1.ForeColor = System.Drawing.Color.White;
            this.img1.Location = new System.Drawing.Point(616, 486);
            this.img1.Name = "img1";
            this.img1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.img1.Size = new System.Drawing.Size(30, 30);
            this.img1.TabIndex = 11;
            this.img1.Click += new System.EventHandler(this.img1_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 732);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lblHello;
        public System.Windows.Forms.Label lblQuyen;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2CircleButton img3;
        private Guna.UI2.WinForms.Guna2CircleButton img2;
        private Guna.UI2.WinForms.Guna2CircleButton img1;
    }
}
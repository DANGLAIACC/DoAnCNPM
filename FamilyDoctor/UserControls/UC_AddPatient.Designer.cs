namespace GUI.UserControls
{
    partial class UC_AddPatient
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AddPatient));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.lblTuoi = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.tglGender = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.cboTuoi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.txtTienSu = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.lblTuoi);
            this.panel2.Controls.Add(this.lblGender);
            this.panel2.Controls.Add(this.tglGender);
            this.panel2.Controls.Add(this.cboTuoi);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtPhone2);
            this.panel2.Controls.Add(this.txtPhone1);
            this.panel2.Controls.Add(this.txtTienSu);
            this.panel2.Controls.Add(this.txtDiaChi);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtTen);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 415);
            this.panel2.TabIndex = 10;
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 8;
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(211, 336);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(157, 45);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Nhập lại";
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 8;
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(374, 336);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(157, 45);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            // 
            // lblTuoi
            // 
            this.lblTuoi.AutoSize = true;
            this.lblTuoi.Location = new System.Drawing.Point(449, 78);
            this.lblTuoi.Name = "lblTuoi";
            this.lblTuoi.Size = new System.Drawing.Size(54, 28);
            this.lblTuoi.TabIndex = 5;
            this.lblTuoi.Text = "Nam";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(521, 128);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(54, 28);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Nam";
            // 
            // tglGender
            // 
            this.tglGender.Checked = true;
            this.tglGender.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tglGender.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tglGender.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tglGender.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tglGender.CheckedState.Parent = this.tglGender;
            this.tglGender.Location = new System.Drawing.Point(468, 132);
            this.tglGender.Name = "tglGender";
            this.tglGender.ShadowDecoration.Parent = this.tglGender;
            this.tglGender.Size = new System.Drawing.Size(35, 20);
            this.tglGender.TabIndex = 3;
            this.tglGender.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tglGender.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tglGender.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tglGender.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tglGender.UncheckedState.Parent = this.tglGender;
            // 
            // cboTuoi
            // 
            this.cboTuoi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cboTuoi.Location = new System.Drawing.Point(145, 72);
            this.cboTuoi.Name = "cboTuoi";
            this.cboTuoi.Size = new System.Drawing.Size(158, 34);
            this.cboTuoi.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Điện thoại 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Điện thoại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(369, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 28);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tuổi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // txtPhone2
            // 
            this.txtPhone2.Location = new System.Drawing.Point(145, 178);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(200, 34);
            this.txtPhone2.TabIndex = 4;
            // 
            // txtPhone1
            // 
            this.txtPhone1.Location = new System.Drawing.Point(145, 125);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(200, 34);
            this.txtPhone1.TabIndex = 2;
            // 
            // txtTienSu
            // 
            this.txtTienSu.Location = new System.Drawing.Point(145, 284);
            this.txtTienSu.Name = "txtTienSu";
            this.txtTienSu.Size = new System.Drawing.Size(386, 34);
            this.txtTienSu.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(145, 231);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(386, 34);
            this.txtDiaChi.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tiền sử";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa chỉ";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(145, 19);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(386, 34);
            this.txtTen.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // UC_AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_AddPatient";
            this.Size = new System.Drawing.Size(585, 415);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.Label lblTuoi;
        private System.Windows.Forms.Label lblGender;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tglGender;
        private System.Windows.Forms.DateTimePicker cboTuoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.TextBox txtTienSu;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label1;
    }
}

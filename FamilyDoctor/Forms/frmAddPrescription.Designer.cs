namespace GUI.Forms
{
    partial class frmAddPrescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddPrescription));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnPatientInfo = new System.Windows.Forms.Panel();
            this.cboExamType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtHospital = new System.Windows.Forms.TextBox();
            this.txtRec_note = new System.Windows.Forms.TextBox();
            this.txtRec_diagnostic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPat_id = new System.Windows.Forms.Label();
            this.lblPat_name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnPrescritionItems = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnPatientInfo.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1200, 749);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1096F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1190, 739);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblTitle.Location = new System.Drawing.Point(51, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1088, 47);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Tạo đơn thuốc mới";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(1157, 14);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(18, 18);
            this.btnClose.TabIndex = 100;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pnPatientInfo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnPrescritionItems, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(50, 50);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1090, 686);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // pnPatientInfo
            // 
            this.pnPatientInfo.Controls.Add(this.cboExamType);
            this.pnPatientInfo.Controls.Add(this.txtHospital);
            this.pnPatientInfo.Controls.Add(this.txtRec_note);
            this.pnPatientInfo.Controls.Add(this.txtRec_diagnostic);
            this.pnPatientInfo.Controls.Add(this.label6);
            this.pnPatientInfo.Controls.Add(this.label2);
            this.pnPatientInfo.Controls.Add(this.label7);
            this.pnPatientInfo.Controls.Add(this.label3);
            this.pnPatientInfo.Controls.Add(this.lblPat_id);
            this.pnPatientInfo.Controls.Add(this.lblPat_name);
            this.pnPatientInfo.Controls.Add(this.label5);
            this.pnPatientInfo.Controls.Add(this.label1);
            this.pnPatientInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPatientInfo.Location = new System.Drawing.Point(3, 3);
            this.pnPatientInfo.Name = "pnPatientInfo";
            this.pnPatientInfo.Size = new System.Drawing.Size(1084, 154);
            this.pnPatientInfo.TabIndex = 0;
            // 
            // cboExamType
            // 
            this.cboExamType.BackColor = System.Drawing.Color.Transparent;
            this.cboExamType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboExamType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExamType.FocusedColor = System.Drawing.Color.Empty;
            this.cboExamType.FocusedState.Parent = this.cboExamType;
            this.cboExamType.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboExamType.ForeColor = System.Drawing.Color.Black;
            this.cboExamType.FormattingEnabled = true;
            this.cboExamType.HoverState.Parent = this.cboExamType;
            this.cboExamType.ItemHeight = 30;
            this.cboExamType.ItemsAppearance.Parent = this.cboExamType;
            this.cboExamType.Location = new System.Drawing.Point(877, 11);
            this.cboExamType.Name = "cboExamType";
            this.cboExamType.ShadowDecoration.Parent = this.cboExamType;
            this.cboExamType.Size = new System.Drawing.Size(187, 36);
            this.cboExamType.TabIndex = 0;
            this.cboExamType.SelectedIndexChanged += new System.EventHandler(this.cboExamType_SelectedIndexChanged);
            // 
            // txtHospital
            // 
            this.txtHospital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHospital.Location = new System.Drawing.Point(736, 100);
            this.txtHospital.Multiline = true;
            this.txtHospital.Name = "txtHospital";
            this.txtHospital.Size = new System.Drawing.Size(328, 38);
            this.txtHospital.TabIndex = 3;
            this.txtHospital.Text = "Yêu cầu nhập viện";
            // 
            // txtRec_note
            // 
            this.txtRec_note.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRec_note.Location = new System.Drawing.Point(210, 100);
            this.txtRec_note.Multiline = true;
            this.txtRec_note.Name = "txtRec_note";
            this.txtRec_note.Size = new System.Drawing.Size(366, 38);
            this.txtRec_note.TabIndex = 2;
            this.txtRec_note.Text = "Lưu ý cho bệnh nhân";
            // 
            // txtRec_diagnostic
            // 
            this.txtRec_diagnostic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRec_diagnostic.Location = new System.Drawing.Point(210, 53);
            this.txtRec_diagnostic.Multiline = true;
            this.txtRec_diagnostic.Name = "txtRec_diagnostic";
            this.txtRec_diagnostic.Size = new System.Drawing.Size(854, 38);
            this.txtRec_diagnostic.TabIndex = 1;
            this.txtRec_diagnostic.Text = "Kết quả chẩn đoán của bác sĩ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lưu ý với bệnh nhân:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kết quả chẩn đoán:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(625, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nhập viện:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(766, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại khám:";
            // 
            // lblPat_id
            // 
            this.lblPat_id.AutoSize = true;
            this.lblPat_id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPat_id.Location = new System.Drawing.Point(161, 16);
            this.lblPat_id.Name = "lblPat_id";
            this.lblPat_id.Size = new System.Drawing.Size(108, 28);
            this.lblPat_id.TabIndex = 0;
            this.lblPat_id.Text = "01234567";
            // 
            // lblPat_name
            // 
            this.lblPat_name.AutoSize = true;
            this.lblPat_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPat_name.Location = new System.Drawing.Point(386, 16);
            this.lblPat_name.Name = "lblPat_name";
            this.lblPat_name.Size = new System.Drawing.Size(363, 28);
            this.lblPat_name.TabIndex = 0;
            this.lblPat_name.Text = "HOÀNG THỤC LINH LINH LINH LINH ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã bệnh nhân:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // pnPrescritionItems
            // 
            this.pnPrescritionItems.AllowDrop = true;
            this.pnPrescritionItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrescritionItems.Location = new System.Drawing.Point(3, 163);
            this.pnPrescritionItems.Name = "pnPrescritionItems";
            this.pnPrescritionItems.Size = new System.Drawing.Size(1084, 460);
            this.pnPrescritionItems.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnThem);
            this.flowLayoutPanel1.Controls.Add(this.btnClear);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 629);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1084, 54);
            this.flowLayoutPanel1.TabIndex = 2;
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
            this.btnThem.Location = new System.Drawing.Point(924, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(157, 45);
            this.btnThem.TabIndex = 99;
            this.btnThem.TabStop = false;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.btnClear.Location = new System.Drawing.Point(761, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(157, 45);
            this.btnClear.TabIndex = 100;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Nhập lại";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(4, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 375, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(379, 23);
            this.label4.TabIndex = 101;
            this.label4.Text = "Double click vào số thứ tự để hủy phần thuốc.";
            // 
            // frmAddPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1200, 749);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddPrescription";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo đơn thuốc";
            this.Load += new System.EventHandler(this.frmAddPrescription_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnPatientInfo.ResumeLayout(false);
            this.pnPatientInfo.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnPatientInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPat_name;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Panel pnPrescritionItems;
        private System.Windows.Forms.Label lblPat_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRec_diagnostic;
        private System.Windows.Forms.TextBox txtRec_note;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHospital;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cboExamType;
    }
}
namespace GUI.UserControls
{
    partial class UC_PrescriptionItem
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSTT = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSang = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTrua = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtToi = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel1.Controls.Add(this.lblSTT);
            this.flowLayoutPanel1.Controls.Add(this.txtTen);
            this.flowLayoutPanel1.Controls.Add(this.guna2HtmlLabel2);
            this.flowLayoutPanel1.Controls.Add(this.txtSang);
            this.flowLayoutPanel1.Controls.Add(this.guna2HtmlLabel3);
            this.flowLayoutPanel1.Controls.Add(this.txtTrua);
            this.flowLayoutPanel1.Controls.Add(this.guna2HtmlLabel4);
            this.flowLayoutPanel1.Controls.Add(this.txtToi);
            this.flowLayoutPanel1.Controls.Add(this.guna2HtmlLabel5);
            this.flowLayoutPanel1.Controls.Add(this.txtNote);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1084, 42);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblSTT
            // 
            this.lblSTT.BackColor = System.Drawing.Color.Transparent;
            this.lblSTT.IsContextMenuEnabled = false;
            this.lblSTT.IsSelectionEnabled = false;
            this.lblSTT.Location = new System.Drawing.Point(3, 3);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(17, 18);
            this.lblSTT.TabIndex = 99;
            this.lblSTT.TabStop = false;
            this.lblSTT.Text = "01";
            this.lblSTT.DoubleClick += new System.EventHandler(this.lblSTT_DoubleClick);
            // 
            // txtTen
            // 
            this.txtTen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTen.Location = new System.Drawing.Point(26, 3);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(394, 34);
            this.txtTen.TabIndex = 0;
            this.txtTen.Leave += new System.EventHandler(this.txtTen_Leave);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.IsContextMenuEnabled = false;
            this.guna2HtmlLabel2.IsSelectionEnabled = false;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(426, 3);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(38, 18);
            this.guna2HtmlLabel2.TabIndex = 99;
            this.guna2HtmlLabel2.TabStop = false;
            this.guna2HtmlLabel2.Text = "Sáng:";
            // 
            // txtSang
            // 
            this.txtSang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSang.Location = new System.Drawing.Point(470, 3);
            this.txtSang.Name = "txtSang";
            this.txtSang.Size = new System.Drawing.Size(32, 34);
            this.txtSang.TabIndex = 1;
            this.txtSang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSang_KeyPress);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.IsContextMenuEnabled = false;
            this.guna2HtmlLabel3.IsSelectionEnabled = false;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(508, 3);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(46, 30);
            this.guna2HtmlLabel3.TabIndex = 99;
            this.guna2HtmlLabel3.TabStop = false;
            this.guna2HtmlLabel3.Text = "Trưa:";
            // 
            // txtTrua
            // 
            this.txtTrua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTrua.Location = new System.Drawing.Point(560, 3);
            this.txtTrua.Name = "txtTrua";
            this.txtTrua.Size = new System.Drawing.Size(32, 34);
            this.txtTrua.TabIndex = 2;
            this.txtTrua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSang_KeyPress);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.IsContextMenuEnabled = false;
            this.guna2HtmlLabel4.IsSelectionEnabled = false;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(598, 3);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(26, 18);
            this.guna2HtmlLabel4.TabIndex = 99;
            this.guna2HtmlLabel4.TabStop = false;
            this.guna2HtmlLabel4.Text = "Tối:";
            // 
            // txtToi
            // 
            this.txtToi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToi.Location = new System.Drawing.Point(630, 3);
            this.txtToi.Name = "txtToi";
            this.txtToi.Size = new System.Drawing.Size(32, 34);
            this.txtToi.TabIndex = 3;
            this.txtToi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSang_KeyPress);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.IsContextMenuEnabled = false;
            this.guna2HtmlLabel5.IsSelectionEnabled = false;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(668, 3);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(73, 30);
            this.guna2HtmlLabel5.TabIndex = 99;
            this.guna2HtmlLabel5.TabStop = false;
            this.guna2HtmlLabel5.Text = "Ghi chú:";
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.Location = new System.Drawing.Point(747, 3);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(264, 34);
            this.txtNote.TabIndex = 4;
            this.txtNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNote_KeyDown);
            // 
            // UC_PrescriptionItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UC_PrescriptionItem";
            this.Size = new System.Drawing.Size(1084, 42);
            this.Load += new System.EventHandler(this.UC_PrescriptionItem_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtSang;
        private System.Windows.Forms.TextBox txtTrua;
        private System.Windows.Forms.TextBox txtToi;
        private System.Windows.Forms.TextBox txtNote;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSTT;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
    }
}

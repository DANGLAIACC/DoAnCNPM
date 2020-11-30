namespace GUI.Reports
{
    partial class frmReportPrescription
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
            this.CrystalReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rpt = new GUI.Reports.Prescription();
            this.SuspendLayout();
            // 
            // CrystalReport
            // 
            this.CrystalReport.ActiveViewIndex = -1;
            this.CrystalReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrystalReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrystalReport.DisplayStatusBar = false;
            this.CrystalReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrystalReport.Location = new System.Drawing.Point(0, 0);
            this.CrystalReport.Name = "CrystalReport";
            this.CrystalReport.Size = new System.Drawing.Size(886, 571);
            this.CrystalReport.TabIndex = 0;
            this.CrystalReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmReportPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 571);
            this.Controls.Add(this.CrystalReport);
            this.Name = "frmReportPrescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrescription";
            this.Load += new System.EventHandler(this.frmReportPrescription_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrystalReport;
        private Prescription rpt;
    }
}
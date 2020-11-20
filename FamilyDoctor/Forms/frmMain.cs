using GUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class frmMain : Form
    {
        int PanelWidth;
        bool isCollapsed;

        public frmMain()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            UC_Patient uch = new UC_Patient();
            AddControlsToPanel(uch);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
        
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }
        private void btnPatient_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnPatient);
            UC_Patient uch = new UC_Patient();
            AddControlsToPanel(uch);
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnMedicine);
            UC_Sales us = new UC_Sales();
            AddControlsToPanel(us);
        }

        private void btnExamination_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnExamination);
            UC_PurchaseDetails up = new UC_PurchaseDetails();
            AddControlsToPanel(up);
        }

        private void btnHospital_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHospital);
            UC_ManageExpense ea = new UC_ManageExpense();
            AddControlsToPanel(ea);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnUsers);
            UC_ManageUser um = new UC_ManageUser();
            AddControlsToPanel(um);
        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnViewSales);
            UC_ViewSales vs = new UC_ViewSales();
            AddControlsToPanel(vs);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSettings);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:mm:ss dd/MM/yyyy");
        }
         
    }
}

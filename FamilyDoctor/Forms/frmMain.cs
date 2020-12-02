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
using GUI.global;

namespace GUI.Forms
{
    public partial class frmMain : Form
    {
        int PanelWidth;

        public frmMain()
        {
            InitializeComponent();

            timerTime.Start();
            PanelWidth = panelLeft.Width;
            UC_Patient uch = new UC_Patient();
            AddControlsToPanel(uch);

            lblDoctor.Text = List.curentDoctor.Doc_title + " " + List.curentDoctor.Doc_fullname;
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
            UC_Medicine us = new UC_Medicine();
            AddControlsToPanel(us);
        }

        private void btnExamination_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnExamination);
            UC_Examination u = new UC_Examination();
            AddControlsToPanel(u);
        }

        private void btnHospital_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHospital);
            UC_Hospital ea = new UC_Hospital();
            AddControlsToPanel(ea);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnUsers);
            UC_Analytic ua = new UC_Analytic();
            AddControlsToPanel(ua);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:mm:ss dd/MM/yyyy");
        }
         
    }
}

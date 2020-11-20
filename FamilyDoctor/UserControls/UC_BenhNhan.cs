using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using GUI.global;

namespace GUI.UserControls
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            if(GlobalVariable.lstPatient.Count == 0)
            { // mảng chưa có bệnh nhân nào
                GlobalVariable.lstPatient = Patient_BLL.getPatient();
            }
            foreach (Patient_DTO p in GlobalVariable.lstPatient)
            {
                grvLstBenhNhan.Rows.Add(new string[] {
                        p.Pat_id.ToString(),
                    p.Pat_fullname,
                    p.Pat_phone1,
                    p.Pat_dob.ToString("dd/MM/yyyy"),
                    p.Pat_address
                });
            }

            grvLstBenhNhan.Columns[0].Width = 100;
        }

        private void grvLstBenhNhan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            MessageBox.Show("Xuất hồ sơ bệnh án của hồ sơ " + GlobalVariable.lstPatient[e.RowIndex].Pat_id);
        }
    }
}

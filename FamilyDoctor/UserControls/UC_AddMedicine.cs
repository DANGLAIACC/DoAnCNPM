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

namespace GUI.UserControls
{
    public partial class UC_AddMedicine : UserControl
    {
        public string med_name="";
        public UC_AddMedicine(string medId)
        {
            InitializeComponent();

            txtMedId.Focus();
            // Truyền vào mã thuốc
            if(medId != "")
            {
                txtMedId.Enabled = false;
                txtMedName.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMedName.Text = "";
            if (txtMedId.Enabled)
            {
                txtMedId.Text = "";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // đang xử lý ngược làm sao UCMedicine biết đã thêm thuốc mới thành công

            string med_id = txtMedId.Text.Trim(), med_name = txtMedName.Text.Trim();
            if (med_id == "" || med_name == "")
            {
                MessageBox.Show("Mã thuốc hoặc tên thuốc không hợp lệ.", "Thêm thất bại");
                return;
            }

            if (Medicine_BLL.addMedicine(new Medicine_DTO(med_id, med_name)))
            {
                this.med_name = med_name;
                ((Form)this.TopLevelControl).Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại.");
                txtMedName.Focus();
            }
        }
    }
}

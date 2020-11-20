using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.UserControls;
using DTO;

namespace GUI.Forms
{
    public partial class frmAddPrescription: Form
    {
        public List<Prescription_DTO> lstPrescription = new List<Prescription_DTO>();

        public frmAddPrescription()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void addNewPrescription()
        {
            UC_PrescriptionItem u =
                        new UC_PrescriptionItem(this);
            u.Dock = DockStyle.Top;
            pnPrescritionItems.Controls.Add(u);
            pnPrescritionItems.Controls.SetChildIndex(u, pnPrescritionItems.Controls.Count);

            u.BringToFront();
        }
        private void frmAddPrescription_Load(object sender, EventArgs e)
        {
            addNewPrescription();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xóa tất cả các phần thuốc đã liệt kê??", "Xác nhận nhập lại", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                pnPrescritionItems.Controls.Clear();
                addNewPrescription();
            }
        }

        private void btnThem_Click(object sender,
            EventArgs e)
        {
            UC_PrescriptionItem p = (UC_PrescriptionItem) pnPrescritionItems.Controls[0];

            // Xử lý chuyển đơn thuốc sang mã thuốc, tạo mã thuốc mới nếu cần

            Console.WriteLine("Tên thuốc [0]: "+ p.getNameMedicine());
        }
    }
}

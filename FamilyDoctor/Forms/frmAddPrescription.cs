﻿using System;
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
using BLL;

namespace GUI.Forms
{
    public partial class frmAddPrescription: Form
    {
        //public List<Prescription_DTO> lstPrescription2 = new List<Prescription_DTO>();
        // lstMedicine phải public để các ucitem có thể đọc được điền vào suggest
        public static List<Medicine_DTO> lstMedicine = new List<Medicine_DTO>();
        public static List<Prescription_DTO> lstPrescription = new List<Prescription_DTO>();

        public frmAddPrescription()
        {
            InitializeComponent();
        }
        private void frmAddPrescription_Load(object sender, EventArgs e)
        {
            addNewPrescription();
            lstMedicine = Medicine_BLL.getMedicine();
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
            UC_PrescriptionItem first 
                = (UC_PrescriptionItem) pnPrescritionItems.Controls[0];

            // Xử lý chuyển đơn thuốc sang mã thuốc, tạo mã thuốc mới nếu cần
            Console.WriteLine("Tên thuốc [0]: "+ first.getNameMedicine());
            
            if (first.getNameMedicine() != "")
            {
                foreach(UC_PrescriptionItem u in pnPrescritionItems.Controls)
                {
                    //u.getValue();
                }
            }
            else
            {
                MessageBox.Show("Chưa thêm tên thuốc và hướng dẫn sử dụng.", "Thêm thất bại");
            }

            
            foreach(UC_PrescriptionItem u in pnPrescritionItems.Controls)
            {
                //if (u.isUcValid())
                //{
                //    lstResult.Add(u.getValue(1234,getMedIdByName());
                //}
            }


        }
        /// <summary>
        /// Tìm kiếm mã thuốc thông qua tên thuốc
        /// </summary>
        /// <param name="med_name">Tên thuốc</param>
        /// <returns></returns>
        private string getMedIdByName(string med_name)
        {
            foreach(Medicine_DTO m in lstMedicine)
                if(m.Med_name == med_name)
                    return m.Med_id;
            return "";
        }
    }
}

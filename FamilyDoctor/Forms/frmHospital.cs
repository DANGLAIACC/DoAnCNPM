using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using GUI.Reports;

namespace GUI.Forms
{
    public partial class frmHospital : Form
    {
        public frmHospital()
        {
            InitializeComponent();
        } 

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if(txtBieuHien.Text.Trim()=="" || txtChanDoan.Text.Trim() == "" || txtLyDo.Text.Trim() == "" || txtThuocDangDung.Text.Trim() == "")
            {
                frmAlert f = new frmAlert();
                f.showAlert("Các trường không được trống", frmAlert.enmType.Error);

                return;
            }


            frmReportGioiThieuNhapVien f2 = new frmReportGioiThieuNhapVien("ngày 29 tháng 12 năm 2020", "123456", lblHospital.Text, "Nguyễn Thị Chung", "36", "Phù Mỹ, Bình Định", "Nữ", "Đau đầu, ho, sốt", "Rối loạn tiền đình", "Không", "Thích nên cho chuyển đi", "23:41:00 29/11/2020", "Bác sĩ CKII. ĐẶNG QUỐC LAI");
            f2.ShowDialog();
            
        }

        private void frmHospital_Load(object sender, EventArgs e)
        {

        }
    }
}

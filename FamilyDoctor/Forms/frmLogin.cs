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
using GUI.Forms;
using DTO;
using BLL;

namespace FamilyDoctor.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //using (Form_Dashboard fd = new Form_Dashboard())
            //{
            //    fd.ShowDialog();
            //}

            string usr, pwd;
            usr = txtUsername.Text.Trim();
            pwd = txtPassword.Text.Trim();

            if(usr=="" || pwd == "")
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống", "Đăng nhập thất bại");
                txtUsername.SelectAll();
                txtPassword.SelectAll();
                txtUsername.Focus();
            }
            else
            {
                Doctor_DTO d = Doctor_BLL.getLogin(usr, pwd);
                if (d != null)
                {
                    GlobalVariable.curentDoctor = d;

                    frmMain f = new frmMain();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Đăng nhập thất bại");

                    txtUsername.SelectAll();
                    txtPassword.SelectAll();
                    txtUsername.Focus();
                }
            }

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }

    }
}

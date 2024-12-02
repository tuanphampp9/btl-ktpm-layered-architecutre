using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using BTL_QLNhaTro.Models;
using BTL_QLNhaTro.BusinessLogic;
namespace BTL_QLNhaTro
{
    public partial class frmDangKy : Form
    {
        private readonly UserBLL _userBLL;

        public frmDangKy()
        {
            _userBLL = new UserBLL(ConfigurationManager.ConnectionStrings["db_QLNhaTro"].ConnectionString);
            InitializeComponent();
            rdoMale.Checked = true;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();

            if (!_userBLL.IsEmailValid(username) && !_userBLL.IsPhoneValid(username))
            {
                MessageBox.Show("Email/SĐT không hợp lệ");
                return;
            }

            if (_userBLL.IsEmailValid(username) && _userBLL.CheckIfEmailExists(username))
            {
                MessageBox.Show("Email này đã được đăng kí rồi!");
                return;
            }

            if (_userBLL.IsPhoneValid(username) && _userBLL.CheckIfPhoneExists(username))
            {
                MessageBox.Show("Số điện thoại này đã được đăng kí rồi!");
                return;
            }

            User newUser = new User
            {
                FullName = txtFullName.Text,
                Gender = rdoMale.Checked ? 1 : 0,
                DateOfBirth = dtpDOB.Value,
                Email = _userBLL.IsEmailValid(username) ? username : "",
                Phone = _userBLL.IsPhoneValid(username) ? username : "",
                Password = txtPassword.Text,
                Role = 1
            };

            bool isRegistered = _userBLL.RegisterUser(newUser);

            if (isRegistered)
            {
                MessageBox.Show("Đăng ký thành công");
                frmDangNhap formLogin = new frmDangNhap();
                this.Visible = false;
                formLogin.Show();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại. Vui lòng thử lại.");
            }
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangNhap formLogin = new frmDangNhap();
            this.Visible = false;
            formLogin.ShowDialog();
            this.Close();
        }

        private void txtFullName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                e.Cancel = true;
                errorProviderSignUp.SetError(txtFullName, "Họ và tên không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProviderSignUp.SetError(txtFullName, null);
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                e.Cancel = true;
                errorProviderSignUp.SetError(txtUsername, "Tên đăng nhập không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProviderSignUp.SetError(txtUsername, null);
            }
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                errorProviderSignUp.SetError(txtPassword, "Bạn chưa nhập mật khẩu!");
            }
            else
            {
                e.Cancel = false;
                errorProviderSignUp.SetError(txtPassword, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                e.Cancel = true;
                errorProviderSignUp.SetError(txtConfirmPassword, "Xác nhận mật khẩu chưa được nhập!");
            }
            else if (txtConfirmPassword.Text != txtPassword.Text)
            {
                e.Cancel = true;
                errorProviderSignUp.SetError(txtConfirmPassword, "Mật khẩu xác nhận không khớp");
            }
            else
            {
                e.Cancel = false;
                errorProviderSignUp.SetError(txtConfirmPassword, null);
            }
        }
    }
}

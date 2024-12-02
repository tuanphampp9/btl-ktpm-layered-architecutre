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
using BTL_QLNhaTro.Models;
using BTL_QLNhaTro.BusinessLogic;
namespace BTL_QLNhaTro
{
    public partial class frmDangNhap : Form
    {
        private readonly UserBLL _userBLL;
        public frmDangNhap()
        {
            _userBLL = new UserBLL(ConfigurationManager.ConnectionStrings["db_QLNhaTro"].ConnectionString);
            InitializeComponent();
        }
        string constr = ConfigurationManager.ConnectionStrings["db_QLNhaTro"].ConnectionString;

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangKy formSingUp = new frmDangKy();
            this.Visible = false;
            formSingUp.ShowDialog();
        }
        private bool checkNullInput()
        {
            if (txtUserName.Text == "")
            {
                errorProviderCheckLogin.SetError(txtUserName, "Bạn chưa nhập tên đăng nhập");
                txtUserName.Focus();
                return false;
            }
            errorProviderCheckLogin.SetError(txtUserName, null);
            if (txtPassword.Text == "")
            {
                errorProviderCheckLogin.SetError(txtPassword, "Bạn chưa nhập mật khẩu");
                txtPassword.Focus();
                return false;
            }
            errorProviderCheckLogin.SetError(txtPassword, null);
            return true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (checkNullInput())
            {
                // Sử dụng UserService để xác thực
                User user = _userBLL.ValidateLogin(txtUserName.Text, txtPassword.Text);

                if (user != null)
                {
                    frmHome formHome = new frmHome(user.UserName, user.UserId, user.Role);
                    this.Visible = false;
                    formHome.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
                }
            }
        }
    }
}

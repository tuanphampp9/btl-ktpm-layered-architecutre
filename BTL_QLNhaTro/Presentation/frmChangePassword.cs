using BTL_QLNhaTro.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLNhaTro
{
    public partial class frmChangePassword : Form
    {
        private readonly UserBLL _userBLL;
        public int UserId { get; set; }

        public frmChangePassword(int userId)
        {
            UserId = userId;
            _userBLL = new UserBLL(ConfigurationManager.ConnectionStrings["db_QLNhaTro"].ConnectionString);
            InitializeComponent();
        }

        private void txtOldPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtOldPassword.Text))
            {
                e.Cancel = true;
                errorProviderChangePassword.SetError(txtOldPassword, "Bạn chưa nhập mật khẩu cũ!");
            }
            else
            {
                e.Cancel = false;
                errorProviderChangePassword.SetError(txtOldPassword, null);
            }
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                e.Cancel = true;
                errorProviderChangePassword.SetError(txtNewPassword, "Bạn chưa nhập mật khẩu mới!");
            }
            else
            {
                e.Cancel = false;
                errorProviderChangePassword.SetError(txtNewPassword, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                e.Cancel = true;
                errorProviderChangePassword.SetError(txtConfirmPassword, "Bạn chưa nhập mật khẩu xác nhận mật khẩu mới!");
            }
            else
            {
                e.Cancel = false;
                errorProviderChangePassword.SetError(txtConfirmPassword, null);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string oldPassword = txtOldPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!");
                return;
            }

            if (_userBLL.ChangePassword(UserId, oldPassword, newPassword))
            {
                MessageBox.Show("Cập nhật mật khẩu thành công!");
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng hoặc cập nhật không thành công!");
            }
        }
    }
}

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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLNhaTro
{
    public partial class frmThemKH : Form
    {

        string constr = ConfigurationManager.ConnectionStrings["db_QLNhaTro"].ConnectionString;
        private readonly UserBLL _userBLL;
        private int maPhong;
        private string Password;

        public frmThemKH(int maPhong)
        {
            _userBLL = new UserBLL(ConfigurationManager.ConnectionStrings["db_QLNhaTro"].ConnectionString);
            InitializeComponent();
            this.maPhong = maPhong;
            this.Password = "MaPhong" + maPhong;
        }

        private bool IsValidEmail(string input)
        {
            // Regular expression for email validation
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(input, pattern);
        }
        private bool IsValidPhoneNumber(string input)
        {
            // Regular expression for phone number validation
            string pattern = @"^\d{10}$"; // Assuming 10 digits for a phone number
            return Regex.IsMatch(input, pattern);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (!IsValidEmail(txtUsername.Text) && !IsValidPhoneNumber(txtUsername.Text))
            {
                MessageBox.Show("Email/SĐT không hợp lệ");
                return;
            }
            else if (IsValidEmail(txtUsername.Text) && _userBLL.CheckIfEmailExists(txtUsername.Text))
            {
                MessageBox.Show("Email này đã được đăng kí rồi!");
                return;
            }
            else if (IsValidPhoneNumber(txtUsername.Text) && _userBLL.CheckIfPhoneExists(txtUsername.Text))
            {
                MessageBox.Show("Số điện thoại này đã được đăng kí rồi!");
                return;
            }
            
            int i = _userBLL.addCustomer(txtFullName.Text, rdoMale.Checked ? 1 : 0, dtpDOB.Value.ToString(), IsValidEmail(txtUsername.Text) ? txtUsername.Text : "", IsValidPhoneNumber(txtUsername.Text) ? txtUsername.Text : "", this.Password, this.maPhong);
            if (i > 0)
            {
                MessageBox.Show("Thêm thành công");
                frmChiTietPhong formCT = new frmChiTietPhong(this.maPhong);
                this.Visible = false;
                formCT.Show();
            }
        }
    }
}

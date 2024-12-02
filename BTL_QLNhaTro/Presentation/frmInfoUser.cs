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
    public partial class frmInfoUser : Form
    {
        private readonly UserBLL _userBLL;
        string constr = ConfigurationManager.ConnectionStrings["db_QLNhaTro"].ConnectionString;
        clXuLyData commonFunction = new clXuLyData();
        public int userId;
        public int role;
        public string userName;
        public frmInfoUser(int userId,string userName, int role)
        {
            this.userId = userId;
            this.role = role;
            this.userName = userName;
            _userBLL = new UserBLL(ConfigurationManager.ConnectionStrings["db_QLNhaTro"].ConnectionString);
            InitializeComponent();
        }

        private void frmInfoUser_Load(object sender, EventArgs e)
        {
            if(this.role==1)
            {
                string sqlQuery = _userBLL.queryGetInfoUserBuildingOwner(this.userId);
                handleGetInfo(sqlQuery);
            }else if(this.role==0)
            {
                string sqlQuery = _userBLL.queryGetInfoUserCustomer(this.userId);
                handleGetInfo(sqlQuery);
            }
            
        }
        public void handleGetInfo(string sqlQuery)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    DataTable dt = commonFunction.Lay_DataTable(sqlQuery, "tblInfoUser");
                    DataRow row = dt.Rows[0];
                    txtEmail.Text = row[1].ToString().Trim();
                    txtFullName.Text = row[3].ToString().Trim();
                    txtPhoneNumber.Text = row[2].ToString().Trim();
                    dtpDOB.Value = DateTime.Parse(row[4].ToString().Trim());
                    string gender = row[5].ToString().Trim();
                    //disabled
                    handleDisabledInput(this.userName, row[1].ToString().Trim(), row[2].ToString().Trim());
                    if (gender == "True")
                    {
                        rdoMale.Checked = true;
                        rdoFemale.Checked = false;
                    }
                    else
                    {
                        rdoFemale.Checked = true;
                        rdoMale.Checked = false;
                    }
                }
            }
        }

        private void handleDisabledInput(string userName, string email, string phoneNumber)
        {
            if (userName == email)
            {
                txtEmail.Enabled=false;
            }
            else if(userName==phoneNumber)
            {
                txtPhoneNumber.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string roleUpdate = this.role == 1 ? "tblChuToa" : "tblKhachHang";
            int genderUpdate = rdoMale.Checked ? 1 : 0;
            _userBLL.updateInfoUser(roleUpdate, txtEmail.Text, txtPhoneNumber.Text, txtFullName.Text, dtpDOB.Value.ToString("yyyy-MM-dd"), genderUpdate, this.userId);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword(this.userId);
            this.Visible = false;
            frmChangePassword.ShowDialog();
        }
    }
}

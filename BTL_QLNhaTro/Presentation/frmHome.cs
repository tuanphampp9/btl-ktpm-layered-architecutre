using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLNhaTro
{
    public partial class frmHome : Form
    {
        private string userName;
        private int role;
        private int userId;
        public frmHome(string user_name,int userId, int role)
        {
            this.userName = user_name;
            this.role = role;
            this.userId = userId;
            this.role = role;
            InitializeComponent();
            datSubMenu();
            lbFullName.Text = "Tên: " + userName;
        }

        // Thiết lập menu
        private void datSubMenu()
        {
            if(this.role==0)
            {
                pnToaNha.Visible = false;
            }
        }

        private void anSubMenu()
        {
           
        }

        private void hienSubMenu(Panel sulPanel)
        {
            if(sulPanel.Visible == false)
            {
                anSubMenu();
                sulPanel.Visible = true;
            }
            else
                sulPanel.Visible= false;
        }

        private Form activeForm;
        private void moChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            pnChildFrom.Controls.Clear();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnChildFrom.Controls.Add(childForm);
            pnChildFrom.Tag = childForm;
            childForm.Show();
        }
        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }         
        }


        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap formLogin = new frmDangNhap();
            this.Visible = false;
            formLogin.ShowDialog();
            this.Close();
        }

        private void btnToaNha_Click(object sender, EventArgs e)
        {
            this.Width = 1000;
            this.Height = 540;
            frmToaNha nhap = new frmToaNha(this.userId);
            moChildForm(nhap);
            anSubMenu();
        }

        private void btnDetailAccount_Click(object sender, EventArgs e)
        {
            this.Width = 1000;
            this.Height = 540;
            frmInfoUser nhap = new frmInfoUser(this.userId, this.userName, this.role);
            moChildForm(nhap);
            anSubMenu();
        }

        private void btnTaiSan_Click(object sender, EventArgs e)
        {
            this.Width = 1000;
            this.Height = 540;
            frmTaiSan nhap = new frmTaiSan(this.userId, this.role);
            moChildForm(nhap);
            anSubMenu();
        }

        private void btnPhongThue_Click(object sender, EventArgs e)
        {
            this.Width = 1000;
            this.Height = 540;
            if(role == 1)
            {
                frmQLPhong frmQLPhong = new frmQLPhong(this.userId);
                moChildForm(frmQLPhong);
                anSubMenu();
            }
            else
            {
                clXuLyData xuLyData = new clXuLyData();
                string sqlText = $"SELECT * FROM tblPhong WHERE FK_User_id= {userId}";
                DataTable dataTable = xuLyData.Lay_DataTable(sqlText, "tblPhong");
                DataRow row = dataTable.Rows[0];
                frmChiTietPhong frmChiTietPhong = new frmChiTietPhong(int.Parse(row[0].ToString()));
                moChildForm(frmChiTietPhong);
                anSubMenu();
            }
            
        }
    }
}

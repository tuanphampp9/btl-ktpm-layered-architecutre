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
    public partial class frmTaiSan : Form
    {
        public int userId;
        private int role;
        int vitri = -1;
        int maTaiSan;
        private readonly AssetBLL _assetBLL;

        public frmTaiSan(int user_id, int role)
        {
            this.userId = user_id;
            this.role = role;
            _assetBLL = new AssetBLL(ConfigurationManager.ConnectionStrings["db_QLNhaTro"].ConnectionString);
            InitializeComponent();
            if (role == 0)
            {
                txtTenTaiSan.Enabled = false;
                txtSoLuong.Enabled = false;
                txtViTri.Enabled = false;
                cbPhong.Enabled = false;
                cbToaNha.Enabled = false;
                btnThem.Visible = false;
            }
        }

        string constr = ConfigurationManager.ConnectionStrings["db_QLNhaTro"].ConnectionString;

        readonly clXuLyData commonFunction = new clXuLyData();
        private void loadDatagridview()
        {
            string sqlQuery = this.role == 1 ? $"select PK_MaTaiSan ,sTenTaiSan, iSoLuong, sTinhTrang, sViTri, sTenToa, sTenPhong from DS_TaiSan" : $"select PK_MaTaiSan ,sTenTaiSan, iSoLuong, sTinhTrang, sViTri, sTenToa, sTenPhong from DS_TaiSan where FK_User_Id_KH={this.userId}";
            DataTable dt = commonFunction.Lay_DataTable(sqlQuery, "DS_TaiSan");
            dtgvTaiSan.DataSource = dt;
            dtgvTaiSan.Refresh();
        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void lbBuildingName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDatagridview();
            if (this.role == 1)
            {
                commonFunction.loadCbb(commonFunction.Lay_DataTable($"SELECT * FROM tblToaNha WHERE FK_User_id = {this.userId}", "tblToaNha"), cbToaNha);
                commonFunction.loadCbb(commonFunction.Lay_DataTable($"SELECT PK_MaPhong, sTenPhong FROM tblPhong WHERE FK_MaToa = {cbToaNha.GetItemText(cbToaNha.SelectedValue)}", "tblPhong"), cbPhong);
            }

        }


        private void cbToaNha_SelectionChangeCommitted(object sender, EventArgs e)
        {
            commonFunction.loadCbb(commonFunction.Lay_DataTable($"SELECT PK_MaPhong, sTenPhong FROM tblPhong WHERE FK_MaToa = {cbToaNha.GetItemText(cbToaNha.SelectedValue)}", "tblPhong"), cbPhong);
        }

        public void r_form()
        {
            txtTenTaiSan.Text = "";
            txtTinhTrang.Text = "";
            txtSoLuong.Text = "";
            txtViTri.Text = "";
            cbPhong.DataSource=null;
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            r_form();
            loadDatagridview();
        }

        public int ThemTaiSan(string sTenTaiSan, string sTinhTrang, int iSoLuong, string sVitri, int FK_MaToa, int FK_MaPhong)
        {
            return _assetBLL.AddAsset(sTenTaiSan, sTinhTrang, iSoLuong, sVitri, FK_MaToa, FK_MaPhong);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (
                txtTenTaiSan.Text == "" ||
                txtTinhTrang.Text == ""||
                txtSoLuong.Text == ""||
                txtViTri.Text == ""
                )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tên toà nhà và địa chỉ để thêm");
            }
            else
            {
                string buildingName = txtTenTaiSan.Text.ToString().Trim();
                string address = txtTinhTrang.Text.ToString().Trim();
                int kq = ThemTaiSan(txtTenTaiSan.Text, txtTinhTrang.Text, int.Parse(txtSoLuong.Text), txtViTri.Text, int.Parse(cbToaNha.GetItemText(cbToaNha.SelectedValue)), int.Parse(cbToaNha.GetItemText(cbPhong.SelectedValue)));
                if (kq > 0)
                {
                    loadDatagridview();
                    r_form();
                }
                else
                {
                    MessageBox.Show("Them khong thanh cong!");
                }
            }

        }

        public int SuaTaiSan(string sTenTaiSan, string sTinhTrang, int iSoLuong, string sVitri, int FK_MaToa, int FK_MaPhong)
        {
            return _assetBLL.UpdateAsset(sTenTaiSan, sTinhTrang, iSoLuong, sVitri, FK_MaToa, FK_MaPhong);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (
               txtTenTaiSan.Text == "" ||
               txtTinhTrang.Text == "" ||
               txtSoLuong.Text == "" ||
               txtViTri.Text == ""
               )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tên toà nhà và địa chỉ để thêm");
            }
            else
            {
                string buildingName = txtTenTaiSan.Text.ToString().Trim();
                string address = txtTinhTrang.Text.ToString().Trim();
                int kq = ThemTaiSan(txtTenTaiSan.Text, txtTinhTrang.Text, int.Parse(txtSoLuong.Text), txtViTri.Text, int.Parse(cbToaNha.GetItemText(cbToaNha.SelectedValue)), int.Parse(cbToaNha.GetItemText(cbPhong.SelectedValue)));
                if (kq > 0)
                {
                    loadDatagridview();
                    r_form();
                }
                else
                {
                    MessageBox.Show("Them khong thanh cong!");
                }
            }
        }

        private void txtViTri_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgvTaiSan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
            DataTable dt = commonFunction.Lay_DataTable(this.role == 1 ?
                                                        $"select PK_MaTaiSan ,sTenTaiSan, iSoLuong, sTinhTrang, sViTri, sTenToa, sTenPhong from DS_TaiSan" :
                                                        $"select PK_MaTaiSan ,sTenTaiSan, iSoLuong, sTinhTrang, sViTri, sTenToa, sTenPhong from DS_TaiSan where FK_User_Id_KH={this.userId}",
                                                        "DS_TaiSan");
            DataRow row = dt.Rows[vitri];
            this.maTaiSan = int.Parse(row[0].ToString().Trim());

            txtTenTaiSan.Text = row[1].ToString().Trim();
            txtTinhTrang.Text = row[3].ToString().Trim();
            txtSoLuong.Text = row[2].ToString().Trim();
            txtViTri.Text = row[4].ToString().Trim();
            if (this.role == 1)
            {
                cbToaNha.SelectedIndex = cbToaNha.FindString(row[5].ToString());
                commonFunction.loadCbb(commonFunction.Lay_DataTable($"SELECT PK_MaPhong, sTenPhong FROM tblPhong WHERE FK_MaToa = {cbToaNha.GetItemText(cbToaNha.SelectedValue)}", "tblPhong"), cbPhong);
            }
            if (row[6].ToString() == "")
            {
                cbPhong.DataSource = null;
            }
            else
            {
                cbPhong.SelectedIndex = cbPhong.FindString(row[6].ToString());
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sqlCommand = "";
            if (txtTenTaiSan.Text.ToString().Trim().Length != 0)
            {
                sqlCommand = _assetBLL.buildQuerySearchAsset(this.role, txtTenTaiSan.Text.ToString().Trim(), this.userId);                                 
            }
            dtgvTaiSan.DataSource = commonFunction.Lay_DataTable(sqlCommand, "tblToaNha");
        }
    }
}

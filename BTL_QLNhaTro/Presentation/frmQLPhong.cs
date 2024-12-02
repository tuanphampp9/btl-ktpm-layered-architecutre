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
    public partial class frmQLPhong : Form
    {
        clXuLyData xuLyData = new clXuLyData();
        private readonly RoomDetailBLL _roomDetailBLL;
        private string constr = ConfigurationManager.ConnectionStrings["db_QLNhaTro"].ConnectionString;
        private int viTriChon = -1;
        public int userId = 1;
        string sqlCommand = "SELECT * FROM vv_Phong WHERE FK_User_id='";
        public frmQLPhong(int user_id)
        {
            _roomDetailBLL = new RoomDetailBLL(ConfigurationManager.ConnectionStrings["db_QLNhaTro"].ConnectionString);
            InitializeComponent();
            this.userId = user_id;
        }
        private void frmQLPhong_Load(object sender, EventArgs e)
        {
            sqlCommand = sqlCommand + this.userId + "' ";

            //Gắn dữ liệu cho dataView
            dgvPhong.DataSource = xuLyData.Lay_DataTable(sqlCommand,"vv_Phong");

            //Gắn dữ liệu cho cbxToaNha
            DataTable dataTable = xuLyData.Lay_DataTable($"SELECT * FROM tblToaNha WHERE FK_User_id={this.userId}", "tbltblToaNha");
            xuLyData.loadCbb(dataTable,cbxToaNha, "sTenToa", "PK_MaToa");
            cbxToaNha.Text = "";
        }
                
        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            viTriChon = e.RowIndex;
            DataTable dataTable = xuLyData.Lay_DataTable(sqlCommand,"vv_Phong");
            if (viTriChon >= 0)
            {
               
                DataRow dataRow = dataTable.Rows[e.RowIndex];
                txtMaPhong.Text = dataRow[0].ToString();
                txtPhong.Text = dataRow[1].ToString();
                cbxToaNha.Text = dataRow[2].ToString();
                txtTang.Text = dataRow[3].ToString();
                txtTienThue.Text = dataRow[4].ToString();
                txtDienTich.Text = dataRow[5].ToString();
                txtSoNguoi.Text = dataRow[6].ToString();
                cbxTinhTrang.Text = dataRow[7].ToString();
            }
           
        }
        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string command = dgvPhong.Columns[e.ColumnIndex].Name;
                if (command == "clChiTiet")
                {
                    viTriChon = e.RowIndex;
                    
                    int maPhong = int.Parse(dgvPhong.Rows[viTriChon].Cells["clMaPhong"].Value.ToString());
                    frmChiTietPhong frmChiTietPhong = new frmChiTietPhong(maPhong);

                    frmChiTietPhong.ShowDialog();
                }
            }
        }
        public int CapNhatPhong()
        {
            return _roomDetailBLL.updateRoom(int.Parse(cbxToaNha.SelectedValue.ToString()), txtPhong.Text, txtTang.Text, txtTienThue.Text, txtDienTich.Text, txtSoNguoi.Text, cbxTinhTrang.Text, txtMaPhong.Text);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (viTriChon < 0)
            {
                MessageBox.Show("Bạn chưa chọn phòng cần sửa!");
                return;
            }
            else
            {
                int kq = CapNhatPhong();
                if (kq > 0)
                {
                    MessageBox.Show("Sửa Thanh cong!");
                    dgvPhong.DataSource = xuLyData.Lay_DataTable(sqlCommand,"vv_Phong");
                }
                else
                {
                    MessageBox.Show("Sửa khong thanh cong!");
                }
                lamMoi();
            }
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lamMoi();
            dgvPhong.DataSource = xuLyData.Lay_DataTable(sqlCommand,"vv_Phong");
        }

        private void lamMoi()
        {
            txtMaPhong.Text = "";
            cbxToaNha.Text = "";
            txtPhong.Text = "";
            txtTang.Text = "";
            txtTienThue.Text = "";
            txtDienTich.Text = "";
            txtSoNguoi.Text = "";
            cbxTinhTrang.Text = "";
            viTriChon = -1;
            eprQLPhong.Clear();
        }
        private int ThemPhong(string maToa,string tenPhong, string tang, string tienThu, string dienTich, string soNguoiTD, string tinhTrang)
        {
            return _roomDetailBLL.addRoom(maToa, tenPhong, tang, tienThu, dienTich, soNguoiTD, tinhTrang);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maToa = cbxToaNha.SelectedValue.ToString().Trim();
            string tenPhong= txtPhong.Text.ToString().Trim();
            string tang = txtTang.Text.ToString().Trim();
            string tienThu = txtTienThue.Text.ToString().Trim();
            string dienTich = txtDienTich.Text.ToString().Trim();
            string soNguoiTD = txtSoNguoi.Text.ToString().Trim();
            string tinhTrang = cbxTinhTrang.Text.ToString();
            
            if(maToa == "" || tenPhong == "" || tang == "" || dienTich == "" || tienThu == "" || soNguoiTD == "" || tinhTrang == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để thêm");
            }
            else
            {
                int kq = ThemPhong(maToa,tenPhong,tang,tienThu,dienTich,soNguoiTD,tinhTrang);
                if (kq > 0)
                {
                    dgvPhong.DataSource = xuLyData.Lay_DataTable(sqlCommand,"vv_Phong");
                    lamMoi();
                }
                else
                {
                    MessageBox.Show("Them khong thanh cong!");
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {            
            string tenPhong = txtPhong.Text.ToString().Trim();
            string tenToa = cbxToaNha.Text.ToString().Trim();
            string tang = txtTang.Text.ToString().Trim();
            string tienThu = txtTienThue.Text.ToString().Trim();
            string dienTich = txtDienTich.Text.ToString().Trim();
            string soNguoiTD = txtSoNguoi.Text.ToString().Trim();
            string tinhTrang = cbxTinhTrang.Text.ToString().Trim();
            string sqlText = _roomDetailBLL.buildQuerySearchRoom(tenPhong, tenToa, tang, tienThu, dienTich, tinhTrang, this.userId);
            dgvPhong.DataSource = xuLyData.Lay_DataTable(sqlText, "vv_Phong");
        }

        private void txtDienTich_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(txtDienTich.Text);
                eprQLPhong.SetError(txtDienTich, "");
            }
            catch
            {
                eprQLPhong.SetError(txtDienTich, "Vui Lòng nhập số trong ô này");
                return;
            }
        }

        private void txtTienThue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(txtTienThue.Text);
                eprQLPhong.SetError(txtTienThue, "");
            }
            catch
            {
                eprQLPhong.SetError(txtTienThue, "Vui Lòng nhập số trong ô này");
                return;
            }
        }

        private void txtTang_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtTang.Text);
                eprQLPhong.SetError(txtTang, "");
            }
            catch
            {
                eprQLPhong.SetError(txtTang, "Vui Lòng nhập số trong ô này");
                return;
            }
        }

        private void txtSoNguoi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtSoNguoi.Text);
                eprQLPhong.SetError(txtSoNguoi, "");
            }
            catch
            {
                eprQLPhong.SetError(txtSoNguoi, "Vui Lòng nhập số trong ô này");
                return;
            }
        }
    }
}

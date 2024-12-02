using BTL_QLNhaTro.BusinessLogic;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_QLNhaTro
{
    public partial class frmChiTietPhong : Form
    {
        private readonly RoomDetailBLL _phongService;
        private int _maPhong;
        private string _maNguoiT;
        private string _tinhTrang;

        public frmChiTietPhong(int maPhong)
        {
            InitializeComponent();
            _maPhong = maPhong;
            _phongService = new RoomDetailBLL(ConfigurationManager.ConnectionStrings["db_QLNhaTro"].ConnectionString);
        }

        private void frmCTHB_Ban_Load(object sender, EventArgs e)
        {
            LoadPhongDetails();
            LoadTaiSan();
        }

        private void LoadPhongDetails()
        {
            var phongData = _phongService.GetPhongDetails(_maPhong);
            if (phongData.Rows.Count > 0)
            {
                var dataRow = phongData.Rows[0];
                txtPhong.Text = dataRow["sTenPhong"].ToString();
                txtTang.Text = dataRow["iTang"].ToString();
                txtTienThue.Text = dataRow["fTienThu"].ToString();
                txtDienTich.Text = dataRow["fDienTich"].ToString();
                txtSoNguoi.Text = dataRow["iSoNguoiToiDa"].ToString();
                txtTinhTrang.Text = dataRow["sTinhTrang"].ToString();

                _maNguoiT = dataRow["FK_User_id"].ToString();
                _tinhTrang = dataRow["sTinhTrang"].ToString().Trim();
                btnThemKH.Text = _tinhTrang == "Đã thuê" ? "Xóa khách hàng" : "Thêm khách hàng";
            }
        }

        private void LoadTaiSan()
        {
            dgvTaiSanPhong.DataSource = _phongService.GetTaiSanByPhong(_maPhong);
        }

        private void btnTaiSan_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            dgvTaiSanPhong.DataSource = _phongService.GetTaiSanByPhong(_maPhong);
        }

        private void btnNguoiThue_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(_maNguoiT))
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                dgvNguoiThue.DataSource = _phongService.GetKhachHangDetails(_maNguoiT);
            }
            else
            {
                MessageBox.Show("Phòng chưa có ai thuê.");
            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (_tinhTrang == "Đã thuê")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng khỏi phòng trọ?", "Xác nhận xóa", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (_phongService.RemoveKhachHangFromPhong(_maPhong))
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadPhongDetails();
                        LoadTaiSan();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công. Vui lòng thử lại.");
                    }
                }
            }
            else
            {
                frmThemKH formThemKH = new frmThemKH(_maPhong);
                formThemKH.Show();
            }
        }
    }
}

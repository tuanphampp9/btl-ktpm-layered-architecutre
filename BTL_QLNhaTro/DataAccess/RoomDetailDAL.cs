using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml;

namespace BTL_QLNhaTro.DataAccess
{
    internal class RoomDetailDAL
    {
        private readonly string _connectionString;

        public RoomDetailDAL(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable GetTaiSanByPhong(int maPhong)
        {
            string query = "SELECT sTenTaiSan, iSoLuong, sTinhTrang, sViTri FROM tblTaiSan WHERE FK_MaPhong = @MaPhong";
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaPhong", maPhong);
                using (var adapter = new SqlDataAdapter(command))
                {
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public DataTable GetPhongById(int maPhong)
        {
            string query = "SELECT * FROM tblPhong WHERE PK_MaPhong = @MaPhong";
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaPhong", maPhong);
                using (var adapter = new SqlDataAdapter(command))
                {
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public DataTable GetKhachHangById(string maNguoiT)
        {
            string query = "SELECT * FROM tblKhachHang WHERE PK_Id = @MaNguoiT";
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaNguoiT", maNguoiT);
                using (var adapter = new SqlDataAdapter(command))
                {
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public bool XoaKhachHangKhoiPhong(int maPhong)
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("prc_xoaKH_Phong", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@maPhong", maPhong);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public int updateRoom(int buildingId, string nameRoom, string numberFloor, string amount, string area,string numberPeople, string status, string roomId)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    string sqlUpdate = "UPDATE tblPhong" +
                                       " SET FK_MaToa='" + buildingId + "', sTenPhong='" + nameRoom + "', iTang=" + numberFloor + " , fTienThu=" + amount + ", fDienTich=" + area + ", iSoNguoiToiDa=" + numberPeople + ", sTinhTrang='" + status + "'" +
                                       " WHERE PK_MaPhong='" + roomId + "'";
                    cmd.CommandText = sqlUpdate;
                    conn.Open();
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    return i;
                }
            }
        }
        
        public int addRoom(string maToa, string tenPhong, string tang, string tienThu, string dienTich, string soNguoiTD, string tinhTrang)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    string sqlInsert = $"INSERT INTO tblPhong(FK_MaToa,sTenPhong,iTang,fTienThu,fDienTich,iSoNguoiToiDa,sTinhTrang) values({maToa},N'{tenPhong}',{tang}, {tienThu}, {dienTich}, {soNguoiTD}, N'{tinhTrang}')";
                    cmd.CommandText = sqlInsert;
                    conn.Open();
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    return i;
                }
            }
        }

        public string buildQuerySearchRoom(string tenPhong, string tenToa, string tang, string tienThu, string dienTich, string tinhTrang, int userId)
        {
            string sqlText = "SELECT * FROM vv_Phong WHERE ";
            if (tenPhong.Length != 0)
            {
                sqlText = sqlText + "sTenPhong LIKE '%" + tenPhong + "%'";
            }
            if (tenToa.Length != 0)
            {
                if (sqlText.Length > 36)
                {
                    sqlText = sqlText + " AND sTenToa LIKE N'%" + tenToa + "%'";
                }
                else
                {
                    sqlText = "SELECT * FROM vv_Phong WHERE sTenToa LIKE N'%" + tenToa + "%'";
                }
            }
            if (tang.Length != 0)
            {
                if (sqlText.Length > 36)
                {
                    sqlText = sqlText + " AND iTang =" + tang;
                }
                else
                {
                    sqlText = "SELECT * FROM vv_Phong WHERE iTang =" + tang;
                }
            }
            if (tienThu.Length != 0)
            {
                if (sqlText.Length > 36)
                {
                    sqlText = sqlText + " AND fTienThu <=" + tienThu;
                }
                else
                {
                    sqlText = "SELECT * FROM vv_Phong WHERE fTienThu <=" + tienThu;
                }
            }
            if (dienTich.Length != 0)
            {
                if (sqlText.Length > 36)
                {
                    sqlText = sqlText + " AND fdienTich <=" + dienTich;
                }
                else
                {
                    sqlText = "SELECT * FROM vv_Phong WHERE fdienTich <=" + dienTich;
                }
            }
            if (tinhTrang.Length != 0)
            {
                if (sqlText.Length > 36)
                {
                    sqlText = sqlText + " AND sTinhTrang =N'" + tinhTrang + "'";
                }
                else
                {
                    sqlText = "SELECT * FROM vv_Phong WHERE sTinhTrang =N'" + tinhTrang + "'";
                }
            }
            if (sqlText.Length > 36)
            {
                sqlText = sqlText + " AND FK_User_id='" + userId + "'";
            }
            else
            {
                sqlText = "SELECT * FROM vv_Phong WHERE FK_User_id='" + userId + "'";
            }
            return sqlText;
        }
    }
}

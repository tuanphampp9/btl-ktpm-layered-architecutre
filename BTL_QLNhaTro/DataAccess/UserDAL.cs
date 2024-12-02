using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTL_QLNhaTro.Models;
using System.Windows.Forms;

namespace BTL_QLNhaTro.DataAccess
{
    internal class UserDAL
    {
        private readonly string _connectionString;

        public UserDAL(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool CheckOldPassword(int userId, string oldPassword)
        {
            using (SqlConnection cnn = new SqlConnection(_connectionString))
            {
                string query = $"SELECT * FROM tblNguoiDung WHERE PK_User_Id = @UserId AND sMatKhau = @OldPassword";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@OldPassword", oldPassword);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable tblNguoiDung = new DataTable();
                    da.Fill(tblNguoiDung);

                    return tblNguoiDung.Rows.Count > 0;
                }
            }
        }

        public string getInfoUserBuildingOwner(int userId)
        {
            return $"select tblChuToa.* from tblNguoiDung inner join tblChuToa on tblNguoiDung.PK_User_Id = tblChuToa.PK_Id where PK_Id = {userId}";
        }

        public string getInfoUserCustomer(int userId)
        {
            return $"select tblKhachHang.* from tblNguoiDung inner join tblKhachHang on tblNguoiDung.PK_User_Id = tblKhachHang.PK_Id where PK_Id = {userId}";
        }

        public int UpdatePassword(int userId, string newPassword)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = $"UPDATE tblNguoiDung SET sMatKhau = @NewPassword WHERE PK_User_Id = @UserId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@NewPassword", newPassword);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public void updateInfoUser(string roleUpdate, string email, string phoneNumber, string fullName, string dob, int gender, int userID)
        {
            string sqlUpdate = $"UPDATE {roleUpdate} SET sEmail= '{email}', sSdt='{phoneNumber}', sHoTen = N'{fullName}', dNgaySinh = '{dob}', bGt={gender} WHERE PK_Id = {userID}";
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sqlUpdate;
                    conn.Open();
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (i > 0)
                    {
                        MessageBox.Show("Cập nhật thành công");
                    }
                }
            }
        }

        public bool CheckEmailExists(string email)
        {
            using (SqlConnection cnn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from tblChuToa where sEmail = @Email", cnn);
                da.SelectCommand.Parameters.AddWithValue("@Email", email);
                DataTable tblChuToa = new DataTable();
                da.Fill(tblChuToa);
                return tblChuToa.Rows.Count > 0;
            }
        }

        public bool CheckPhoneExists(string phone)
        {
            using (SqlConnection cnn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from tblChuToa where sSdt = @Phone", cnn);
                da.SelectCommand.Parameters.AddWithValue("@Phone", phone);
                DataTable tblChuToa = new DataTable();
                da.Fill(tblChuToa);
                return tblChuToa.Rows.Count > 0;
            }
        }

        public bool RegisterUser(User user)
        {
            using (SqlConnection cnn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "prc_signUp";
                    cmd.Parameters.AddWithValue("@fullName", user.FullName);
                    cmd.Parameters.AddWithValue("@gender", user.Gender);
                    cmd.Parameters.AddWithValue("@dob", user.DateOfBirth);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@sdt", user.Phone);
                    cmd.Parameters.AddWithValue("@password", user.Password);
                    cmd.Parameters.AddWithValue("@role", user.Role);

                    cnn.Open();
                    int result = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return result > 0;
                }
            }
        }

        public int addCustomer(string fullName, int role, string dob, string email, string phoneNumber, string password, int roomId)
        {
            using (SqlConnection cnn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "prc_themKH";
                    cmd.Parameters.AddWithValue("@fullName", fullName);
                    cmd.Parameters.AddWithValue("@gender", role);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@sdt", phoneNumber);
                    cmd.Parameters.AddWithValue("@password", password);

                    SqlParameter userIdParam = new SqlParameter("@userId", SqlDbType.Int);
                    userIdParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(userIdParam);

                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();

                    int userId = Convert.ToInt32(userIdParam.Value);

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@maPhong", roomId);
                    cmd.CommandText = "prc_themKH_Phong";
                    cmd.CommandType = CommandType.StoredProcedure;
                    i = cmd.ExecuteNonQuery();

                    cnn.Close();
                    return i;
                }
            }
        }

        public User GetUserByUsernameAndPassword(string username, string password)
        {
            User user = null;
            using (SqlConnection cnn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter($"select * from tblNguoiDung where sTenDangNhap='{username}' and sMatKhau='{password}'", cnn);
                DataTable tblNguoiDung = new DataTable();
                da.Fill(tblNguoiDung);

                if (tblNguoiDung.Rows.Count > 0)
                {
                    user = new User
                    {
                        UserId = tblNguoiDung.Rows[0].Field<int>("PK_User_Id"),
                        UserName = tblNguoiDung.Rows[0].Field<string>("sTenDangNhap"),
                        Password = tblNguoiDung.Rows[0].Field<string>("sMatKhau"),
                        Role = tblNguoiDung.Rows[0].Field<int>("iVaiTro")
                    };
                }
            }
            return user;
        }
    }
}

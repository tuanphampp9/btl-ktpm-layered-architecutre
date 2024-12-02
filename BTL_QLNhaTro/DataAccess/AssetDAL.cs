using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLNhaTro.DataAccess
{
    internal class AssetDAL
    {
        private readonly string _connectionString;

        public AssetDAL(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int AddAsset(string sTenTaiSan, string sTinhTrang, int iSoLuong, string sVitri, int FK_MaToa, int FK_MaPhong)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    string sqlInsert = $"insert into tblTaiSan(sTenTaiSan, sTinhTrang, iSoLuong, sViTri, FK_MaToa, FK_MaPhong) values(N'{sTenTaiSan}',N'{sTinhTrang}', {iSoLuong}, N'{sVitri}', {FK_MaToa}, {FK_MaPhong})";
                    cmd.CommandText = sqlInsert;
                    conn.Open();
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    return i;
                }
            }
        }

        public int UpdateAsset(string sTenTaiSan, string sTinhTrang, int iSoLuong, string sVitri, int FK_MaToa, int FK_MaPhong)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    string sqlInsert = $"UPDATE tblTaiSan SET sTenTaiSan=N'{sTenTaiSan}', sTinhTrang=N'{sTinhTrang}', iSoLuong={iSoLuong}, sViTri=N'{sVitri}', FK_MaToa = {FK_MaToa}, FK_MaPhong ={FK_MaPhong}";
                    cmd.CommandText = sqlInsert;
                    conn.Open();
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    return i;
                }
            }
        }
        public string buildQuerySearchAsset(int role, string nameAsset, int userId)
        {
            string sqlCommand = role == 1 ?
                              $"select PK_MaTaiSan ,sTenTaiSan, iSoLuong, sTinhTrang, sViTri, sTenToa, sTenPhong from DS_TaiSan where sTenTaiSan LIKE N'%" + nameAsset + "%'" :
                              $"select PK_MaTaiSan ,sTenTaiSan, iSoLuong, sTinhTrang, sViTri, sTenToa, sTenPhong from DS_TaiSan where FK_User_Id_KH={userId} and sTenTaiSan LIKE N'%" + nameAsset + "%'";
            return sqlCommand;
        }
    }
}

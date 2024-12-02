using BTL_QLNhaTro.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLNhaTro.DataAccess
{
    internal class BuildingDAL
    {
        private string constr = ConfigurationManager.ConnectionStrings["db_QLNhaTro"].ConnectionString;

        public DataTable GetBuildingsByUserId(int userId)
        {
            string query = $"SELECT PK_MaToa, sTenToa, sDiaChi FROM tblToaNha WHERE FK_User_id = {userId}";
            using (SqlConnection conn = new SqlConnection(constr))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetBuildingsByUserIdAndNameBuilding(int userId, string buildingName)
        {
            string sqlCommand = $"select PK_MaToa, sTenToa, sDiaChi from tblToaNha where FK_User_id='{userId}' and sTenToa LIKE N'%{buildingName}%'";
            using (SqlConnection conn = new SqlConnection(constr))
            using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public int AddBuilding(Building building)
        {
            string query = $"INSERT INTO tblToaNha (sTenToa, sDiaChi, FK_User_id) VALUES (@Name, @Address, @UserId)";
            using (SqlConnection conn = new SqlConnection(constr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Name", building.Name);
                cmd.Parameters.AddWithValue("@Address", building.Address);
                cmd.Parameters.AddWithValue("@UserId", building.UserId);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public int UpdateBuilding(Building building)
        {
            string query = $"UPDATE tblToaNha SET sTenToa = @Name, sDiaChi = @Address WHERE PK_MaToa = @Id";
            using (SqlConnection conn = new SqlConnection(constr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Name", building.Name);
                cmd.Parameters.AddWithValue("@Address", building.Address);
                cmd.Parameters.AddWithValue("@Id", building.Id);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}

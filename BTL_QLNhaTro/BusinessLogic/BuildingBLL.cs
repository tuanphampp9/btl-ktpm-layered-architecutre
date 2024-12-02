using BTL_QLNhaTro.DataAccess;
using BTL_QLNhaTro.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLNhaTro.BusinessLogic
{
    internal class BuildingBLL
    {
        private BuildingDAL dal = new BuildingDAL();

        public DataTable GetBuildingsByUserId(int userId)
        {
            return dal.GetBuildingsByUserId(userId);
        }

        public DataTable GetBuildingsByUserIdAndNameBuilding(int userId, string buildingName)
        {
            return dal.GetBuildingsByUserIdAndNameBuilding(userId, buildingName);
        }

        public bool AddBuilding(string name, string address, int userId)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address))
                return false;

            Building building = new Building
            {
                Name = name,
                Address = address,
                UserId = userId
            };
            return dal.AddBuilding(building) > 0;
        }

        public bool UpdateBuilding(int id, string name, string address)
        {
            if (id <= 0 || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address))
                return false;

            Building building = new Building
            {
                Id = id,
                Name = name,
                Address = address
            };
            return dal.UpdateBuilding(building) > 0;
        }
    }
}

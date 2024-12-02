using BTL_QLNhaTro.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLNhaTro.BusinessLogic
{
    internal class AssetBLL
    {
        private readonly AssetDAL _repository;

        public AssetBLL(string connectionString)
        {
            _repository = new AssetDAL(connectionString);
        }
        public int AddAsset(string sTenTaiSan, string sTinhTrang, int iSoLuong, string sVitri, int FK_MaToa, int FK_MaPhong) => _repository.AddAsset(sTenTaiSan, sTinhTrang, iSoLuong, sVitri, FK_MaToa, FK_MaPhong);
        public int UpdateAsset(string sTenTaiSan, string sTinhTrang, int iSoLuong, string sVitri, int FK_MaToa, int FK_MaPhong) => _repository.UpdateAsset(sTenTaiSan, sTinhTrang, iSoLuong, sVitri, FK_MaToa, FK_MaPhong);
        public string buildQuerySearchAsset(int role, string nameAsset, int userId) => _repository.buildQuerySearchAsset(role, nameAsset, userId);
    }
}

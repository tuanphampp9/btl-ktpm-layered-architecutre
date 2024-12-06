using BTL_QLNhaTro.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLNhaTro.BusinessLogic
{
    internal class RoomDetailBLL
    {
        private readonly RoomDetailDAL _repository;

        public RoomDetailBLL(string connectionString)
        {
            _repository = new RoomDetailDAL(connectionString);
        }

        public DataTable GetTaiSanByPhong(int maPhong) => _repository.GetTaiSanByPhong(maPhong);

        public DataTable GetPhongDetails(int maPhong) => _repository.GetPhongById(maPhong);

        public DataTable GetKhachHangDetails(string maNguoiT) => _repository.GetKhachHangById(maNguoiT);

        public bool RemoveKhachHangFromPhong(int maPhong) => _repository.XoaKhachHangKhoiPhong(maPhong);

        public int updateRoom(int buildingId, string nameRoom, string numberFloor, string amount, string area, string numberPeople, string status, string roomId) => _repository.updateRoom(buildingId, nameRoom, numberFloor, amount, area, numberPeople, status, roomId);

        public int addRoom(string maToa, string tenPhong, string tang, string tienThu, string dienTich, string soNguoiTD, string tinhTrang) => _repository.addRoom(maToa, tenPhong, tang, tienThu, dienTich, soNguoiTD, tinhTrang);

        public int DeleteRoom(int buildingId, string roomId) => _repository.DeleteRoom(buildingId, roomId);

        public string buildQuerySearchRoom(string tenPhong, string tenToa, string tang, string tienThu, string dienTich, string tinhTrang, int userId) => _repository.buildQuerySearchRoom(tenPhong, tenToa, tang, tienThu, dienTich, tinhTrang, userId);
    }
}

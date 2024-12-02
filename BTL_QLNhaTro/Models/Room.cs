using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLNhaTro.Models
{
    internal class Room
    {
        // Mã phòng (Unique identifier for the room)
        public int RoomId { get; set; }

        // Tên phòng
        public string RoomName { get; set; }

        // Mã khu nhà (liên kết với khu nhà, nếu có)
        public int BuildingId { get; set; }

        // Giá thuê phòng
        public decimal RentPrice { get; set; }

        // Trạng thái phòng (true: Đã cho thuê, false: Trống)
        public bool IsOccupied { get; set; }

        // Diện tích phòng (m²)
        public double Area { get; set; }

        // Số người tối đa
        public int MaxOccupancy { get; set; }

        // Mô tả chi tiết về phòng
        public string Description { get; set; }
    }
}

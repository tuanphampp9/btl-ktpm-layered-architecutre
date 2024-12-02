using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLNhaTro.Models
{
    internal class Asset
    {
        public int MaTaiSan { get; set; } // PK_MaTaiSan
        public string TenTaiSan { get; set; } // sTenTaiSan
        public int SoLuong { get; set; } // iSoLuong
        public string TinhTrang { get; set; } // sTinhTrang
        public string ViTri { get; set; } // sViTri
        public int MaToa { get; set; } // FK_MaToa
        public int MaPhong { get; set; } // FK_MaPhong
    }
}

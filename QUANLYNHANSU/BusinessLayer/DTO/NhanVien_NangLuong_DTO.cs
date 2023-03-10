using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class NhanVien_NangLuong_DTO
    {
        public string SoQD { get; set; }
        public string SoHD { get; set; }
        public Nullable<double> HeSoLuongHienTai { get; set; }
        public Nullable<double> HeSoLuongMoi { get; set; }
        public Nullable<System.DateTime> NgayLenLuong { get; set; }
        public Nullable<System.DateTime> NgayKy { get; set; }
        public Nullable<int> Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public Nullable<int> Update_By { get; set; }
        public Nullable<System.DateTime> Update_Date { get; set; }
        public Nullable<int> Delete_By { get; set; }
        public Nullable<System.DateTime> Delete_Date { get; set; }
        public Nullable<int> MaNV { get; set; }
        public string GhiChu { get; set; }

        public string HoTen { get; set; }
    }
}

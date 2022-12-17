using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class HopDong_DTO
    {
        public string SoHD { get; set; }
        public string NgayBatDau { get; set; }
        public string NgayKetThuc { get; set; }
        public string NgayKy { get; set; }
        public string NoiDung { get; set; }
        public int LanKy { get; set; }
        public string ThoiHan { get; set; }
        public double HeSoLuong { get; set; }
        public Nullable<int> MaNV { get; set; }
        public Nullable<int> IDCongTy { get; set; }
        public Nullable<int> DELETED_BY { get; set; }
        public Nullable<System.DateTime> DELETED_DATE { get; set; }
        public Nullable<int> UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE { get; set; }
        public Nullable<int> CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string HoTen { get; set; }
        public string DienThoai { set; get; }
        public string CCCD { set; get; }
        public string DiaChi { set; get; }
        public string NgaySinh { set; get; }
        public Nullable<double> Luong { get; set; }

    }
}

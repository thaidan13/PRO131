using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class PhuCap_NhanVien_DTO
    {
        public int ID { get; set; }
        public Nullable<int> MaNV { get; set; }
        public Nullable<int> IDPhuCap { get; set; }
        public Nullable<System.DateTime> Ngay { get; set; }
        public string NoiDung { get; set; }
        public Nullable<double> SoTien { get; set; }

        public string HoTen { get; set; }
        public string TenPhuCap { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class NhanVien_DieuChuyen_DTO
    {
        public string SoQD { get; set; }
        public Nullable<System.DateTime> Ngay { get; set; }
        public Nullable<int> MaNV { get; set; }
        public string HoTen { get; set; }
        public int? MaPB { get; set; }
        public string TenPB { get; set; }
        public int? MaPB2 { get; set; }
        public string TenPB2 { get; set; }
        public string LyDo { get; set; }
        public string GhiChu { get; set; }
        public int Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public Nullable<int> Update_By { get; set; }
        public Nullable<System.DateTime> Update_Date { get; set; }
        public Nullable<int> Delete_By { get; set; }
        public Nullable<System.DateTime> Delete_Date { get; set; }
    }
}

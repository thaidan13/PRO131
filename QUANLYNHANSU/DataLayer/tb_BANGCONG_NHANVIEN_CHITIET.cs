//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_BANGCONG_NHANVIEN_CHITIET
    {
        public int ID { get; set; }
        public Nullable<int> MaKyCong { get; set; }
        public Nullable<int> IDCongTy { get; set; }
        public Nullable<int> MaNV { get; set; }
        public string HOTEN { get; set; }
        public Nullable<System.DateTime> NGAY { get; set; }
        public string THU { get; set; }
        public string GIOVAO { get; set; }
        public string GIORA { get; set; }
        public Nullable<double> NGAYPHEP { get; set; }
        public Nullable<double> CONGNGAYLE { get; set; }
        public Nullable<double> CONGCHUNHAT { get; set; }
        public string KYHIEU { get; set; }
        public string GHICHU { get; set; }
        public Nullable<int> CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE { get; set; }
        public Nullable<double> NGAYCONG { get; set; }
        public Nullable<double> NGAYVANG { get; set; }
    
        public virtual tb_CongTy tb_CongTy { get; set; }
    }
}

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
    
    public partial class tb_ThongTinNgoaiNgu
    {
        public int Id { get; set; }
        public Nullable<int> MaNV { get; set; }
        public string NgoaiNgu { get; set; }
        public string KetQua { get; set; }
        public string BangCap { get; set; }
        public Nullable<System.DateTime> NgayCap { get; set; }
        public Nullable<double> KinhPhi { get; set; }
        public string NguonKinhPhi { get; set; }
        public string GhiChu { get; set; }
        public Nullable<bool> ChinhPhu { get; set; }
    
        public virtual tb_NhanVien tb_NhanVien { get; set; }
    }
}

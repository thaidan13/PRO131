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
    
    public partial class tb_LichSuBanThanNhanVien
    {
        public int Id { get; set; }
        public Nullable<int> MaNV { get; set; }
        public Nullable<System.DateTime> TuNgay { get; set; }
        public Nullable<System.DateTime> DenNam { get; set; }
        public string LamGi { get; set; }
        public string ODau { get; set; }
    
        public virtual tb_NhanVien tb_NhanVien { get; set; }
    }
}

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
    
    public partial class tb_QuaTrinhLamViecCuaThanNhan
    {
        public int Id { get; set; }
        public Nullable<int> IdThongtinThanNhan { get; set; }
        public Nullable<System.DateTime> TuNam { get; set; }
        public Nullable<System.DateTime> DenNam { get; set; }
        public string CongViec { get; set; }
        public string DonVi { get; set; }
        public string CapBac { get; set; }
        public string ChucVu { get; set; }
        public string LoaiChucVu { get; set; }
        public Nullable<bool> TrongNganh { get; set; }
    
        public virtual tb_ThongTinGiaDinh tb_ThongTinGiaDinh { get; set; }
    }
}
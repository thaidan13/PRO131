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
    
    public partial class tb_HopDong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_HopDong()
        {
            this.tb_NangLuong = new HashSet<tb_NangLuong>();
        }
    
        public string SoHD { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
        public Nullable<System.DateTime> NgayKy { get; set; }
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
        public Nullable<double> Luong { get; set; }
    
        public virtual tb_CongTy tb_CongTy { get; set; }
        public virtual tb_NhanVien tb_NhanVien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_NangLuong> tb_NangLuong { get; set; }
    }
}
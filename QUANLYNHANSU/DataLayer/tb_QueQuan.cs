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
    
    public partial class tb_QueQuan
    {
        public int Id { get; set; }
        public Nullable<int> MaNV { get; set; }
        public string PhuongXa { get; set; }
        public string QuanHuyen { get; set; }
        public string ThanhPho { get; set; }
    
        public virtual tb_NhanVien tb_NhanVien { get; set; }
    }
}
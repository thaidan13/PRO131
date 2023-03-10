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
    
    public partial class tb_NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_NhanVien()
        {
            this.tb_BangCong = new HashSet<tb_BangCong>();
            this.tb_BaoHiem = new HashSet<tb_BaoHiem>();
            this.tb_NhanVien_PhuCap = new HashSet<tb_NhanVien_PhuCap>();
            this.tb_TangCa = new HashSet<tb_TangCa>();
            this.tb_UngLuong = new HashSet<tb_UngLuong>();
            this.tb_HopDong = new HashSet<tb_HopDong>();
            this.tb_KhenThuong_KyLuat = new HashSet<tb_KhenThuong_KyLuat>();
            this.tb_DieuChuyen = new HashSet<tb_DieuChuyen>();
            this.tb_ThoiViec = new HashSet<tb_ThoiViec>();
            this.tb_NangLuong = new HashSet<tb_NangLuong>();
            this.tb_KYCONGCHITIET = new HashSet<tb_KYCONGCHITIET>();
            this.tb_BoDoi = new HashSet<tb_BoDoi>();
            this.tb_Dang_Doan = new HashSet<tb_Dang_Doan>();
            this.tb_DienThoaiLienHe = new HashSet<tb_DienThoaiLienHe>();
            this.tb_NVDiNuocNgoai = new HashSet<tb_NVDiNuocNgoai>();
            this.tb_QueQuan = new HashSet<tb_QueQuan>();
            this.tb_QuocTich = new HashSet<tb_QuocTich>();
            this.tb_TamTru = new HashSet<tb_TamTru>();
            this.tb_ThongTinNhanVien = new HashSet<tb_ThongTinNhanVien>();
            this.tb_ThongTinTrinhDo = new HashSet<tb_ThongTinTrinhDo>();
            this.tb_ThongTinNgoaiNgu = new HashSet<tb_ThongTinNgoaiNgu>();
            this.tb_ThongTinViTinh = new HashSet<tb_ThongTinViTinh>();
            this.tb_ThongTinChinhTri = new HashSet<tb_ThongTinChinhTri>();
            this.tb_ThuongTru = new HashSet<tb_ThuongTru>();
            this.tb_NguoiGTVaoDang = new HashSet<tb_NguoiGTVaoDang>();
            this.tb_QuaTrinhDaoTaoCu = new HashSet<tb_QuaTrinhDaoTaoCu>();
            this.tb_QuaTrinhDaoTaoMoi = new HashSet<tb_QuaTrinhDaoTaoMoi>();
            this.tb_ChiTietKhenThuong = new HashSet<tb_ChiTietKhenThuong>();
            this.tb_ChiTietKyLuat = new HashSet<tb_ChiTietKyLuat>();
            this.tb_ChiTietHoSoLienQuan = new HashSet<tb_ChiTietHoSoLienQuan>();
            this.tb_HoSoTuyenDung = new HashSet<tb_HoSoTuyenDung>();
            this.tb_ThongTinGiaDinh = new HashSet<tb_ThongTinGiaDinh>();
            this.tb_LichSuBanThanNhanVien = new HashSet<tb_LichSuBanThanNhanVien>();
            this.tb_ThongTinHopDongLaoDong = new HashSet<tb_ThongTinHopDongLaoDong>();
            this.tb_QuaTrinhCongTac = new HashSet<tb_QuaTrinhCongTac>();
        }
    
        public int MaNV { get; set; }
        public string HoTen { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string DienThoai { get; set; }
        public string CCCD { get; set; }
        public string DiaChi { get; set; }
        public byte[] HinhAnh { get; set; }
        public Nullable<int> IDPB { get; set; }
        public Nullable<int> IDBP { get; set; }
        public Nullable<int> IDCV { get; set; }
        public Nullable<int> IDTD { get; set; }
        public Nullable<int> IDDanToc { get; set; }
        public Nullable<int> IDTonGiao { get; set; }
        public Nullable<int> IDCongTy { get; set; }
        public Nullable<bool> DaThoiViec { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_BangCong> tb_BangCong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_BaoHiem> tb_BaoHiem { get; set; }
        public virtual tb_BoPhan tb_BoPhan { get; set; }
        public virtual tb_ChucVu tb_ChucVu { get; set; }
        public virtual tb_DanToc tb_DanToc { get; set; }
        public virtual tb_TonGiao tb_TonGiao { get; set; }
        public virtual tb_PhongBan tb_PhongBan { get; set; }
        public virtual tb_TrinhDo tb_TrinhDo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_NhanVien_PhuCap> tb_NhanVien_PhuCap { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_TangCa> tb_TangCa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_UngLuong> tb_UngLuong { get; set; }
        public virtual tb_CongTy tb_CongTy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_HopDong> tb_HopDong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_KhenThuong_KyLuat> tb_KhenThuong_KyLuat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_DieuChuyen> tb_DieuChuyen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ThoiViec> tb_ThoiViec { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_NangLuong> tb_NangLuong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_KYCONGCHITIET> tb_KYCONGCHITIET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_BoDoi> tb_BoDoi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Dang_Doan> tb_Dang_Doan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_DienThoaiLienHe> tb_DienThoaiLienHe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_NVDiNuocNgoai> tb_NVDiNuocNgoai { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_QueQuan> tb_QueQuan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_QuocTich> tb_QuocTich { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_TamTru> tb_TamTru { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ThongTinNhanVien> tb_ThongTinNhanVien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ThongTinTrinhDo> tb_ThongTinTrinhDo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ThongTinNgoaiNgu> tb_ThongTinNgoaiNgu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ThongTinViTinh> tb_ThongTinViTinh { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ThongTinChinhTri> tb_ThongTinChinhTri { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ThuongTru> tb_ThuongTru { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_NguoiGTVaoDang> tb_NguoiGTVaoDang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_QuaTrinhDaoTaoCu> tb_QuaTrinhDaoTaoCu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_QuaTrinhDaoTaoMoi> tb_QuaTrinhDaoTaoMoi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ChiTietKhenThuong> tb_ChiTietKhenThuong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ChiTietKyLuat> tb_ChiTietKyLuat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ChiTietHoSoLienQuan> tb_ChiTietHoSoLienQuan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_HoSoTuyenDung> tb_HoSoTuyenDung { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ThongTinGiaDinh> tb_ThongTinGiaDinh { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_LichSuBanThanNhanVien> tb_LichSuBanThanNhanVien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ThongTinHopDongLaoDong> tb_ThongTinHopDongLaoDong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_QuaTrinhCongTac> tb_QuaTrinhCongTac { get; set; }
    }
}

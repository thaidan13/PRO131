using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer.DTO
{
    public class NhanVien_DTO
    {
        public int MaNV { get; set; }
        public string HoTen { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        public Nullable<bool> DaThoiViec { get; set; }
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


        public string TenPB { get; set; }
        public string TenBoPhan { get; set; }
        public string TenChucVu { get; set; }
        public string TenTrinhDo { get; set; }
        public string TenDanToc { get; set; }
        public string TenTonGiao { get; set; }
        public string DienThoaiNha { get; set; }
        public string DTDD { get; set; }
        public string Email { get; set; }

        //Thường Trú
        public string DiaChiThuongTru { get; set; }
        public string QuanHhuyen { get; set; }
        public string ThanhPho { get; set; }
        public string PhuongXa { get; set; }

        //Thông Tin Nhân Viên
        public string HoKhaiSinh { get; set; }
        public string HoThuongDung { get; set; }
        public Nullable<System.DateTime> NgaySinhNhanVien { get; set; }
        public Nullable<System.DateTime> NgayCap { get; set; }
        public string TheCanCuoc { get; set; }
        public string SoHoChieu { get; set; }
        public string TenKhaiSinh { get; set; }
        public string TenThuongDUng { get; set; }
        public string BiDanh { get; set; }
        public string CMND { get; set; }
        public string NoiCapCMND { get; set; }
        public Nullable<System.DateTime> NgayCapTheCC { get; set; }
        public Nullable<System.DateTime> NgayCapHoChie { get; set; }

        //Quê Quán
        public string PhuongXaQueQuan { get; set; }
        public string QuanHuyen { get; set; }
        public string ThanhPhoQueQuan { get; set; }

        //Tạm Trú
        public string DiaChiTamTru { get; set; }
        public string QuanHhuyenTamTru { get; set; }
        public string ThanhPhoTamTru { get; set; }
        public string PhuongXaTamTru { get; set; }

        //Thông Tin Ngoại Ngữ
        public string NgoaiNgu { get; set; }
        public string KetQua { get; set; }
        public string BangCap { get; set; }
        public Nullable<System.DateTime> NgayCapNN { get; set; }
        public Nullable<double> KinhPhi { get; set; }
        public string NguonKinhPhi { get; set; }
        public string GhiChu { get; set; }
        public Nullable<bool> ChinhPhu { get; set; }

        //Thông Tin Trình Độ
        public Nullable<System.DateTime> TuNam { get; set; }
        public Nullable<System.DateTime> DenNam { get; set; }
        public string CheDoHoc { get; set; }
        public string LoaiDaoTao { get; set; }
        public string TruongDaoTao { get; set; }
        public string NganhDaoTao { get; set; }
        public string BangCapTD { get; set; }
        public string NoiDung { get; set; }
        public string KetQuaTD { get; set; }
        public string ThoiGian { get; set; }
        public string ChuyenMon { get; set; }
        public string SoBang { get; set; }
        public Nullable<System.DateTime> NgayCapTD { get; set; }
        public string QuocGia { get; set; }

        //Đảng Đoàn
        public string SoTheDoan { get; set; }
        public Nullable<System.DateTime> NgayCapThe { get; set; }
        public Nullable<bool> DaVaoDoan { get; set; }
        public Nullable<System.DateTime> NgayVaoDangLan1 { get; set; }
        public Nullable<System.DateTime> NgayChinhThucLan1 { get; set; }
        public Nullable<System.DateTime> NgayVaoDangLan2 { get; set; }
        public Nullable<System.DateTime> NgayChinhThucLan2 { get; set; }
        public Nullable<System.DateTime> NgayVaoDoan { get; set; }
        public Nullable<bool> DaVaoDang { get; set; }

        //Thông Tin Gia ĐÌnh
        public string HoTenGD { get; set; }
        public string QuanHe { get; set; }
        public Nullable<System.DateTime> NgaySinhGD { get; set; }
        public string DiaChiGD { get; set; }
        public string Phuong { get; set; }
        public string QuanHuyenGD { get; set; }
        public string TinhThanh { get; set; }
        public Nullable<bool> ConSong { get; set; }

        //QuaTrinhLamViecCuaThanNhan
        public Nullable<int> IdThongtinThanNhan { get; set; }
        public Nullable<System.DateTime> TuNamTN { get; set; }
        public Nullable<System.DateTime> DenNamTN { get; set; }
        public string CongViec { get; set; }
        public string DonVi { get; set; }
        public string CapBac { get; set; }
        public string ChucVu { get; set; }
        public string LoaiChucVu { get; set; }
        public Nullable<bool> TrongNganh { get; set; }

        //Quốc Tịch
        public string QuocTich { get; set; }
        public string GocNguoi { get; set; }
        public string ThanhPhanGiaDinh { get; set; }
        public Nullable<int> ChieuCao { get; set; }
        public string NhanDang { get; set; }

        //Hợp đồng
        public double? Luong { get; set; }

        //Bộ đội
        public Nullable<System.DateTime> NgayNhapNgu { get; set; }
        public Nullable<System.DateTime> NgayXuatNgu { get; set; }

    }
}

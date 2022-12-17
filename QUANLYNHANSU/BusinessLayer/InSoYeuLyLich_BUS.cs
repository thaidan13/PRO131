using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer.DTO;

namespace BusinessLayer
{
    public class InSoYeuLyLich_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public List<NhanVien_DTO> getItemFull(int Manv)
        {
            List<tb_NhanVien> lstHD = db.tb_NhanVien.Where(x => x.MaNV == Manv).ToList();
            List<NhanVien_DTO> lstDTO = new List<NhanVien_DTO>();
            NhanVien_DTO nvdto;
            foreach (var item in lstHD)
            {
                nvdto = new NhanVien_DTO();
                nvdto.HoTen = item.HoTen;
                nvdto.GioiTinh = item.GioiTinh;
                //nvdto.GioiTinh = item.NgayBatDau.Value.ToString("dd/MM/yyyy");
                nvdto.DiaChi = item.DiaChi;
                nvdto.NgaySinh = item.NgaySinh;
                nvdto.HinhAnh = item.HinhAnh;

                var thuongtru = db.tb_ThuongTru.FirstOrDefault(n => n.MaNV == item.MaNV);
                nvdto.PhuongXa = thuongtru.PhuongXa;
                nvdto.QuanHhuyen = thuongtru.QuanHhuyen;
                nvdto.ThanhPho = thuongtru.ThanhPho;


                var ttnv = db.tb_ThongTinNhanVien.FirstOrDefault(n => n.MaNV == item.MaNV);
                nvdto.TheCanCuoc = ttnv.TheCanCuoc;
                nvdto.NoiCapCMND = ttnv.NoiCapCMND;
                nvdto.NgayCap = ttnv.NgayCap;
                nvdto.BiDanh = ttnv.BiDanh;
                nvdto.TenThuongDUng = ttnv.TenThuongDUng;
                nvdto.NgaySinhNhanVien = ttnv.NgaySinh;


                var lienhe = db.tb_DienThoaiLienHe.FirstOrDefault(n => n.MaNV == item.MaNV);
                nvdto.DienThoaiNha = lienhe.DienThoaiNha;
                nvdto.DTDD = lienhe.DTDD;

                nvdto.IDTonGiao = item.IDTonGiao;
                var tongiao = db.tb_TonGiao.FirstOrDefault(g => g.IDTonGiao == item.IDTonGiao);
                nvdto.TenTonGiao = tongiao.TenTonGiao;

                nvdto.IDDanToc = item.IDDanToc;
                var dt = db.tb_DanToc.FirstOrDefault(f => f.IDDanToc == item.IDDanToc);
                nvdto.TenDanToc = dt.TenDanToc;

                var trinhdo = db.tb_ThongTinTrinhDo.FirstOrDefault(n => n.MaNV == item.MaNV);
                nvdto.ChuyenMon = trinhdo.ChuyenMon;


                var dangdoan = db.tb_Dang_Doan.FirstOrDefault(n => n.MaNV == item.MaNV);
                nvdto.NgayChinhThucLan1 = dangdoan.NgayChinhThucLan1;
                nvdto.NgayVaoDoan = dangdoan.NgayVaoDoan;

                var quoctich = db.tb_QuocTich.FirstOrDefault(n => n.MaNV == item.MaNV);
                nvdto.ChieuCao = quoctich.ChieuCao;

                var hopdong = db.tb_HopDong.FirstOrDefault(n => n.MaNV == item.MaNV);
                nvdto.Luong = hopdong.Luong;

                var bodoi = db.tb_BoDoi.FirstOrDefault(n => n.MaNV == item.MaNV);
                nvdto.NgayNhapNgu = bodoi.NgayNhapNgu;
                nvdto.NgayXuatNgu = bodoi.NgayXuatNgu;



                lstDTO.Add(nvdto);
            }
            return lstDTO;
        }
    }
}

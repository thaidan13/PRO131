using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer.DTO;

namespace BusinessLayer
{
    public class HopDongLaoDong_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public tb_HopDong getItem(string sohd)
        {
            return db.tb_HopDong.FirstOrDefault(x => x.SoHD == sohd);
        }

        public List<HopDong_DTO> getItemFull(string sohd)
        {
            List<tb_HopDong> lstHD = db.tb_HopDong.Where(x => x.SoHD == sohd).ToList();
            List<HopDong_DTO> lstDTO = new List<HopDong_DTO>();
            HopDong_DTO hd;
            foreach (var item in lstHD)
            {
                hd = new HopDong_DTO();
                hd.SoHD = item.SoHD;
                hd.NgayBatDau = item.NgayBatDau.Value.ToString("dd/MM/yyyy");
                hd.NgayKetThuc = item.NgayKetThuc.Value.ToString("dd/MM/yyyy");
                hd.NgayKy = item.NgayKy.Value.ToString("dd/MM/yyyy");
                hd.LanKy = item.LanKy;
                hd.HeSoLuong = item.HeSoLuong;
                hd.NoiDung = item.NoiDung;
                hd.Luong = item.Luong;
                hd.MaNV = item.MaNV;
                var nv = db.tb_NhanVien.FirstOrDefault(n => n.MaNV == item.MaNV);
                hd.ThoiHan = item.ThoiHan;
                hd.HoTen = nv.HoTen;
                hd.CCCD = nv.CCCD;
                hd.DienThoai = nv.DienThoai;
                hd.DiaChi = nv.DiaChi;
                hd.NgaySinh = nv.NgaySinh.Value.ToString("dd/MM/yyyy");
                hd.CREATED_BY = item.CREATED_BY;
                hd.CREATED_DATE = item.CREATED_DATE;
                hd.UPDATED_BY = item.UPDATED_BY;
                hd.UPDATED_DATE = item.UPDATED_DATE;
                hd.DELETED_BY = item.DELETED_BY;
                hd.DELETED_DATE = item.DELETED_DATE;
                hd.IDCongTy = item.IDCongTy;
                lstDTO.Add(hd);
            }
            return lstDTO;
        }

        public List<tb_HopDong> getList()
        {
            return db.tb_HopDong.ToList();
        }

        public List<HopDong_DTO> getListFull()
        {
            List<tb_HopDong> lstHD = db.tb_HopDong.ToList();
            List<HopDong_DTO> lstDTO = new List<HopDong_DTO>();
            HopDong_DTO hd;
            foreach (var item in lstHD)
            {
                hd = new HopDong_DTO();
                hd.SoHD = item.SoHD;
                hd.NgayBatDau = item.NgayBatDau.Value.ToString("dd/MM/yyyy");
                hd.NgayKetThuc = item.NgayKetThuc.Value.ToString("dd/MM/yyyy");
                hd.NgayKy = item.NgayKy.Value.ToString("dd/MM/yyyy");
                hd.LanKy = item.LanKy;
                hd.Luong = item.Luong;
                hd.HeSoLuong = item.HeSoLuong;
                hd.NoiDung = item.NoiDung;
                hd.MaNV = item.MaNV;
                var nv = db.tb_NhanVien.FirstOrDefault(n => n.MaNV == item.MaNV);
                hd.ThoiHan = item.ThoiHan;
                hd.HoTen = nv.HoTen;
                hd.CCCD = nv.CCCD;
                hd.DienThoai = nv.DienThoai;
                hd.NgaySinh = nv.NgaySinh.Value.ToString("dd/MM/yyyy");
                hd.DiaChi = nv.DiaChi;
                hd.CREATED_BY = item.CREATED_BY;
                hd.CREATED_DATE = item.CREATED_DATE;
                hd.UPDATED_BY = item.UPDATED_BY;
                hd.UPDATED_DATE = item.UPDATED_DATE;
                hd.DELETED_BY = item.DELETED_BY;
                hd.DELETED_DATE = item.DELETED_DATE;
                hd.IDCongTy = item.IDCongTy;

                lstDTO.Add(hd);
            }
            return lstDTO;
        }

        public tb_HopDong Add(tb_HopDong hd)
        {
            try
            {
                db.tb_HopDong.Add(hd);
                db.SaveChanges();
                return hd;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public tb_HopDong EDIT(tb_HopDong hd)
        {
            try
            {
                var _hd = db.tb_HopDong.FirstOrDefault(x => x.SoHD == hd.SoHD);
                _hd.NgayBatDau = hd.NgayBatDau;
                _hd.NgayKetThuc = hd.NgayKetThuc;
                _hd.MaNV = hd.MaNV;
                _hd.NgayKy = hd.NgayKy;
                _hd.LanKy = hd.LanKy;
                _hd.HeSoLuong = hd.HeSoLuong;
                _hd.Luong = hd.Luong;
                _hd.NoiDung = hd.NoiDung;
                _hd.ThoiHan = hd.ThoiHan;
                _hd.SoHD = hd.SoHD;
                _hd.IDCongTy = hd.IDCongTy;
                _hd.UPDATED_BY = hd.UPDATED_BY;
                _hd.UPDATED_DATE = hd.UPDATED_DATE;
                db.SaveChanges();
                return hd;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Detele(string sohd, int manv)
        {
            var _hd = db.tb_HopDong.FirstOrDefault(x => x.SoHD == sohd);

            _hd.DELETED_BY = manv;
            _hd.DELETED_DATE = DateTime.Now;
            db.SaveChanges();
        }

        public string MaxSoHopDong()
        {
            var _hd = db.tb_HopDong.OrderByDescending(x => x.CREATED_DATE).FirstOrDefault();
            if(_hd != null)
            {
                return _hd.SoHD;
            }
            else
            {
                return "00000";
            }
        }
    }
}

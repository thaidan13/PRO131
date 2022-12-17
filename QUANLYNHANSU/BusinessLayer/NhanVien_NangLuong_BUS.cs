using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer.DTO;

namespace BusinessLayer
{
    public class NhanVien_NangLuong_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public tb_NangLuong getItem(string soqd)
        {
            return db.tb_NangLuong.FirstOrDefault(x => x.SoQD == soqd);
        }

        public List<tb_NangLuong> getList()
        {
            return db.tb_NangLuong.ToList();
        }

        public List<NhanVien_NangLuong_DTO> getListFull()
        {
            var lstNL = db.tb_NangLuong.ToList();
            List<NhanVien_NangLuong_DTO> lstDTO = new List<NhanVien_NangLuong_DTO>();
            NhanVien_NangLuong_DTO nlDTO;
            foreach(var item in lstNL)
            {
                nlDTO = new NhanVien_NangLuong_DTO();
                nlDTO.SoQD = item.SoQD;
                nlDTO.SoHD = item.SoHD;
                nlDTO.NgayKy = item.NgayKy;
                nlDTO.NgayLenLuong = item.NgayLenLuong;
                nlDTO.HeSoLuongHienTai = item.HeSoLuongHienTai;
                nlDTO.HeSoLuongMoi = item.HeSoLuongMoi;
                nlDTO.GhiChu = item.GhiChu;
                nlDTO.MaNV = item.MaNV;
                var nv = db.tb_NhanVien.FirstOrDefault(x => x.MaNV == item.MaNV);
                nlDTO.HoTen = nv.HoTen;
                nlDTO.Created_By = item.Created_By;
                nlDTO.Created_Date = item.Created_Date;
                nlDTO.Delete_By = item.Delete_By;
                nlDTO.Delete_Date = item.Delete_Date;
                nlDTO.Update_By = item.Update_By;
                nlDTO.Update_Date = item.Update_Date;
                lstDTO.Add(nlDTO);
            }
            return lstDTO;
        }

        public tb_NangLuong Add(tb_NangLuong nangluong)
        {
            try
            {
                db.tb_NangLuong.Add(nangluong);
                db.SaveChanges();
                return nangluong;
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_NangLuong Update(tb_NangLuong nangluong)
        {
            try
            {
                var _nangluong = db.tb_NangLuong.FirstOrDefault(x => x.SoQD == nangluong.SoQD);
                _nangluong.SoHD = nangluong.SoHD;
                _nangluong.HeSoLuongHienTai = nangluong.HeSoLuongHienTai;
                _nangluong.HeSoLuongMoi = nangluong.HeSoLuongMoi;
                _nangluong.NgayKy = nangluong.NgayKy;
                _nangluong.NgayLenLuong = nangluong.NgayLenLuong;
                _nangluong.Update_By = nangluong.Update_By;
                _nangluong.Update_Date = nangluong.Update_Date;
                _nangluong.GhiChu = nangluong.GhiChu;
                _nangluong.MaNV = nangluong.MaNV;
                db.SaveChanges();
                return nangluong;
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public void Delete(string soqd, int iduser)
        {
            try
            {
                var _nangluong = db.tb_NangLuong.FirstOrDefault(x => x.SoQD == soqd);
                _nangluong.Delete_By = iduser;
                _nangluong.Delete_Date = DateTime.Now;
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public string MaxSoQuyetDinh()
        {
            var _tv = db.tb_NangLuong.OrderByDescending(x => x.Created_Date).FirstOrDefault();
            if (_tv != null)
            {
                return _tv.SoQD;
            }
            else
                return "00000";
        }


    }
}

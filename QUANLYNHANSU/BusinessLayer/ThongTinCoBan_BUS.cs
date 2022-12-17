using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class ThongTinCoBan_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_ThongTinNhanVien getItem(int manv)
        {
            return db.tb_ThongTinNhanVien.FirstOrDefault(x => x.MaNV == manv);
        }

        public List<tb_ThongTinNhanVien> getList(int manv)
        {
            return db.tb_ThongTinNhanVien.ToList();
        }

        public tb_ThongTinNhanVien Add(tb_ThongTinNhanVien ttnv)
        {
            try
            {
                db.tb_ThongTinNhanVien.Add(ttnv);
                db.SaveChanges();
                return ttnv;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_ThongTinNhanVien Update(tb_ThongTinNhanVien ttnv)
        {
            try
            {
                var _ttnv = db.tb_ThongTinNhanVien.FirstOrDefault(x => x.Id == ttnv.Id);
                _ttnv.HoKhaiSinh = ttnv.HoKhaiSinh;
                _ttnv.HoThuongDung = ttnv.HoThuongDung;
                _ttnv.NgaySinh = ttnv.NgaySinh;
                _ttnv.MaNV = ttnv.MaNV;
                _ttnv.NgayCap = ttnv.NgayCap;
                _ttnv.NgayCapHoChie = ttnv.NgayCapHoChie;
                _ttnv.NgayCapTheCC = ttnv.NgayCapTheCC;
                _ttnv.NoiCapCMND = ttnv.NoiCapCMND;
                _ttnv.SoHoChieu = ttnv.SoHoChieu;
                _ttnv.TenKhaiSinh = ttnv.TenKhaiSinh;
                _ttnv.TenThuongDUng = ttnv.TenThuongDUng;
                _ttnv.TheCanCuoc = ttnv.TheCanCuoc;
                _ttnv.BiDanh = ttnv.BiDanh;
                _ttnv.CMND = ttnv.CMND;

                db.SaveChanges();
                return ttnv;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public int check(int manv)
        {
            var check = db.tb_ThongTinNhanVien.Where(x => x.MaNV == manv).Count();
            return check;
        }
    }
}

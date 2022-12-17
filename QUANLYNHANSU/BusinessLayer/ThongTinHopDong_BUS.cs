using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class ThongTinHopDong_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_ThongTinHopDongLaoDong getItem(int manv)
        {
            return db.tb_ThongTinHopDongLaoDong.FirstOrDefault(x => x.Id == manv);
        }

        public List<tb_ThongTinHopDongLaoDong> getList(int manv)
        {
            return db.tb_ThongTinHopDongLaoDong.Where(x => x.MaNV == manv).ToList();
        }

        public List<tb_ThongTinHopDongLaoDong> getListhopdong()
        {
            return db.tb_ThongTinHopDongLaoDong.ToList();
        }

        public tb_ThongTinHopDongLaoDong Add(tb_ThongTinHopDongLaoDong tthdld)
        {
            try
            {
                db.tb_ThongTinHopDongLaoDong.Add(tthdld);
                db.SaveChanges();
                return tthdld;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_ThongTinHopDongLaoDong Update(tb_ThongTinHopDongLaoDong tthdld)
        {
            try
            {
                var _tthdld = db.tb_ThongTinHopDongLaoDong.FirstOrDefault(x => x.Id == tthdld.Id);
                _tthdld.LoaiHopDong = tthdld.LoaiHopDong;
                _tthdld.ThoiHan = tthdld.ThoiHan;
                _tthdld.ChucDanh = tthdld.ChucDanh;
                _tthdld.MaNV = tthdld.MaNV;
                _tthdld.BacLuong = tthdld.BacLuong;
                _tthdld.HeSoLuong = tthdld.HeSoLuong;
                _tthdld.NgayKy = tthdld.NgayKy;
                _tthdld.NguoiKy = tthdld.NguoiKy;
                _tthdld.NgayThuViec = tthdld.NgayThuViec;
                _tthdld.NgayChinhThuc = tthdld.NgayChinhThuc;
                _tthdld.NgayHetHan = tthdld.NgayHetHan;
                _tthdld.NgayGiaHan = tthdld.NgayGiaHan;
                _tthdld.FileQuyetDinh = tthdld.FileQuyetDinh;
                _tthdld.FileHDLD = tthdld.FileHDLD;

                db.SaveChanges();
                return tthdld;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public int checkthongtinlienlac(int manv)
        {
            var check = db.tb_DienThoaiLienHe.Where(x => x.MaNV == manv).Count();
            return check;
        }

        public string MaxSoHopDong()
        {
            var _hd = db.tb_ThongTinHopDongLaoDong.OrderByDescending(x => x.CREATED_DATE).FirstOrDefault();
            if (_hd != null)
            {
                return _hd.SoHDLD;
            }
            else
            {
                return "00000";
            }
        }
    }
}

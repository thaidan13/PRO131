using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class ThongTinGiaDinh_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_ThongTinGiaDinh getItem(int manv)
        {
            return db.tb_ThongTinGiaDinh.FirstOrDefault(x => x.Id == manv);
        }

        public List<tb_ThongTinGiaDinh> getList(int manv)
        {
            return db.tb_ThongTinGiaDinh.Where(x => x.MaNV == manv).ToList();
        }

        public tb_ThongTinGiaDinh Add(tb_ThongTinGiaDinh ttgd)
        {
            try
            {
                db.tb_ThongTinGiaDinh.Add(ttgd);
                db.SaveChanges();
                return ttgd;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_ThongTinGiaDinh Update(tb_ThongTinGiaDinh ttgd)
        {
            try
            {
                var _ttgd = db.tb_ThongTinGiaDinh.FirstOrDefault(x => x.Id == ttgd.Id);
                _ttgd.HoTen = ttgd.HoTen;
                _ttgd.QuanHe = ttgd.QuanHe;
                _ttgd.NgaySinh = ttgd.NgaySinh;
                _ttgd.MaNV = ttgd.MaNV;
                _ttgd.DiaChi = ttgd.DiaChi;
                _ttgd.Phuong = ttgd.Phuong;
                _ttgd.QuanHuyen = ttgd.QuanHuyen;
                _ttgd.TinhThanh = ttgd.TinhThanh;
                _ttgd.ConSong = ttgd.ConSong;
                
                db.SaveChanges();
                return ttgd;
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class HoSoLienQuan_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_ChiTietHoSoLienQuan getItem(int manv)
        {
            return db.tb_ChiTietHoSoLienQuan.FirstOrDefault(x => x.Id == manv);
        }

        public List<tb_ChiTietHoSoLienQuan> getList(int manv)
        {
            return db.tb_ChiTietHoSoLienQuan.Where(x => x.MaNV == manv).ToList();
        }

        public tb_ChiTietHoSoLienQuan Add(tb_ChiTietHoSoLienQuan hstd)
        {
            try
            {
                db.tb_ChiTietHoSoLienQuan.Add(hstd);
                db.SaveChanges();
                return hstd;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_ChiTietHoSoLienQuan Update(tb_ChiTietHoSoLienQuan hstd)
        {
            try
            {
                var _hstd = db.tb_ChiTietHoSoLienQuan.FirstOrDefault(x => x.Id == hstd.Id);
                _hstd.Ten = hstd.Ten;
                _hstd.TapTin = hstd.TapTin;

                db.SaveChanges();
                return hstd;
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

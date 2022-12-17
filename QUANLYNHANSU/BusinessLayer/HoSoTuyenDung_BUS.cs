using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class HoSoTuyenDung_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_HoSoTuyenDung getItem(int manv)
        {
            return db.tb_HoSoTuyenDung.FirstOrDefault(x => x.Id == manv);
        }

        public List<tb_HoSoTuyenDung> getList(int manv)
        {
            return db.tb_HoSoTuyenDung.Where(x => x.MaNV == manv).ToList();
        }

        public tb_HoSoTuyenDung Add(tb_HoSoTuyenDung hstd)
        {
            try
            {
                db.tb_HoSoTuyenDung.Add(hstd);
                db.SaveChanges();
                return hstd;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_HoSoTuyenDung Update(tb_HoSoTuyenDung hstd)
        {
            try
            {
                var _hstd = db.tb_HoSoTuyenDung.FirstOrDefault(x => x.Id == hstd.Id);
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

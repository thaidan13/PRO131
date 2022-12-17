using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class LichSuNhanVien_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_LichSuBanThanNhanVien getItem(int manv)
        {
            return db.tb_LichSuBanThanNhanVien.FirstOrDefault(x => x.Id == manv);
        }

        public List<tb_LichSuBanThanNhanVien> getList(int manv)
        {
            return db.tb_LichSuBanThanNhanVien.Where(x => x.MaNV == manv).ToList();
        }

        public tb_LichSuBanThanNhanVien Add(tb_LichSuBanThanNhanVien lsnv)
        {
            try
            {
                db.tb_LichSuBanThanNhanVien.Add(lsnv);
                db.SaveChanges();
                return lsnv;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_LichSuBanThanNhanVien Update(tb_LichSuBanThanNhanVien lsnv)
        {
            try
            {
                var _lsnv = db.tb_LichSuBanThanNhanVien.FirstOrDefault(x => x.Id == lsnv.Id);
                _lsnv.TuNgay = lsnv.TuNgay;
                _lsnv.DenNam = lsnv.DenNam;
                _lsnv.LamGi = lsnv.LamGi;
                _lsnv.MaNV = lsnv.MaNV;
                _lsnv.ODau = lsnv.ODau;

                db.SaveChanges();
                return lsnv;
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

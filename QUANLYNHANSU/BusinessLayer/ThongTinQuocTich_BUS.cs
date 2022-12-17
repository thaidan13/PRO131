using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;


namespace BusinessLayer
{
    public class ThongTinQuocTich_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_QuocTich getItem(int manv)
        {
            return db.tb_QuocTich.FirstOrDefault(x => x.MaNV == manv);
        }

        public List<tb_QuocTich> getList(int manv)
        {
            return db.tb_QuocTich.ToList();
        }

        public tb_QuocTich Add(tb_QuocTich ttqt)
        {
            try
            {
                db.tb_QuocTich.Add(ttqt);
                db.SaveChanges();
                return ttqt;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_QuocTich Update(tb_QuocTich ttqt)
        {
            try
            {
                var _ttqt = db.tb_QuocTich.FirstOrDefault(x => x.Id == ttqt.Id);
                _ttqt.QuocTich = ttqt.QuocTich;
                _ttqt.GocNguoi = ttqt.GocNguoi;
                _ttqt.ThanhPhanGiaDinh = ttqt.ThanhPhanGiaDinh;
                _ttqt.MaNV = ttqt.MaNV;
                _ttqt.ChieuCao = ttqt.ChieuCao;
                _ttqt.NhanDang = ttqt.NhanDang;
                
                db.SaveChanges();
                return ttqt;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public int check(int manv)
        {
            var check = db.tb_QuocTich.Where(x => x.MaNV == manv).Count();
            return check;
        }

    }
}

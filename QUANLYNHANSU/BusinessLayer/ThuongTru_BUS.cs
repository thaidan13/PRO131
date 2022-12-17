using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class ThuongTru_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_ThuongTru getItem(int manv)
        {
            return db.tb_ThuongTru.FirstOrDefault(x => x.MaNV == manv);
        }

        public List<tb_ThuongTru> getList(int manv)
        {
            return db.tb_ThuongTru.ToList();
        }

        public tb_ThuongTru Add(tb_ThuongTru tt)
        {
            try
            {
                db.tb_ThuongTru.Add(tt);
                db.SaveChanges();
                return tt;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_ThuongTru Update(tb_ThuongTru tt)
        {
            try
            {
                var _tt = db.tb_ThuongTru.FirstOrDefault(x => x.Id == tt.Id);
                _tt.DiaChi = tt.DiaChi;
                _tt.PhuongXa = tt.PhuongXa;
                _tt.ThanhPho = tt.ThanhPho;
                _tt.QuanHhuyen = tt.QuanHhuyen;
                _tt.MaNV = tt.MaNV;

                db.SaveChanges();
                return tt;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public int check(int manv)
        {
            var check = db.tb_ThuongTru.Where(x => x.MaNV == manv).Count();
            return check;
        }
    }
}

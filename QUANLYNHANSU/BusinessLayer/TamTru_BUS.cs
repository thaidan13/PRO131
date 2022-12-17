using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class TamTru_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_TamTru getItem(int manv)
        {
            return db.tb_TamTru.FirstOrDefault(x => x.MaNV == manv);
        }

        public List<tb_TamTru> getList(int manv)
        {
            return db.tb_TamTru.ToList();
        }

        public tb_TamTru Add(tb_TamTru tt)
        {
            try
            {
                db.tb_TamTru.Add(tt);
                db.SaveChanges();
                return tt;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_TamTru Update(tb_TamTru tt)
        {
            try
            {
                var _tt = db.tb_TamTru.FirstOrDefault(x => x.Id == tt.Id);
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
            var check = db.tb_TamTru.Where(x => x.MaNV == manv).Count();
            return check;
        }
    }
}

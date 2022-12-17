using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class QueQuan_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_QueQuan getItem(int manv)
        {
            return db.tb_QueQuan.FirstOrDefault(x => x.MaNV == manv);
        }

        public List<tb_QueQuan> getList(int manv)
        {
            return db.tb_QueQuan.ToList();
        }

        public tb_QueQuan Add(tb_QueQuan qq)
        {
            try
            {
                db.tb_QueQuan.Add(qq);
                db.SaveChanges();
                return qq;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_QueQuan Update(tb_QueQuan qq)
        {
            try
            {
                var _qq = db.tb_QueQuan.FirstOrDefault(x => x.Id == qq.Id);
                _qq.PhuongXa = qq.PhuongXa;
                _qq.QuanHuyen = qq.QuanHuyen;
                _qq.ThanhPho = qq.ThanhPho;
                _qq.MaNV = qq.MaNV;

                db.SaveChanges();
                return qq;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public int check(int manv)
        {
            var check = db.tb_QueQuan.Where(x => x.MaNV == manv).Count();
            return check;
        }
    }
}

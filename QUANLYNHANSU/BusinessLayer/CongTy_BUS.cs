using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class CongTy_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_CongTy getItem(int id)
        {
            return db.tb_CongTy.FirstOrDefault(x => x.IDCongTy == id);
        }

        public List<tb_CongTy> getList()
        {
            return db.tb_CongTy.ToList();
        }

        public tb_CongTy Add(tb_CongTy dt)
        {
            try
            {
                db.tb_CongTy.Add(dt);
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_CongTy Edit(tb_CongTy dt)
        {
            try
            {
                var _dt = db.tb_CongTy.FirstOrDefault(x => x.IDCongTy == dt.IDCongTy);
                _dt.TenCongTy = dt.TenCongTy;
                _dt.DienThoai = dt.DienThoai;
                _dt.Email = dt.Email;
                _dt.DiaChi = dt.DiaChi;
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var _dt = db.tb_CongTy.FirstOrDefault(x => x.IDCongTy == id);
                db.tb_CongTy.Remove(_dt);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}

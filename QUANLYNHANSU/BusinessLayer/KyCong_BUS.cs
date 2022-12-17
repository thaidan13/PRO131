using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class KyCong_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_KyCong getItem(int makycong)
        {
            return db.tb_KyCong.FirstOrDefault(x => x.MaKyCong == makycong);
        }

        public List<tb_KyCong> getList()
        {
            return db.tb_KyCong.ToList();
        }

        public tb_KyCong Add(tb_KyCong kc)
        {
            try
            {
                db.tb_KyCong.Add(kc);
                db.SaveChanges();
                return kc;
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi: " + ex);
            }
        }

        public tb_KyCong Update(tb_KyCong kc)
        {
            try
            {
                tb_KyCong _kc = db.tb_KyCong.FirstOrDefault(x => x.MaKyCong == kc.MaKyCong);
                _kc.MaKyCong = kc.MaKyCong;
                _kc.Nam = kc.Nam;
                _kc.Thang = kc.Thang;
                _kc.Khoa = kc.Khoa;
                _kc.TrangThai = kc.TrangThai;
                _kc.NgayCongTrongThang = kc.NgayCongTrongThang;
                _kc.NgayTinhCong = kc.NgayTinhCong;
                _kc.Updated_By = kc.Updated_By;
                _kc.Updated_Date = kc.Updated_Date;
                db.SaveChanges();
                return kc;
                
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex);
            }
        }

        public void Delete(int id, int iduser)
        {
            try
            {
                var _kc = db.tb_KyCong.FirstOrDefault(x => x.MaKyCong == id);
                _kc.Deleted_By = iduser;
                _kc.Deleted_Date = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public bool KiemTraPhatSinhKyCong(int makycong)
        {
            var kc = db.tb_KyCong.FirstOrDefault(x => x.MaKyCong == makycong);
            if(kc == null)
            {
                return false;
            }
            else
            {
                if (kc.TrangThai == true)
                    return true;
                else
                    return false;
            }
        }

    }
}

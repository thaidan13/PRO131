using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class LOAICONG
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public tb_LoaiCong getItem(int id)
        {
            return db.tb_LoaiCong.FirstOrDefault(x => x.IDLoaiCong == id);
        }
        public List<tb_LoaiCong> getList()
        {
            return db.tb_LoaiCong.ToList();
        }
        public tb_LoaiCong Add(tb_LoaiCong lc)
        {
            try
            {
                db.tb_LoaiCong.Add(lc);
                db.SaveChanges();
                return lc;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_LoaiCong Update(tb_LoaiCong lc)
        {
            try
            {
                var _lc = db.tb_LoaiCong.FirstOrDefault(x => x.IDLoaiCong == lc.IDLoaiCong);
                _lc.TenLoaiCong = lc.TenLoaiCong;
                _lc.Heso = lc.Heso;
                _lc.Update_By = lc.Update_By;
                _lc.Update_Date = lc.Update_Date;
                db.SaveChanges();
                return lc;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(int id, int iduser)
        {
            try
            {
                var _lc = db.tb_LoaiCong.FirstOrDefault(x => x.IDLoaiCong == id);
                _lc.Delete_By = iduser;
                _lc.Delete_Date = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}

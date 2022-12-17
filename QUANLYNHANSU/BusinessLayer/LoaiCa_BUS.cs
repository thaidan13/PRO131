using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class LoaiCa_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public tb_LoaiCa getItem(int IDLoaiCa)
        {
            return db.tb_LoaiCa.FirstOrDefault(x => x.IDLoaiCa == IDLoaiCa);
        }
        public List<tb_LoaiCa> getList()
        {
            return db.tb_LoaiCa.ToList();
        }
        public tb_LoaiCa Add(tb_LoaiCa lc)
        {
            try
            {
                db.tb_LoaiCa.Add(lc);
                db.SaveChanges();
                return lc;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_LoaiCa Update(tb_LoaiCa lc)
        {
            try
            {
                var _lc = db.tb_LoaiCa.FirstOrDefault(x => x.IDLoaiCa == lc.IDLoaiCa);
                _lc.TenLoaiCa = lc.TenLoaiCa;
                _lc.HeSo = lc.HeSo;
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
        public void Delete(int IDLoaiCa, int iduser)
        {
            var _lc = db.tb_LoaiCa.FirstOrDefault(x => x.IDLoaiCa == IDLoaiCa);
            _lc.Delete_By = iduser;
            _lc.Delete_Date = DateTime.Now;
            db.SaveChanges();
        }
    }
}

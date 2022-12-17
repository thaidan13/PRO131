using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class TrinhDo_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_TrinhDo getItem(int id)
        {
            return db.tb_TrinhDo.FirstOrDefault(x => x.IDTD == id);
        }

        public List<tb_TrinhDo> getList()
        {
            return db.tb_TrinhDo.ToList();
        }

        public tb_TrinhDo Add(tb_TrinhDo dt)
        {
            try
            {
                db.tb_TrinhDo.Add(dt);
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_TrinhDo Edit(tb_TrinhDo dt)
        {
            try
            {
                var _dt = db.tb_TrinhDo.FirstOrDefault(x => x.IDTD == dt.IDTD);
                _dt.TenTrinhDo = dt.TenTrinhDo;
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
                var _dt = db.tb_TrinhDo.FirstOrDefault(x => x.IDTD == id);
                db.tb_TrinhDo.Remove(_dt);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}

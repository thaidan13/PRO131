using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class BoPhan_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_BoPhan getItem(int id)
        {
            return db.tb_BoPhan.FirstOrDefault(x => x.IDBP == id);
        }

        public List<tb_BoPhan> getList()
        {
            return db.tb_BoPhan.ToList();
        }

        public tb_BoPhan Add(tb_BoPhan dt)
        {
            try
            {
                db.tb_BoPhan.Add(dt);
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_BoPhan Edit(tb_BoPhan dt)
        {
            try
            {
                var _dt = db.tb_BoPhan.FirstOrDefault(x => x.IDBP == dt.IDBP);
                _dt.TenBoPhan = dt.TenBoPhan;
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
                var _dt = db.tb_BoPhan.FirstOrDefault(x => x.IDBP == id);
                db.tb_BoPhan.Remove(_dt);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}

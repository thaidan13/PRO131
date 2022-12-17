using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class DanToc_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_DanToc getItem(int id)
        {
            return db.tb_DanToc.FirstOrDefault(x => x.IDDanToc == id);
        }

        public List<tb_DanToc> getList()
        {
            return db.tb_DanToc.ToList();
        }

        public tb_DanToc Add(tb_DanToc dt)
        {
            try
            {
                db.tb_DanToc.Add(dt);
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_DanToc Edit(tb_DanToc dt)
        {
            try
            {
                var _dt = db.tb_DanToc.FirstOrDefault(x => x.IDDanToc == dt.IDDanToc);
                _dt.TenDanToc = dt.TenDanToc;
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
                var _dt = db.tb_DanToc.FirstOrDefault(x => x.IDDanToc == id);
                db.tb_DanToc.Remove(_dt);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

    }
}

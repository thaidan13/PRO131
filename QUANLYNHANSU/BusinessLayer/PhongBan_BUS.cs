using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class PhongBan_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_PhongBan getItem(int id)
        {
            return db.tb_PhongBan.FirstOrDefault(x => x.IDPB == id);
        }

        public List<tb_PhongBan> getList()
        {
            return db.tb_PhongBan.ToList();
        }

        public tb_PhongBan Add(tb_PhongBan dt)
        {
            try
            {
                db.tb_PhongBan.Add(dt);
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_PhongBan Edit(tb_PhongBan dt)
        {
            try
            {
                var _dt = db.tb_PhongBan.FirstOrDefault(x => x.IDPB == dt.IDPB);
                _dt.TenPB = dt.TenPB;
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
                var _dt = db.tb_PhongBan.FirstOrDefault(x => x.IDPB == id);
                db.tb_PhongBan.Remove(_dt);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

    }
}

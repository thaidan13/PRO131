using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class ChucVu_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_ChucVu getItem(int id)
        {
            return db.tb_ChucVu.FirstOrDefault(x => x.IDCV == id);
        }

        public List<tb_ChucVu> getList()
        {
            return db.tb_ChucVu.ToList();
        }

        public tb_ChucVu Add(tb_ChucVu dt)
        {
            try
            {
                db.tb_ChucVu.Add(dt);
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_ChucVu Edit(tb_ChucVu dt)
        {
            try
            {
                var _dt = db.tb_ChucVu.FirstOrDefault(x => x.IDCV == dt.IDCV);
                _dt.TenChucVu = dt.TenChucVu;
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
                var _dt = db.tb_ChucVu.FirstOrDefault(x => x.IDCV == id);
                db.tb_ChucVu.Remove(_dt);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

    }
}

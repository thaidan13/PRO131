using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class TonGiao_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_TonGiao getItem(int id)
        {
            return db.tb_TonGiao.FirstOrDefault(x => x.IDTonGiao == id);
        }

        public List<tb_TonGiao> getList()
        {
            return db.tb_TonGiao.ToList();
        }

        public tb_TonGiao Add(tb_TonGiao dt)
        {
            try
            {
                db.tb_TonGiao.Add(dt);
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_TonGiao Edit(tb_TonGiao dt)
        {
            try
            {
                var _dt = db.tb_TonGiao.FirstOrDefault(x => x.IDTonGiao == dt.IDTonGiao);
                _dt.TenTonGiao = dt.TenTonGiao;
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
                var _dt = db.tb_TonGiao.FirstOrDefault(x => x.IDTonGiao == id);
                db.tb_TonGiao.Remove(_dt);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}

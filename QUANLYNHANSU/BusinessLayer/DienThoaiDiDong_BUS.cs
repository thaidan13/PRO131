using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class DienThoaiDiDong_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_DienThoaiLienHe getItem(int manv)
        {
            return db.tb_DienThoaiLienHe.FirstOrDefault(x => x.MaNV == manv);
        }

        public List<tb_DienThoaiLienHe> getList(int manv)
        {
            return db.tb_DienThoaiLienHe.ToList();
        }

        public tb_DienThoaiLienHe Add(tb_DienThoaiLienHe dtlh)
        {
            try
            {
                db.tb_DienThoaiLienHe.Add(dtlh);
                db.SaveChanges();
                return dtlh;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_DienThoaiLienHe Update(tb_DienThoaiLienHe dtlh)
        {
            try
            {
                var _dtlh = db.tb_DienThoaiLienHe.FirstOrDefault(x => x.Id == dtlh.Id);
                _dtlh.DienThoaiNha = dtlh.DienThoaiNha;
                _dtlh.DTDD = dtlh.DTDD;
                _dtlh.Email = dtlh.Email;
                _dtlh.MaNV = dtlh.MaNV;

                db.SaveChanges();
                return dtlh;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public int check(int manv)
        {
            var check = db.tb_DienThoaiLienHe.Where(x => x.MaNV == manv).Count();
            return check;
        }
    }
}

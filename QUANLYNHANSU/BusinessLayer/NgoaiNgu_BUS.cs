using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class NgoaiNgu_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_ThongTinNgoaiNgu getItem(int manv)
        {
            return db.tb_ThongTinNgoaiNgu.FirstOrDefault(x => x.Id == manv);
        }

        public List<tb_ThongTinNgoaiNgu> getList(int manv)
        {
            List<tb_ThongTinNgoaiNgu> lstKT = db.tb_ThongTinNgoaiNgu.Where(x => x.MaNV == manv).ToList();
            return lstKT.ToList();
        }

        public tb_ThongTinNgoaiNgu Add(tb_ThongTinNgoaiNgu ttng)
        {
            try
            {
                db.tb_ThongTinNgoaiNgu.Add(ttng);
                db.SaveChanges();
                return ttng;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_ThongTinNgoaiNgu Update(tb_ThongTinNgoaiNgu ttng)
        {
            try
            {
                var _ttng = db.tb_ThongTinNgoaiNgu.FirstOrDefault(x => x.Id == ttng.Id);
                _ttng.NgoaiNgu = ttng.NgoaiNgu;
                _ttng.KetQua = ttng.KetQua;
                _ttng.BangCap = ttng.BangCap;
                _ttng.NgayCap = ttng.NgayCap;
                _ttng.KinhPhi = ttng.KinhPhi;
                _ttng.ChinhPhu = ttng.ChinhPhu;
                _ttng.NguonKinhPhi = ttng.NguonKinhPhi;
                _ttng.GhiChu = ttng.GhiChu;
                

                db.SaveChanges();
                return _ttng;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}

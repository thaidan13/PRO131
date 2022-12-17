using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class ChinhTri_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_ThongTinChinhTri getItem(int manv)
        {
            return db.tb_ThongTinChinhTri.FirstOrDefault(x => x.Id == manv);
        }

        public tb_ThongTinChinhTri Add(tb_ThongTinChinhTri ttct)
        {
            try
            {
                db.tb_ThongTinChinhTri.Add(ttct);
                db.SaveChanges();
                return ttct;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_ThongTinChinhTri Update(tb_ThongTinChinhTri ttct)
        {
            try
            {
                var _ttct = db.tb_ThongTinChinhTri.FirstOrDefault(x => x.Id == ttct.Id);
                _ttct.TrinhDoChinhTri = ttct.TrinhDoChinhTri;
                _ttct.CheDoHoc = ttct.CheDoHoc;
                _ttct.TuNgay = ttct.TuNgay;
                _ttct.NgayCap = ttct.NgayCap;
                _ttct.KinhPhi = ttct.KinhPhi;
                _ttct.DenNgay = ttct.DenNgay;
                _ttct.NguonKinhPhi = ttct.NguonKinhPhi;
                
                db.SaveChanges();
                return _ttct;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}

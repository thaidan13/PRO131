using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;


namespace BusinessLayer
{
    public class QuaTrinhDaoTao_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_ThongTinTrinhDo getItem(int manv)
        {
            return db.tb_ThongTinTrinhDo.FirstOrDefault(x => x.Id == manv);
        }

        public List<tb_ThongTinTrinhDo> getList(int manv)
        {
            //List<tb_ThongTinTrinhDo> lstKT = db.tb_ThongTinTrinhDo.Where(x => x.MaNV == manv).ToList();
            //return lstKT.ToList();
            return db.tb_ThongTinTrinhDo.Where(x => x.MaNV == manv).ToList();

        }

        public tb_ThongTinTrinhDo Add(tb_ThongTinTrinhDo tbtd)
        {
            try
            {
                db.tb_ThongTinTrinhDo.Add(tbtd);
                db.SaveChanges();
                return tbtd;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_ThongTinTrinhDo Update(tb_ThongTinTrinhDo tbtd)
        {
            try
            {
                var _tbtd = db.tb_ThongTinTrinhDo.FirstOrDefault(x => x.Id == tbtd.Id);
                _tbtd.TuNam = tbtd.TuNam;
                _tbtd.DenNam = tbtd.DenNam;
                _tbtd.CheDoHoc = tbtd.CheDoHoc;
                _tbtd.LoaiDaoTao = tbtd.LoaiDaoTao;
                _tbtd.TruongDaoTao = tbtd.TruongDaoTao;
                _tbtd.NganhDaoTao = tbtd.NganhDaoTao;
                _tbtd.BangCap = tbtd.BangCap;
                _tbtd.NoiDung = tbtd.NoiDung;
                _tbtd.KetQua = tbtd.KetQua;
                _tbtd.ThoiGian = tbtd.ThoiGian;
                _tbtd.ChuyenMon = tbtd.ChuyenMon;
                _tbtd.SoBang = tbtd.SoBang;
                _tbtd.NgayCap = tbtd.NgayCap;
                _tbtd.QuocGia = tbtd.QuocGia;

                db.SaveChanges();
                return _tbtd;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}

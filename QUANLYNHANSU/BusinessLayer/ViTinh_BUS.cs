using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class ViTinh_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_ThongTinViTinh getItem(int manv)
        {
            return db.tb_ThongTinViTinh.FirstOrDefault(x => x.Id == manv);
        }

        public List<tb_ThongTinViTinh> getList(int manv)
        {
            List<tb_ThongTinViTinh> lstKT = db.tb_ThongTinViTinh.Where(x => x.MaNV == manv).ToList();
            return lstKT.ToList();
        }

        public tb_ThongTinViTinh Add(tb_ThongTinViTinh ttvt)
        {
            try
            {
                db.tb_ThongTinViTinh.Add(ttvt);
                db.SaveChanges();
                return ttvt;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_ThongTinViTinh Update(tb_ThongTinViTinh ttvt)
        {
            try
            {
                var _ttvt = db.tb_ThongTinViTinh.FirstOrDefault(x => x.Id == ttvt.Id);
                _ttvt.BangCap = ttvt.BangCap;
                _ttvt.NgayCap = ttvt.NgayCap;
                _ttvt.KinhPhi = ttvt.KinhPhi;
                _ttvt.SoBang = ttvt.SoBang;
                _ttvt.NguonKinhPhi = ttvt.NguonKinhPhi;
                _ttvt.CheDoHoc = ttvt.CheDoHoc;
                _ttvt.NoiDung = ttvt.NoiDung;
                _ttvt.TuNgay = ttvt.TuNgay;
                _ttvt.DenNgay = ttvt.DenNgay;

                db.SaveChanges();
                return _ttvt;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}

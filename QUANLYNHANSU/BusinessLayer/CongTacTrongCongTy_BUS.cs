using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class CongTacTrongCongTy_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_QuaTrinhCongTac getItem(int manv)
        {
            return db.tb_QuaTrinhCongTac.FirstOrDefault(x => x.Id == manv);
        }

        public List<tb_QuaTrinhCongTac> getList(int manv, int loai)
        {
            return db.tb_QuaTrinhCongTac.Where(x => x.MaNV == manv && x.Loai == loai).ToList();
        }

        public tb_QuaTrinhCongTac Add(tb_QuaTrinhCongTac qtct)
        {
            try
            {
                db.tb_QuaTrinhCongTac.Add(qtct);
                db.SaveChanges();
                return qtct;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_QuaTrinhCongTac Update(tb_QuaTrinhCongTac qtct)
        {
            try
            {
                var _qtct = db.tb_QuaTrinhCongTac.FirstOrDefault(x => x.Id == qtct.Id);
                _qtct.TuNgay = qtct.TuNgay;
                _qtct.DenNgay = qtct.DenNgay;
                _qtct.TenCongTy = qtct.TenCongTy;
                _qtct.TenPhongBan = qtct.TenPhongBan;
                _qtct.TenDoi = qtct.TenDoi;
                _qtct.ChucDanh = qtct.ChucDanh;
                _qtct.LyDo = qtct.LyDo;
                _qtct.DangHoatDong = qtct.DangHoatDong;
                _qtct.SoHDLD = qtct.SoHDLD;
                _qtct.LoaiHDLD = qtct.LoaiHDLD;
                _qtct.NgayQuyetDinh = qtct.NgayQuyetDinh;
                _qtct.NgayHieuLuc = qtct.NgayHieuLuc;
                _qtct.SoQD = qtct.SoQD;
                _qtct.NguoiKy = qtct.NguoiKy;
                _qtct.FileQuyetDinh = qtct.FileQuyetDinh;

                db.SaveChanges();
                return qtct;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public string MaxSoQuyetDinhj()
        {
            var _hd = db.tb_QuaTrinhCongTac.OrderByDescending(x => x.Created_Date).FirstOrDefault();
            if (_hd != null)
            {
                return _hd.SoQD;
            }
            else
            {
                return "00000";
            }
        }
    }
}

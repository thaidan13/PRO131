using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class ThongTinDoanDang_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        #region Item
        public tb_Dang_Doan getItem_Dang_Doan(int manv)
        {
            return db.tb_Dang_Doan.FirstOrDefault(x => x.Id == manv);
        }

        public tb_NguoiGTVaoDang getItem_NguoiGT(int manv)
        {
            return db.tb_NguoiGTVaoDang.FirstOrDefault(x => x.Id == manv);
        }

        public tb_BoDoi getItem_BoDoi(int manv)
        {
            return db.tb_BoDoi.FirstOrDefault(x => x.Id == manv);
        }
        #endregion

        #region ADD
        public tb_Dang_Doan Add_Dang_Doan(tb_Dang_Doan ttdd)
        {
            try
            {
                db.tb_Dang_Doan.Add(ttdd);
                db.SaveChanges();
                return ttdd;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_NguoiGTVaoDang Add_NguoiGT(tb_NguoiGTVaoDang ttnggt)
        {
            try
            {
                db.tb_NguoiGTVaoDang.Add(ttnggt);
                db.SaveChanges();
                return ttnggt;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_BoDoi Add_Bo_Doi(tb_BoDoi ttbd)
        {
            try
            {
                db.tb_BoDoi.Add(ttbd);
                db.SaveChanges();
                return ttbd;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        #endregion

        #region Update

        public tb_Dang_Doan Update_Dang_Doan(tb_Dang_Doan ttdd)
        {
            try
            {
                var _ttdd = db.tb_Dang_Doan.FirstOrDefault(x => x.Id == ttdd.Id);
                _ttdd.SoTheDoan = ttdd.SoTheDoan;
                _ttdd.NgayCapThe = ttdd.NgayCapThe;
                _ttdd.DaVaoDoan = ttdd.DaVaoDoan;
                _ttdd.DaVaoDang = ttdd.DaVaoDang;
                _ttdd.NgayVaoDangLan1 = ttdd.NgayVaoDangLan1;
                _ttdd.NgayChinhThucLan1 = ttdd.NgayChinhThucLan1;
                _ttdd.NgayVaoDangLan2 = ttdd.NgayVaoDangLan2;
                _ttdd.NgayChinhThucLan2 = ttdd.NgayChinhThucLan2;
                _ttdd.NgayVaoDoan = ttdd.NgayVaoDoan;

                db.SaveChanges();
                return _ttdd;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_NguoiGTVaoDang Update_NguoiGT(tb_NguoiGTVaoDang ttnggt)
        {
            try
            {
                var _ttnggt = db.tb_NguoiGTVaoDang.FirstOrDefault(x => x.Id == ttnggt.Id);
                _ttnggt.NguoiThuNhat = ttnggt.NguoiThuNhat;
                _ttnggt.ChucVu = ttnggt.ChucVu;
                _ttnggt.DiaChi = ttnggt.DiaChi;
                _ttnggt.NguoiThuHai = ttnggt.NguoiThuHai;
                _ttnggt.ChucVu1 = ttnggt.ChucVu1;
                _ttnggt.DiaChi2 = ttnggt.DiaChi2;

                db.SaveChanges();
                return _ttnggt;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_BoDoi Update_BoDoi(tb_BoDoi ttbd)
        {
            try
            {
                var _ttbd = db.tb_BoDoi.FirstOrDefault(x => x.Id == ttbd.Id);
                _ttbd.NgayNhapNgu = ttbd.NgayNhapNgu;
                _ttbd.NgayXuatNgu = ttbd.NgayXuatNgu;
                _ttbd.QuanHamChucVuCaoNhat = ttbd.QuanHamChucVuCaoNhat;
                _ttbd.DanhHieuDuocPhong = ttbd.DanhHieuDuocPhong;
                _ttbd.SoTruong = ttbd.SoTruong;

                db.SaveChanges();
                return _ttbd;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        #endregion

        #region Check

        public int check(int manv)
        {
            var check = db.tb_Dang_Doan.Where(x => x.MaNV == manv).Count();
            return check;
        }

        public int checkthongtinlienlac(int manv)
        {
            var check = db.tb_DienThoaiLienHe.Where(x => x.MaNV == manv).Count();
            return check;
        }

        #endregion

    }
}

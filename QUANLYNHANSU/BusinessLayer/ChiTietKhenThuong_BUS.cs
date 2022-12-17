using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class ChiTietKhenThuong_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_ChiTietKhenThuong getItem(int manv)
        {
            return db.tb_ChiTietKhenThuong.FirstOrDefault(x => x.Id == manv);
        }

        public List<tb_ChiTietKhenThuong> getList(int manv)
        {
            return db.tb_ChiTietKhenThuong.Where(x => x.MaNV == manv).ToList();
        }

        public tb_ChiTietKhenThuong Add(tb_ChiTietKhenThuong ctkt)
        {
            try
            {
                db.tb_ChiTietKhenThuong.Add(ctkt);
                db.SaveChanges();
                return ctkt;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_ChiTietKhenThuong Update(tb_ChiTietKhenThuong ctkt)
        {
            try
            {
                var _ctkt = db.tb_ChiTietKhenThuong.FirstOrDefault(x => x.Id == ctkt.Id);
                _ctkt.HinhThuc = ctkt.HinhThuc;
                _ctkt.TuNgay = ctkt.TuNgay;
                _ctkt.DenNgay = ctkt.DenNgay;
                _ctkt.MaNV = ctkt.MaNV;
                _ctkt.LyDo = ctkt.LyDo;
                _ctkt.CapQuyetDinh = ctkt.CapQuyetDinh;
                _ctkt.SoQuyetDinh = ctkt.SoQuyetDinh;
                _ctkt.NguoiKy = ctkt.NguoiKy;
                _ctkt.GhiChu = ctkt.GhiChu;
                _ctkt.DinhKem = ctkt.DinhKem;

                db.SaveChanges();
                return ctkt;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public int checkthongtinlienlac(int manv)
        {
            var check = db.tb_DienThoaiLienHe.Where(x => x.MaNV == manv).Count();
            return check;
        }
    }
}

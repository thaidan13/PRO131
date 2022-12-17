using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class ChiTietKyLuat_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_ChiTietKyLuat getItem(int manv)
        {
            return db.tb_ChiTietKyLuat.FirstOrDefault(x => x.Id == manv);
        }

        public List<tb_ChiTietKyLuat> getList(int manv)
        {
            return db.tb_ChiTietKyLuat.Where(x => x.MaNV == manv).ToList();
        }

        public tb_ChiTietKyLuat Add(tb_ChiTietKyLuat ctkl)
        {
            try
            {
                db.tb_ChiTietKyLuat.Add(ctkl);
                db.SaveChanges();
                return ctkl;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_ChiTietKyLuat Update(tb_ChiTietKyLuat ctkl)
        {
            try
            {
                var _ctkl = db.tb_ChiTietKyLuat.FirstOrDefault(x => x.Id == ctkl.Id);
                _ctkl.HinhThuc = ctkl.HinhThuc;
                _ctkl.TuNgay = ctkl.TuNgay;
                _ctkl.DenNgay = ctkl.DenNgay;
                _ctkl.MaNV = ctkl.MaNV;
                _ctkl.LyDo = ctkl.LyDo;
                _ctkl.CapQuyetDinh = ctkl.CapQuyetDinh;
                _ctkl.SoQuyetDinh = ctkl.SoQuyetDinh;
                _ctkl.NguoiKy = ctkl.NguoiKy;
                _ctkl.GhiChu = ctkl.GhiChu;
                _ctkl.DinhKem = ctkl.DinhKem;

                db.SaveChanges();
                return ctkl;
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

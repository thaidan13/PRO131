using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class QuaTrinhDaoTaoCu_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_QuaTrinhDaoTaoCu getItem(int manv)
        {
            return db.tb_QuaTrinhDaoTaoCu.FirstOrDefault(x => x.Id == manv);
        }

        public List<tb_QuaTrinhDaoTaoCu> getList(int manv)
        {
            List<tb_QuaTrinhDaoTaoCu> lstKT = db.tb_QuaTrinhDaoTaoCu.Where(x => x.MaNV == manv).ToList();
            return lstKT.ToList();
        }

        public tb_QuaTrinhDaoTaoCu Add(tb_QuaTrinhDaoTaoCu dtc)
        {
            try
            {
                db.tb_QuaTrinhDaoTaoCu.Add(dtc);
                db.SaveChanges();
                return dtc;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_QuaTrinhDaoTaoCu Update(tb_QuaTrinhDaoTaoCu dtc)
        {
            try
            {
                var _dtc = db.tb_QuaTrinhDaoTaoCu.FirstOrDefault(x => x.Id == dtc.Id);
                _dtc.KhoaHoc = dtc.KhoaHoc;
                _dtc.Truong_DonVi = dtc.Truong_DonVi;
                _dtc.HoanTat = dtc.HoanTat;
                _dtc.Bang = dtc.Bang;
                _dtc.NgayBatDau = dtc.NgayBatDau;
                _dtc.NgayKetThuc = dtc.NgayKetThuc;
                _dtc.SoQuyetDinh = dtc.SoQuyetDinh;
                _dtc.HinhThuc = dtc.HinhThuc;
                _dtc.TenBang = dtc.TenBang;
                _dtc.SoBang = dtc.SoBang;
                _dtc.DangBang = dtc.DangBang;
                _dtc.NgayCap = dtc.NgayCap;
                _dtc.HetHan = dtc.HetHan;
                _dtc.KetQua = dtc.KetQua;
                _dtc.DiaDiem = dtc.DiaDiem;
                _dtc.GhiChu = dtc.GhiChu;

                db.SaveChanges();
                return _dtc;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}

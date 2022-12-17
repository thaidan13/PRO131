using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer.DTO;

namespace BusinessLayer
{
    public class ThoiViec_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public tb_ThoiViec getItem(string soqd)
        {
            return db.tb_ThoiViec.FirstOrDefault(x => x.SoQD == soqd);
        }
        public List<tb_ThoiViec> getList()
        {
            return db.tb_ThoiViec.ToList();
        }
        public List<NhanVien_ThoiViec_DTO> getListFull()
        {
            var lstDC = db.tb_ThoiViec.ToList();
            List<NhanVien_ThoiViec_DTO> lstDTO = new List<NhanVien_ThoiViec_DTO>();
            NhanVien_ThoiViec_DTO nvDTO;
            foreach (var item in lstDC)
            {
                nvDTO = new NhanVien_ThoiViec_DTO();
                nvDTO.SoQD = item.SoQD;
                nvDTO.NgayNopDon = item.NgayNopDon;
                nvDTO.NgayNghi = item.NgayNghi;
                nvDTO.MaNV = item.MaNV;
                var nv = db.tb_NhanVien.FirstOrDefault(n => n.MaNV == item.MaNV);
                nvDTO.HoTen = nv.HoTen;
                nvDTO.LyDo = item.LyDo;
                nvDTO.GhiChu = item.GhiChu;
                nvDTO.Created_By = item.Created_By;
                nvDTO.Created_Date = item.Created_Date;
                nvDTO.Update_By = item.Update_By;
                nvDTO.Update_Date = item.Update_Date;
                nvDTO.Delete_By = item.Delete_By;
                nvDTO.Delete_Date = item.Delete_Date;
                lstDTO.Add(nvDTO);
            }
            return lstDTO;
        }
        public tb_ThoiViec Add(tb_ThoiViec tv)
        {
            try
            {
                db.tb_ThoiViec.Add(tv);
                db.SaveChanges();
                return tv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_ThoiViec Update(tb_ThoiViec tv)
        {
            try
            {
                var _tv = db.tb_ThoiViec.FirstOrDefault(x => x.SoQD == tv.SoQD);
                _tv.MaNV = tv.MaNV;
                _tv.NgayNopDon = tv.NgayNopDon;
                _tv.NgayNghi = tv.NgayNghi;
                _tv.LyDo = tv.LyDo;
                _tv.GhiChu = tv.GhiChu;
                _tv.Update_By = tv.Update_By;
                _tv.Update_Date = tv.Update_Date;
                db.SaveChanges();
                return tv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(string soqd, int iduser)
        {
            try
            {
                var _tv = db.tb_ThoiViec.FirstOrDefault(x => x.SoQD == soqd);

                _tv.Delete_By = iduser;
                _tv.Delete_Date = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public string MaxSoQuyetDinh()
        {
            var _tv = db.tb_ThoiViec.OrderByDescending(x => x.Created_Date).FirstOrDefault();
            if (_tv != null)
            {
                return _tv.SoQD;
            }
            else
                return "00000";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO;
using DataLayer;

namespace BusinessLayer
{
    public class DieuChuyen_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public tb_DieuChuyen getItem(string soqd)
        {
            return db.tb_DieuChuyen.FirstOrDefault(x => x.SoQD == soqd);
        }
        public List<tb_DieuChuyen> getList()
        {
            return db.tb_DieuChuyen.ToList();
        }
        public List<NhanVien_DieuChuyen_DTO> getListFull()
        {
            var lstDC = db.tb_DieuChuyen.ToList();
            List<NhanVien_DieuChuyen_DTO> lstDTO = new List<NhanVien_DieuChuyen_DTO>();
            NhanVien_DieuChuyen_DTO nvDTO;
            foreach (var item in lstDC)
            {
                nvDTO = new NhanVien_DieuChuyen_DTO();
                nvDTO.SoQD = item.SoQD;
                nvDTO.Ngay = item.Ngay;
                nvDTO.MaNV = item.MaNV;
                var nv = db.tb_NhanVien.FirstOrDefault(n => n.MaNV == item.MaNV);
                nvDTO.HoTen = nv.HoTen;
                nvDTO.MaPB = item.MaPB;
                var pb = db.tb_PhongBan.FirstOrDefault(p => p.IDPB == item.MaPB);
                nvDTO.TenPB = pb.TenPB;
                nvDTO.MaPB2 = item.MaPB2;
                var pb2 = db.tb_PhongBan.FirstOrDefault(p2 => p2.IDPB == item.MaPB2);
                nvDTO.TenPB2 = pb2.TenPB;
                nvDTO.LyDo = item.LyDo;
                nvDTO.GhiChu = item.GhiChu;
                nvDTO.Created_By = (int)item.Created_By;
                nvDTO.Created_Date = item.Created_Date;
                nvDTO.Update_By = item.Update_By;
                nvDTO.Update_Date = item.Update_Date;
                nvDTO.Delete_By = item.Delete_By;
                nvDTO.Delete_Date = item.Delete_Date;
                lstDTO.Add(nvDTO);
            }
            return lstDTO;
        }
        public tb_DieuChuyen Add(tb_DieuChuyen dc)
        {
            try
            {
                db.tb_DieuChuyen.Add(dc);
                db.SaveChanges();
                return dc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_DieuChuyen Update(tb_DieuChuyen dc)
        {
            try
            {
                var _dc = db.tb_DieuChuyen.FirstOrDefault(x => x.SoQD == dc.SoQD);
                _dc.MaPB2 = dc.MaPB2;
                _dc.Ngay = dc.Ngay;
                _dc.MaNV = dc.MaNV;
                _dc.LyDo = dc.LyDo;
                _dc.GhiChu = dc.GhiChu;
                _dc.Update_By = dc.Update_By;
                _dc.Update_Date = dc.Update_Date;
                db.SaveChanges();
                return dc;
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
                var _dc = db.tb_DieuChuyen.FirstOrDefault(x => x.SoQD == soqd);
                _dc.Delete_By = iduser;
                _dc.Delete_Date = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public string MaxSoQuyetDinh()
        {
            var _dc = db.tb_DieuChuyen.OrderByDescending(x => x.Created_Date).FirstOrDefault();
            if (_dc != null)
            {
                return _dc.SoQD;
            }
            else
                return "00000";
        }
    }
}

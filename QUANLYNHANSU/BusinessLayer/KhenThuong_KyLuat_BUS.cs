using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO;
using DataLayer;

namespace BusinessLayer
{
    public class KhenThuong_KyLuat_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public tb_KhenThuong_KyLuat getItem(string SoQD)
        {
            return db.tb_KhenThuong_KyLuat.FirstOrDefault(x => x.SoQuyetDinh == SoQD);
        }

        public List<KhenThuong_KyLuat_DTO> getListFull(int Loai)
        {
            List<tb_KhenThuong_KyLuat> lstKT = db.tb_KhenThuong_KyLuat.Where(x => x.Loai == Loai).ToList();
            List<KhenThuong_KyLuat_DTO> lstDTO = new List<KhenThuong_KyLuat_DTO>();
            KhenThuong_KyLuat_DTO kt;
            foreach (var item in lstKT)
            {
                kt = new KhenThuong_KyLuat_DTO();
                kt.SoQuyetDinh = item.SoQuyetDinh;
                kt.Ngay = item.Ngay;
                kt.NgayBatDau = item.NgayKetThuc;
                kt.NgayKetThuc = item.NgayKetThuc;
                kt.LyDo = item.LyDo;
                kt.NoiDung = item.NoiDung;
                kt.Loai = item.Loai;
                kt.MaNV = item.MaNV;
                var nv = db.tb_NhanVien.FirstOrDefault(n => n.MaNV == item.MaNV);
                kt.HoTen = nv.HoTen;
                kt.Created_By = item.Created_By;
                kt.Created_Date = item.Created_Date;
                kt.Update_By = item.Update_By;
                kt.Update_Date = item.Update_Date;
                kt.Delete_By = item.Delete_By;
                kt.Delete_Date = item.Delete_Date;
                lstDTO.Add(kt);
            }
            return lstDTO;
        }

        public tb_KhenThuong_KyLuat Add(tb_KhenThuong_KyLuat kt)
        {
            try
            {
                db.tb_KhenThuong_KyLuat.Add(kt);
                db.SaveChanges();
                return kt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_KhenThuong_KyLuat Update(tb_KhenThuong_KyLuat kt)
        {
            try
            {
                tb_KhenThuong_KyLuat _kt = db.tb_KhenThuong_KyLuat.FirstOrDefault(x => x.SoQuyetDinh == kt.SoQuyetDinh);
                _kt.Ngay = kt.Ngay;
                _kt.NgayBatDau = kt.NgayBatDau;
                _kt.NgayKetThuc = kt.NgayKetThuc;
                _kt.LyDo = kt.LyDo;
                _kt.NoiDung = kt.NoiDung;
                _kt.Loai = kt.Loai;
                _kt.MaNV = kt.MaNV;
                _kt.Update_By = kt.Update_By;
                _kt.Update_Date = kt.Update_Date;
                db.SaveChanges();
                return kt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public void Delete(string SoQD, int MaNV)
        {
            try
            {
                tb_KhenThuong_KyLuat _kt = db.tb_KhenThuong_KyLuat.FirstOrDefault(x => x.SoQuyetDinh == SoQD);
                _kt.Delete_By = MaNV;
                _kt.Delete_Date = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public string MaxSoQuyetDinh(int Loai)
        {
            var _kt = db.tb_KhenThuong_KyLuat.Where(x => x.Loai == Loai).OrderByDescending(x => x.Created_Date).FirstOrDefault();
            if (_kt != null)
            {
                return _kt.SoQuyetDinh;
            }
            else
            {
                return "00000";
            }
        }
    }
}

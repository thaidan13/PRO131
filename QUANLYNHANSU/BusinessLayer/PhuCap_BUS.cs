using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer.DTO;


namespace BusinessLayer
{
    public class PhuCap_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public tb_NhanVien_PhuCap getItem(int id)
        {
            return db.tb_NhanVien_PhuCap.FirstOrDefault(x => x.ID == id);
        }

        public List<tb_NhanVien_PhuCap> getList()
        {
            return db.tb_NhanVien_PhuCap.ToList();
        }

        public List<PhuCap_NhanVien_DTO> getListFull()
        {
            var lstNVPC = db.tb_NhanVien_PhuCap.ToList();
            List<PhuCap_NhanVien_DTO> lstDTO = new List<PhuCap_NhanVien_DTO>();
            PhuCap_NhanVien_DTO nvpc;
            NhanVien_BUS _nhanvien = new NhanVien_BUS();
            foreach(var item in lstNVPC)
            {
                nvpc = new PhuCap_NhanVien_DTO();
                nvpc.ID = item.ID;
                nvpc.MaNV = item.MaNV;
                var nv = _nhanvien.getItemFull(int.Parse(item.MaNV.ToString()));
                nvpc.HoTen = nv.HoTen;
                nvpc.IDPhuCap = item.IDPhuCap;
                var pc = db.tb_PhuCap.FirstOrDefault(x => x.IDPhuCap == item.IDPhuCap);
                nvpc.TenPhuCap = pc.TenPhuCap;
                nvpc.NoiDung = item.NoiDung;
                nvpc.Ngay = item.Ngay;
                nvpc.SoTien = item.SoTien;
                lstDTO.Add(nvpc);
            }
            return lstDTO;
        }

        public tb_PhuCap getItemPC(int id)
        {
            return db.tb_PhuCap.FirstOrDefault(x => x.IDPhuCap == id);
        }

        public List<tb_PhuCap> getListPC()
        {
            return db.tb_PhuCap.ToList();
        }

        public tb_NhanVien_PhuCap Add(tb_NhanVien_PhuCap pc)
        {
            try
            {
                db.tb_NhanVien_PhuCap.Add(pc);
                db.SaveChanges();
                return pc;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public tb_NhanVien_PhuCap Update(tb_NhanVien_PhuCap pc)
        {
            try
            {
                var _pc = db.tb_NhanVien_PhuCap.FirstOrDefault(x => x.ID == pc.ID);
                _pc.IDPhuCap = pc.IDPhuCap;
                _pc.MaNV = pc.MaNV;
                _pc.NoiDung = pc.NoiDung;
                _pc.SoTien = pc.SoTien;
                db.SaveChanges();
                return pc;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //public void Detele(int id, int manv)
        //{
        //    var _hd = db.tb_NhanVien_PhuCap.FirstOrDefault(x => x.ID == id);

        //    _hd.DELETED_BY = manv;
        //    _hd.DELETED_DATE = DateTime.Now;
        //    db.SaveChanges();
        //}


    }
}

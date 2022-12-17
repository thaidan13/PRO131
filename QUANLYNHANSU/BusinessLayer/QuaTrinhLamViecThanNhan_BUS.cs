using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class QuaTrinhLamViecThanNhan_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_QuaTrinhLamViecCuaThanNhan getItem(int manv)
        {
            return db.tb_QuaTrinhLamViecCuaThanNhan.FirstOrDefault(x => x.Id == manv);
        }

        public List<tb_QuaTrinhLamViecCuaThanNhan> getList(int manv)
        {
            return db.tb_QuaTrinhLamViecCuaThanNhan.Where(x => x.IdThongtinThanNhan == manv).ToList();
        }

        public tb_QuaTrinhLamViecCuaThanNhan Add(tb_QuaTrinhLamViecCuaThanNhan qtlvtn)
        {
            try
            {
                db.tb_QuaTrinhLamViecCuaThanNhan.Add(qtlvtn);
                db.SaveChanges();
                return qtlvtn;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_QuaTrinhLamViecCuaThanNhan Update(tb_QuaTrinhLamViecCuaThanNhan qtlvtn)
        {
            try
            {
                var _qtlvtn = db.tb_QuaTrinhLamViecCuaThanNhan.FirstOrDefault(x => x.Id == qtlvtn.Id);
                _qtlvtn.TuNam = qtlvtn.TuNam;
                _qtlvtn.DenNam = qtlvtn.DenNam;
                _qtlvtn.CongViec = qtlvtn.CongViec;
                _qtlvtn.DonVi = qtlvtn.DonVi;
                _qtlvtn.CapBac = qtlvtn.CapBac;
                _qtlvtn.ChucVu = qtlvtn.ChucVu;
                _qtlvtn.LoaiChucVu = qtlvtn.LoaiChucVu;
                _qtlvtn.TrongNganh = qtlvtn.TrongNganh;

                db.SaveChanges();
                return qtlvtn;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}

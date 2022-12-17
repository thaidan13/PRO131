using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class BangCong_NV_CT_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_BANGCONG_NHANVIEN_CHITIET getItem(int makycong, int manv, int ngay)
        {
            return db.tb_BANGCONG_NHANVIEN_CHITIET.FirstOrDefault(x => x.MaKyCong == makycong && x.MaNV == manv && x.NGAY.Value.Day == ngay);
        }

        public tb_BANGCONG_NHANVIEN_CHITIET Add(tb_BANGCONG_NHANVIEN_CHITIET bcct)
        {
            try
            {
                db.tb_BANGCONG_NHANVIEN_CHITIET.Add(bcct);
                db.SaveChanges();
                return bcct;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }


        public tb_BANGCONG_NHANVIEN_CHITIET Update(tb_BANGCONG_NHANVIEN_CHITIET bcct)
        {
            try
            {
                tb_BANGCONG_NHANVIEN_CHITIET bcnv = db.tb_BANGCONG_NHANVIEN_CHITIET.FirstOrDefault(x => x.MaKyCong == bcct.MaKyCong && x.MaNV == bcct.MaNV && x.NGAY == bcct.NGAY);
                bcnv.KYHIEU = bcnv.KYHIEU;
                bcnv.GIOVAO = bcct.GIOVAO;
                bcnv.GIORA = bcct.GIORA;
                bcnv.NGAYPHEP = bcct.NGAYPHEP;
                bcnv.GHICHU = bcct.GHICHU;
                bcnv.CONGCHUNHAT = bcct.CONGCHUNHAT;
                bcnv.CONGNGAYLE = bcct.CONGNGAYLE;
                bcnv.NGAYCONG = bcct.NGAYCONG;
                bcnv.UPDATED_BY = bcct.UPDATED_BY;
                bcnv.UPDATED_DATE = bcct.UPDATED_DATE;
                db.SaveChanges();
                return bcct;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public double tongNgayPhep(int makycong, int manv)
        {
            return db.tb_BANGCONG_NHANVIEN_CHITIET.Where(x => x.MaKyCong == makycong && x.MaNV == manv && x.NGAYPHEP != null).ToList().Sum(p => p.NGAYPHEP.Value);
        }
        public double tongNgayCong(int makycong, int manv)
        {
            return db.tb_BANGCONG_NHANVIEN_CHITIET.Where(x => x.MaKyCong == makycong && x.MaNV == manv && x.NGAYCONG != null).ToList().Sum(p => p.NGAYCONG.Value);
        }

        public double tongNgayVang(int makycong, int manv)
        {
            return db.tb_BANGCONG_NHANVIEN_CHITIET.Where(x => x.MaKyCong == makycong && x.MaNV == manv && x.NGAYVANG != null).ToList().Sum(p => p.NGAYVANG.Value);
        }
    }
}

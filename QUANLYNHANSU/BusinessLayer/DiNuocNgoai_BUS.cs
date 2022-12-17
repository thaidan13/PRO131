using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class DiNuocNgoai_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_NVDiNuocNgoai getItem(int manv)
        {
            return db.tb_NVDiNuocNgoai.FirstOrDefault(x => x.MaNV == manv);
        }

        public List<tb_NVDiNuocNgoai> getList(int manv)
        {
            return db.tb_NVDiNuocNgoai.ToList();
        }

        public tb_NVDiNuocNgoai Add(tb_NVDiNuocNgoai ttdnn)
        {
            try
            {
                db.tb_NVDiNuocNgoai.Add(ttdnn);
                db.SaveChanges();
                return ttdnn;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_NVDiNuocNgoai Update(tb_NVDiNuocNgoai ttdnn)
        {
            try
            {
                var _ttdnn = db.tb_NVDiNuocNgoai.FirstOrDefault(x => x.Id == ttdnn.Id);
                _ttdnn.NgayDi = ttdnn.NgayDi;
                _ttdnn.NgayVe = ttdnn.NgayVe;
                _ttdnn.ThoiGian = ttdnn.ThoiGian;
                _ttdnn.MaNV = ttdnn.MaNV;
                _ttdnn.QuocGiaDen = ttdnn.QuocGiaDen;
                _ttdnn.MucDich = ttdnn.MucDich;

                db.SaveChanges();
                return ttdnn;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public int check(int manv)
        {
            var check = db.tb_NVDiNuocNgoai.Where(x => x.MaNV == manv).Count();
            return check;
        }

        public int checkthongtinlienlac(int manv)
        {
            var check = db.tb_DienThoaiLienHe.Where(x => x.MaNV == manv).Count();
            return check;
        }

    }
}

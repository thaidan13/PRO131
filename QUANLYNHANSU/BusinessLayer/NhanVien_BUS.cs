using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO;
using DataLayer;


namespace BusinessLayer
{
    public class NhanVien_BUS
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public tb_NhanVien getItem(int id)
        {
            return db.tb_NhanVien.FirstOrDefault(x => x.MaNV == id);
        }

        public List<tb_NhanVien> getList()
        {
            return db.tb_NhanVien.ToList();
        }

        public NhanVien_DTO getItemFull(int id)
        {
            var item = db.tb_NhanVien.FirstOrDefault(x => x.MaNV == id);
            
            NhanVien_DTO nvDTO = new NhanVien_DTO();
            
                nvDTO = new NhanVien_DTO();
                nvDTO.MaNV = item.MaNV;
                nvDTO.HoTen = item.HoTen;
                nvDTO.GioiTinh = item.GioiTinh;
                nvDTO.NgaySinh = item.NgaySinh;
                nvDTO.CCCD = item.CCCD;
                nvDTO.DiaChi = item.DiaChi;
                nvDTO.DienThoai = item.DienThoai;
                nvDTO.HinhAnh = item.HinhAnh;

                nvDTO.IDBP = item.IDBP;
                var bp = db.tb_BoPhan.FirstOrDefault(b => b.IDBP == item.IDBP);
                nvDTO.TenBoPhan = bp.TenBoPhan;

                nvDTO.IDCV = item.IDCV;
                var cv = db.tb_ChucVu.FirstOrDefault(c => c.IDCV == item.IDCV);
                nvDTO.TenChucVu = cv.TenChucVu;

                nvDTO.IDPB = item.IDPB;
                var pb = db.tb_PhongBan.FirstOrDefault(d => d.IDPB == item.IDPB);
                nvDTO.TenPB = pb.TenPB;

                nvDTO.IDTD = item.IDTD;
                var td = db.tb_TrinhDo.FirstOrDefault(e => e.IDTD == item.IDTD);
                nvDTO.TenTrinhDo = td.TenTrinhDo;

                nvDTO.IDDanToc = item.IDDanToc;
                var dt = db.tb_DanToc.FirstOrDefault(f => f.IDDanToc == item.IDDanToc);
                nvDTO.TenDanToc = dt.TenDanToc;

                nvDTO.IDTonGiao = item.IDTonGiao;
                var tongiao = db.tb_TonGiao.FirstOrDefault(g => g.IDTonGiao == item.IDTonGiao);
                nvDTO.TenTonGiao = tongiao.TenTonGiao;

                

            
            return nvDTO;
        }

        public List<NhanVien_DTO> getListFull()
        {
            var lstNV = db.tb_NhanVien.ToList();
            List<NhanVien_DTO> lstNVDTO = new List<NhanVien_DTO>();
            NhanVien_DTO nvDTO;
            foreach(var item in lstNV)
            {
                nvDTO = new NhanVien_DTO();
                nvDTO.MaNV = item.MaNV;
                nvDTO.HoTen = item.HoTen;
                nvDTO.GioiTinh = item.GioiTinh;
                nvDTO.NgaySinh = item.NgaySinh;
                nvDTO.CCCD = item.CCCD;
                nvDTO.DiaChi = item.DiaChi;
                nvDTO.DienThoai = item.DienThoai;
                nvDTO.HinhAnh = item.HinhAnh;
                nvDTO.DaThoiViec = item.DaThoiViec;

                nvDTO.IDBP = item.IDBP;
                var bp = db.tb_BoPhan.FirstOrDefault(b => b.IDBP == item.IDBP);
                nvDTO.TenBoPhan = bp.TenBoPhan;

                nvDTO.IDCV = item.IDCV;
                var cv = db.tb_ChucVu.FirstOrDefault(c => c.IDCV == item.IDCV);
                nvDTO.TenChucVu = cv.TenChucVu;

                nvDTO.IDPB = item.IDPB;
                var pb = db.tb_PhongBan.FirstOrDefault(d => d.IDPB == item.IDPB);
                nvDTO.TenPB = pb.TenPB;

                nvDTO.IDTD = item.IDTD;
                var td = db.tb_TrinhDo.FirstOrDefault(e => e.IDTD == item.IDTD);
                nvDTO.TenTrinhDo = td.TenTrinhDo;

                nvDTO.IDDanToc = item.IDDanToc;
                var dt = db.tb_DanToc.FirstOrDefault(f => f.IDDanToc == item.IDDanToc);
                nvDTO.TenDanToc = dt.TenDanToc;

                nvDTO.IDTonGiao = item.IDTonGiao;
                var tongiao = db.tb_TonGiao.FirstOrDefault(g => g.IDTonGiao == item.IDTonGiao);
                nvDTO.TenTonGiao = tongiao.TenTonGiao;

                lstNVDTO.Add(nvDTO);

            }
            return lstNVDTO;
        }

        public List<NhanVien_DTO> getNhanVienFull()
        {
            List<NhanVien_DTO> lstNVDTO = new List<NhanVien_DTO>();
            NhanVien_DTO nvDTO;

            var obj = (from a in db.tb_NhanVien
                       join b in db.tb_DienThoaiLienHe
                       on a.MaNV equals b.MaNV
                       join c in db.tb_PhongBan
                       on a.IDPB equals c.IDPB
                       join d in db.tb_BoPhan
                       on a.IDBP equals d.IDBP
                       join e in db.tb_ChucVu
                       on a.IDCV equals e.IDCV
                       join f in db.tb_TrinhDo
                       on a.IDTD equals f.IDTD
                       join g in db.tb_DanToc
                       on a.IDDanToc equals g.IDDanToc
                       join h in db.tb_TonGiao
                       on a.IDTonGiao equals h.IDTonGiao
                       select new
                       {
                           manv = a.MaNV,
                           hoten = a.HoTen,
                           gioitinh = a.GioiTinh,
                           ngaysinh = a.NgaySinh,
                           dienthoai = a.DienThoai,
                           cccd = a.CCCD,
                           diachi = a.DiaChi,
                           hinhanh = a.HinhAnh,
                           phongban = c.TenPB,
                           bophan = d.TenBoPhan,
                           chucvu = e.TenChucVu,
                           trinhdo = f.TenTrinhDo,
                           dantoc = g.TenDanToc,
                           tongiao = h.TenTonGiao,
                           dathoiviec = a.DaThoiViec,
                           DienthoaiNha = b.DienThoaiNha,
                           DTDD = b.DTDD,
                           Email = b.Email
                       }).ToList();
            foreach (var item in obj)
            {
                nvDTO = new NhanVien_DTO();
                nvDTO.MaNV = item.manv;
                nvDTO.HoTen = item.hoten;
                nvDTO.GioiTinh = item.gioitinh;
                nvDTO.NgaySinh = item.ngaysinh;
                nvDTO.DienThoai = item.dienthoai;
                nvDTO.CCCD = item.cccd;
                nvDTO.DiaChi = item.diachi;
                nvDTO.HinhAnh = item.hinhanh;
                nvDTO.TenPB = item.phongban;
                nvDTO.TenBoPhan = item.bophan;
                nvDTO.TenChucVu = item.chucvu;
                nvDTO.TenTrinhDo = item.trinhdo;
                nvDTO.DaThoiViec = item.dathoiviec;
                nvDTO.TenDanToc = item.dantoc;
                nvDTO.TenTonGiao = item.tongiao;
                nvDTO.DienThoaiNha = item.DienthoaiNha;
                nvDTO.DTDD = item.DTDD;
                nvDTO.Email = item.Email;
                lstNVDTO.Add(nvDTO);
            }
            return lstNVDTO;
        }



        public tb_NhanVien Add(tb_NhanVien dt)
        {
            try
            {
                db.tb_NhanVien.Add(dt);
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_NhanVien Edit(tb_NhanVien dt)
        {
            try
            {
                var _dt = db.tb_NhanVien.FirstOrDefault(x => x.MaNV == dt.MaNV);
                _dt.HoTen = dt.HoTen;
                _dt.GioiTinh = dt.GioiTinh;
                _dt.CCCD = dt.CCCD;
                _dt.DiaChi = dt.DiaChi;
                _dt.DienThoai = dt.DienThoai;
                _dt.HinhAnh = dt.HinhAnh;
                _dt.NgaySinh = dt.NgaySinh;
                _dt.IDBP = dt.IDBP;
                _dt.IDCV = dt.IDCV;
                _dt.IDPB = dt.IDPB;
                _dt.IDTD = dt.IDTD;
                _dt.IDDanToc = dt.IDDanToc;
                _dt.IDTonGiao = dt.IDTonGiao;
                _dt.IDCongTy = dt.IDCongTy;
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var _dt = db.tb_NhanVien.FirstOrDefault(x => x.MaNV == id);
                db.tb_NhanVien.Remove(_dt);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

    }
}

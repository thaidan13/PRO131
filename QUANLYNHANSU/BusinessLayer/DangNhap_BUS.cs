using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO;
using BusinessLayer.DAL;
using System.Data;

namespace BusinessLayer
{
    public class DangNhap_BUS
    {
        DangNhap_DAL nv_DAL = new DangNhap_DAL();
        public bool NhanVienDangNhap(TaiKhoan_DTO taiKhoan)
        {
            return nv_DAL.NhanVienDangNhap(taiKhoan);
        }

        public bool NhanVienQuenMatKhau(string email)
        {
            return nv_DAL.NhanVienQuenMatKhau(email);
        }

        public bool TaoMauKhau(string email, string maukhaumoi)
        {
            return nv_DAL.TaoMatKhau(email, maukhaumoi);
        }

        public DataTable VaiTroNhanVien(string email)
        {
            return nv_DAL.VaiTroNhanVien(email);
        }
    }
}

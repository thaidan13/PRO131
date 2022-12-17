using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DAL;
using BusinessLayer.DTO;

namespace BusinessLayer.DAL
{
    public class DangNhap_DAL : DBConnect
    {
        public bool NhanVienDangNhap(TaiKhoan_DTO taiKhoan)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "dangnhap";
                cmd.Parameters.AddWithValue("email", taiKhoan.EMAIL);
                cmd.Parameters.AddWithValue("matkhau", taiKhoan.MATKHAU);
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn?.Close();
            }
            return false;
        }

        public bool NhanVienQuenMatKhau(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "quenmatkhau";
                cmd.Parameters.AddWithValue("Email", email);
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn?.Close();
            }
            return false;
        }

        public bool TaoMatKhau(string email, string matkhaumoi)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "taomatkhaumoi";
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("matkhau", matkhaumoi);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public DataTable VaiTroNhanVien(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LayVaiTroNhanVien";
                cmd.Parameters.AddWithValue("Email", email);
                //cmd.Parameters.AddWithValue("TinhTrang", tinhtrang);
                cmd.Connection = _conn;
                DataTable dtnhanvien = new DataTable();
                dtnhanvien.Load(cmd.ExecuteReader());
                return dtnhanvien;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}

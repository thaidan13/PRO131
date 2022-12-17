using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class TaiKhoan_DTO
    {
        private string Email;
	    private string MatKhau;
        private string Quyen;

        public string EMAIL
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }

        public string MATKHAU
        {
            get
            {
                return MatKhau;
            }
            set
            {
                MatKhau = value;
            }
        }

        public string QUYEN
        {
            get
            {
                return Quyen;
            }
            set
            {
                Quyen = value;
            }
        }

        public TaiKhoan_DTO() { }
    }
}

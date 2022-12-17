using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BusinessLayer;

namespace QLNHANSU
{
    public partial class frmThongTinNhanVien : DevExpress.XtraEditors.XtraForm
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public frmThongTinNhanVien()
        {
            InitializeComponent();
        }
        ThongTinCoBan_BUS _ttcb;
        ThongTinDoanDang_BUS _ttdd;

        public int _manv;
        public string _hoten;
        public string _phongban;
        public string _cccd;
        public bool _check;

        void loaddata(int mnv)
        {
            try
            {
                int manv = int.Parse(_manv.ToString());
                var item = db.tb_ThongTinNhanVien.Where(x => x.MaNV == manv).SingleOrDefault();

                txthokhaisinh.Text = item.HoKhaiSinh;
                txthothuongdung.Text = item.HoThuongDung;
                txttenkhaisinh.Text = item.TenKhaiSinh;
                txttenthuongdung.Text = item.TenThuongDUng;
                txtthecancuoc.Text = item.TheCanCuoc;
                txtsohochieu.Text = item.SoHoChieu;
                txtnoicapcmnd.Text = item.NoiCapCMND;
                txtbidanh.Text = item.BiDanh;
                dtngaycap.Value = item.NgayCap.Value;
                dtngaycaphochieu.Value = item.NgayCapHoChie.Value;
                dtngaycapthecancuoc.Value = item.NgayCapTheCC.Value;
                dtngaysinh.Value = item.NgaySinh.Value;
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
            
        }

        private void frmThongTinNhanVien_Load(object sender, EventArgs e)
        {
            //Savedata(1);
            
            _ttdd = new ThongTinDoanDang_BUS();
            _ttcb = new ThongTinCoBan_BUS();
            txtmanv.Text = _manv.ToString();
            txtphongban.Text = _phongban.ToString();
            txtcccd.Text = _cccd.ToString();
            ckgioitinh.Checked = _check;
            //hinhanh = 
            // pictureEdit1.Image = frmNhanVien.
            pictureEdit1.Image = frmNhanVien.Logo;
            //groupControl1.AppearanceCaption.BorderColor = Color.;
        }

        void Savedata()
        {
            tb_ThongTinNhanVien ttnv = new tb_ThongTinNhanVien();
            ttnv.HoKhaiSinh = txthokhaisinh.Text;
            ttnv.HoThuongDung = txthothuongdung.Text;
            ttnv.MaNV = int.Parse(txtmanv.Text);
            //ttnv.MaNV = int.Parse(manv.ToString());
            ttnv.NgaySinh = dtngaysinh.Value;
            ttnv.NgayCap = dtngaycap.Value;
            ttnv.TheCanCuoc = txtthecancuoc.Text;
            ttnv.SoHoChieu = txtsohochieu.Text;
            ttnv.TenKhaiSinh = txttenkhaisinh.Text;
            ttnv.TenThuongDUng = txttenthuongdung.Text;
            ttnv.BiDanh = txtbidanh.Text;
            ttnv.CMND = txtcccd.Text;
            ttnv.NoiCapCMND = txtnoicapcmnd.Text;
            ttnv.NgayCapTheCC = dtngaycapthecancuoc.Value;
            ttnv.NgayCapHoChie = dtngaycaphochieu.Value;
            _ttcb.Add(ttnv);
        }

        void Updatedata()
        {
            var ttnv = _ttcb.getItem(_manv);
            ttnv.HoKhaiSinh = txthokhaisinh.Text;
            ttnv.HoThuongDung = txthothuongdung.Text;
            ttnv.MaNV = int.Parse(txtmanv.Text);
            ttnv.NgaySinh = dtngaysinh.Value;
            ttnv.NgayCap = dtngaycap.Value;
            ttnv.TheCanCuoc = txtthecancuoc.Text;
            ttnv.SoHoChieu = txtsohochieu.Text;
            ttnv.TenKhaiSinh = txttenkhaisinh.Text;
            ttnv.TenThuongDUng = txttenthuongdung.Text;
            ttnv.BiDanh = txtbidanh.Text;
            ttnv.CMND = txtcccd.Text;
            ttnv.NoiCapCMND = txtnoicapcmnd.Text;
            ttnv.NgayCapTheCC = dtngaycapthecancuoc.Value;
            ttnv.NgayCapHoChie = dtngaycaphochieu.Value;
            _ttcb.Update(ttnv);
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (_ttcb.check(_manv) >= 1)
            {
                MessageBox.Show("Đã có dữ liệu!", "Thông Báo");
                btnluu.Enabled = false;
                return;
            }
            Savedata();
            MessageBox.Show("Đã cập nhật thành công!", "Thông Báo");
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            Updatedata();
            MessageBox.Show("Đã cập nhật thành công!", "Thông Báo");
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            if (_ttcb.check(_manv) < 1)
            {
                MessageBox.Show("Chưa có dữ liệu!", "Thông Báo");
                return;
            }

            int id = int.Parse(txtmanv.Text);
            loaddata(id);
        }
    }
}
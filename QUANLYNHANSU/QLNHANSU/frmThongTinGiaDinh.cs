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
    public partial class frmThongTinGiaDinh : DevExpress.XtraEditors.XtraForm
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public frmThongTinGiaDinh()
        {
            InitializeComponent();
        }

        public static Image Logo = null;
        ThongTinGiaDinh_BUS _ttgd;

        int _Id;
        public int _manv;
        public string _hoten;
        public string _phongban;
        public string _email;
        public string _dienthoainha;
        public string _dtdd;

        void loaddata(int mnv)
        {
            try
            {
                int manv = int.Parse(_manv.ToString());
                var item = db.tb_DienThoaiLienHe.Where(x => x.MaNV == manv).SingleOrDefault();

                if (_ttgd.checkthongtinlienlac(manv) < 1)
                {
                    MessageBox.Show("Thông liên hệ chưa đầy đủ, vui lòng nhập đầy đủ!", "Thông báo");
                    return;
                }
                lbdienthoai.Text = item.DienThoaiNha;
                lbdtdd.Text = item.DTDD;
                lbemail.Text = item.Email;
            }
            //catch (Exception ex)
            //{

            //    throw new Exception("Lỗi: " + ex.Message);
            //}
            catch
            {
                MessageBox.Show("Chưa có thông tin đầy đủ", "Thông báo");
            }
        }

        void loaddataNV()
        {
            //var obj = (from a in db.tb_NVDiNuocNgoai
            //           where a.MaNV == _manv
            //           select a).ToList();

            var obj2 = _ttgd.getList(_manv);

            gcThongTin.DataSource = obj2;
            //gvThongTin.OptionsBehavior.Editable = false;
        }

        void Savedata()
        {
            tb_ThongTinGiaDinh ttgd = new tb_ThongTinGiaDinh();

            ttgd.MaNV = int.Parse(_manv.ToString());
            ttgd.HoTen = txthoten.Text;
            ttgd.QuanHe = cbquanhe.Text;
            ttgd.NgaySinh = dtngaysinh.Value;
            ttgd.DiaChi = txtdiachi.Text;
            ttgd.Phuong = txtphuong.Text;
            ttgd.QuanHuyen = txtquanhuyen.Text;
            ttgd.TinhThanh = cbtinhthanh.Text;
            ttgd.ConSong = cbconsong.Checked;

            _ttgd.Add(ttgd);
            loaddataNV();
        }

        void Updatedata()
        {
            _Id = int.Parse(gvThongTin.GetFocusedRowCellValue("Id").ToString());
            var ttgd = _ttgd.getItem(_Id);
            ttgd.QuanHe = cbquanhe.Text;
            ttgd.NgaySinh = dtngaysinh.Value;
            ttgd.DiaChi = txtdiachi.Text;
            ttgd.Phuong = txtphuong.Text;
            ttgd.QuanHuyen = txtquanhuyen.Text;
            ttgd.TinhThanh = cbtinhthanh.Text;
            ttgd.ConSong = cbconsong.Checked;

            _ttgd.Update(ttgd);
            loaddataNV();
        }

        private void frmThongTinGiaDinh_Load(object sender, EventArgs e)
        {
            btnThem.Click += BtnThem_Click;
            _ttgd = new ThongTinGiaDinh_BUS();

            pictureEdit1.Image = frmNhanVien.Logo;
            lbmanv.Text = _manv.ToString();
            lbhoten.Text = _hoten.ToString();
            lbphongban.Text = _phongban.ToString();

            loaddata(_manv);
            loaddataNV();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            frmTTQuaTrinhLamViecNT frmthannhan = new frmTTQuaTrinhLamViecNT();
            Logo = pictureEdit1.Image;

            frmthannhan._IdThanNhan = int.Parse(gvThongTin.GetFocusedRowCellValue("Id").ToString());
            frmthannhan._thannhan = gvThongTin.GetFocusedRowCellValue("HoTen").ToString();
            frmthannhan._quanhe = gvThongTin.GetFocusedRowCellValue("QuanHe").ToString();

            frmthannhan._manv = _manv;
            frmthannhan._hoten = lbhoten.Text;
            frmthannhan._phongban = lbphongban.Text;

            frmthannhan._email = lbemail.Text;
            frmthannhan._dtdd = lbdtdd.Text;
            frmthannhan._dienthoainha = lbdienthoai.Text;


            frmthannhan.ShowDialog();


        }

        private void lbmorong_Click(object sender, EventArgs e)
        {
            gcThongTin.Visible = false;
            groupControl1.Visible = true;
            label20.Visible = true;
            lbmorong.Visible = false;
        }

        private void label20_Click(object sender, EventArgs e)
        {
            groupControl1.Visible = false;
            label20.Visible = false;
            lbmorong.Visible = true;
            gcThongTin.Visible = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            Savedata();
            MessageBox.Show("Đã cập nhật thành công!", "Thông Báo");
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            Updatedata();
            MessageBox.Show("Đã cập nhật thành công!", "Thông Báo");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gcThongTin_Click(object sender, EventArgs e)
        {
            if (gvThongTin.RowCount > 0)
            {
                _Id = int.Parse(gvThongTin.GetFocusedRowCellValue("Id").ToString());
                var tt = _ttgd.getItem(_Id);

                txthoten.Text = tt.HoTen;
                cbquanhe.Text = tt.QuanHe;
                dtngaysinh.Value = tt.NgaySinh.Value;
                txtdiachi.Text = tt.DiaChi;
                txtphuong.Text = tt.Phuong;
                txtquanhuyen.Text = tt.QuanHuyen;
                cbtinhthanh.Text = tt.TinhThanh;
                cbconsong.Checked = tt.ConSong.Value;
            }
        }
    }
}
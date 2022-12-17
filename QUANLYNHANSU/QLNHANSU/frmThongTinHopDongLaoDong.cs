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
using System.IO;

namespace QLNHANSU
{
    public partial class frmThongTinHopDongLaoDong : DevExpress.XtraEditors.XtraForm
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public frmThongTinHopDongLaoDong()
        {
            InitializeComponent();
        }

        ThongTinHopDong_BUS _tthdld;
        int _Id;
        public int _manv;
        public string _hoten;
        public string _phongban;
        public string _email;
        public string _dienthoainha;
        public string _dtdd;

        void reset()
        {
            txtsohdld.Text = string.Empty;
            cbloaihopdong.Text = string.Empty;
            cbthoihan.Text = string.Empty;
            cbchucdanh.Text = string.Empty;
            cbbacluong.Text = string.Empty;
            sphesoluong.Text = string.Empty;
            dtngayky.Value = DateTime.Now;
            txtnguoiky.Text = string.Empty;
            dtngaythuviec.Value = DateTime.Now;
            dtngaychinhtuc.Value = DateTime.Now;
            dtngayhethan.Value = DateTime.Now;
            dtngaygiahan.Value = DateTime.Now;
            lbfilequyetdinh.Text = string.Empty;
            lbfilehdld.Text = string.Empty;

        }

        void loaddata(int mnv)
        {
            try
            {
                int manv = int.Parse(_manv.ToString());
                var item = db.tb_DienThoaiLienHe.Where(x => x.MaNV == manv).SingleOrDefault();

                if (_tthdld.checkthongtinlienlac(manv) < 1)
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

            var obj2 = _tthdld.getList(_manv);

            gcThongTin.DataSource = obj2;
            gvThongTin.OptionsBehavior.Editable = false;
        }

        void Savedata()
        {
            tb_ThongTinHopDongLaoDong tthdld = new tb_ThongTinHopDongLaoDong();

            var maxSoHD = _tthdld.MaxSoHopDong();
            tthdld.MaNV = int.Parse(_manv.ToString());
            int so = int.Parse(maxSoHD.Substring(0, 5)) + 1;
            tthdld.SoHDLD = so.ToString("00000") + @"/" + DateTime.Now.Year.ToString() + @"/HĐLĐ";
            tthdld.LoaiHopDong = cbloaihopdong.Text;
            tthdld.ThoiHan = cbthoihan.Text;
            tthdld.ChucDanh = cbchucdanh.Text;
            tthdld.BacLuong = double.Parse(cbbacluong.Text);
            tthdld.HeSoLuong = double.Parse(sphesoluong.EditValue.ToString());
            tthdld.NgayKy = dtngayky.Value;
            tthdld.NguoiKy = txtnguoiky.Text;
            tthdld.NgayThuViec = dtngaythuviec.Value;
            tthdld.NgayChinhThuc = dtngaychinhtuc.Value;
            tthdld.NgayHetHan = dtngayhethan.Value;
            tthdld.NgayGiaHan = dtngaygiahan.Value;
            tthdld.FileQuyetDinh = lbfilequyetdinh.Text;
            tthdld.FileHDLD = lbfilehdld.Text;
            tthdld.CREATED_DATE = DateTime.Now;

            _tthdld.Add(tthdld);
            loaddataNV();
        }

        void Updatedata()
        {
            _Id = int.Parse(gvThongTin.GetFocusedRowCellValue("Id").ToString());
            var tthdld = _tthdld.getItem(_Id);
            tthdld.LoaiHopDong = cbloaihopdong.Text;
            tthdld.ThoiHan = cbthoihan.Text;
            tthdld.ChucDanh = cbchucdanh.Text;
            tthdld.BacLuong = double.Parse(cbbacluong.Text);
            tthdld.HeSoLuong = double.Parse(sphesoluong.EditValue.ToString());
            tthdld.NgayKy = dtngayky.Value;
            tthdld.NguoiKy = txtnguoiky.Text;
            tthdld.NgayThuViec = dtngaythuviec.Value;
            tthdld.NgayChinhThuc = dtngaychinhtuc.Value;
            tthdld.NgayHetHan = dtngayhethan.Value;
            tthdld.NgayGiaHan = dtngaygiahan.Value;
            tthdld.FileQuyetDinh = lbfilequyetdinh.Text;
            tthdld.FileHDLD = lbfilehdld.Text;

            _tthdld.Update(tthdld);
            loaddataNV();
        }

        private void frmThongTinHopDongLaoDong_Load(object sender, EventArgs e)
        {
            _tthdld = new ThongTinHopDong_BUS();
            pictureEdit1.Image = frmNhanVien.Logo;
            lbmanv.Text = _manv.ToString();
            lbhoten.Text = _hoten.ToString();
            lbphongban.Text = _phongban.ToString();

            loaddata(_manv);
            loaddataNV();
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

        private void lbthem_Click(object sender, EventArgs e)
        {
            Savedata();
            reset();
            MessageBox.Show("Đã cập nhật thành công!", "Thông Báo");
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            Updatedata();
            MessageBox.Show("Đã cập nhật thành công!", "Thông Báo");
        }

        private void lbtrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FileQuyetDinh_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lbfilequyetdinh.Text = Path.GetFileName(openFileDialog1.FileName);
                lbfilequyetdinh.Text = Path.GetFullPath(openFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 file!", "Thông báo");
            }
        }

        private void FileHDLD_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lbfilehdld.Text = Path.GetFileName(openFileDialog1.FileName);
                lbfilehdld.Text = Path.GetFullPath(openFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 file!", "Thông báo");
            }
        }

        private void gcThongTin_Click(object sender, EventArgs e)
        {
            if (gvThongTin.RowCount > 0)
            {
                _Id = int.Parse(gvThongTin.GetFocusedRowCellValue("Id").ToString());
                var tt = _tthdld.getItem(_Id);

                txtsohdld.Text = tt.SoHDLD;
                cbloaihopdong.Text = tt.LoaiHopDong;
                cbthoihan.Text = tt.ThoiHan;
                cbchucdanh.Text = tt.ChucDanh;
                cbbacluong.Text = tt.BacLuong.ToString();
                sphesoluong.Text = tt.HeSoLuong.ToString();
                dtngayky.Value = tt.NgayKy.Value;
                txtnguoiky.Text = tt.NguoiKy;
                dtngaythuviec.Value = tt.NgayThuViec.Value;
                dtngaychinhtuc.Value = tt.NgayChinhThuc.Value;
                dtngayhethan.Value = tt.NgayHetHan.Value;
                dtngaygiahan.Value = tt.NgayGiaHan.Value;
                lbfilequyetdinh.Text = tt.FileQuyetDinh;
                lbfilehdld.Text = tt.FileHDLD;
            }
        }
    }
}
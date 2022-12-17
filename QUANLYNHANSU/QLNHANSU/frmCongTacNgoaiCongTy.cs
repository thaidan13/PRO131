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
    public partial class frmCongTacNgoaiCongTy : DevExpress.XtraEditors.XtraUserControl
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public frmCongTacNgoaiCongTy()
        {
            InitializeComponent();
        }

        CongTacTrongCongTy_BUS _cttct;
        ThongTinHopDong_BUS _tthd;
        int _Id;
        public int _manv;

        void loadshdld()
        {
            slksohdld.Properties.DataSource = _tthd.getListhopdong();
            slksohdld.Properties.ValueMember = "SoHDLD";
            slksohdld.Properties.DisplayMember = "Id";
            slksohdld.Properties.DisplayMember = "SoHDLD";
        }

        public void loaddataNV()
        {
            //var obj = (from a in db.tb_NVDiNuocNgoai
            //           where a.MaNV == _manv
            //           select a).ToList();

            var obj2 = _cttct.getList(_manv, 2);

            gcThongTin.DataSource = obj2;
            gvThongTin.OptionsBehavior.Editable = false;
        }

        void Savedata()
        {
            tb_QuaTrinhCongTac qtct = new tb_QuaTrinhCongTac();

            var maxSoHD = _cttct.MaxSoQuyetDinhj();
            qtct.MaNV = int.Parse(_manv.ToString());
            int so = int.Parse(maxSoHD.Substring(0, 5)) + 1;
            qtct.SoQD = so.ToString("00000") + @"/" + DateTime.Now.Year.ToString() + @"/CTNCT";
            qtct.TuNgay = dttungay.Value;
            qtct.DenNgay = dtdenngay.Value;
            qtct.ChucDanh = cbchucdanh.Text;
            qtct.TenCongTy = txttencongty.Text;
            qtct.TenPhongBan = txtphongban.Text;
            qtct.TenDoi = txttendoi.Text;
            qtct.NguoiKy = txtnguoiky.Text;
            qtct.LyDo = cblydo.Text;
            qtct.DangHoatDong = ckdanghoatdong.Checked;
            qtct.SoHDLD = slksohdld.EditValue.ToString();
            qtct.LoaiHDLD = txtloaihopdong.Text;
            qtct.FileQuyetDinh = lbfile.Text;
            qtct.NgayQuyetDinh = dtngayquyetdinh.Value;
            qtct.Created_Date = DateTime.Now;
            qtct.NgayHieuLuc = dtngayhieuluc.Value;
            qtct.Loai = 2;

            _cttct.Add(qtct);
            loaddataNV();
        }

        void Updatedata()
        {
            _Id = int.Parse(gvThongTin.GetFocusedRowCellValue("Id").ToString());
            var qtct = _cttct.getItem(_Id);
            qtct.TuNgay = dttungay.Value;
            qtct.DenNgay = dtdenngay.Value;
            qtct.ChucDanh = cbchucdanh.Text;
            qtct.TenCongTy = txttencongty.Text;
            qtct.TenPhongBan = txtphongban.Text;
            qtct.TenDoi = txttendoi.Text;
            qtct.NguoiKy = txtnguoiky.Text;
            qtct.LyDo = cblydo.Text;
            qtct.DangHoatDong = ckdanghoatdong.Checked;
            qtct.SoHDLD = slksohdld.EditValue.ToString();
            qtct.LoaiHDLD = txtloaihopdong.Text;
            qtct.FileQuyetDinh = lbfile.Text;
            qtct.NgayQuyetDinh = dtngayquyetdinh.Value;
            //qtct.Created_Date = DateTime.Now;
            qtct.NgayHieuLuc = dtngayhieuluc.Value;

            _cttct.Update(qtct);
            loaddataNV();
        }

        private void frmCongTacNgoaiCongTy_Load(object sender, EventArgs e)
        {
            _cttct = new CongTacTrongCongTy_BUS();
            _tthd = new ThongTinHopDong_BUS();
            loadshdld();
            loaddataNV();
        }

        private void lbthem_Click(object sender, EventArgs e)
        {
            Savedata();
            //reset();
            MessageBox.Show("Đã cập nhật thành công!", "Thông Báo");
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            Updatedata();
            MessageBox.Show("Đã cập nhật thành công!", "Thông Báo");
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lbfile.Text = Path.GetFileName(openFileDialog1.FileName);
                lbfile.Text = Path.GetFullPath(openFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 file!", "Thông báo");
            }
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            loaddataNV();
        }

        private void gcThongTin_Click(object sender, EventArgs e)
        {
            if (gvThongTin.RowCount > 0)
            {
                //loaddataNV();
                _Id = int.Parse(gvThongTin.GetFocusedRowCellValue("Id").ToString());
                var tt = _cttct.getItem(_Id);

                txtsoquyetdinh.Text = tt.SoQD;
                dttungay.Value = tt.TuNgay.Value;
                dtdenngay.Value = tt.DenNgay.Value;
                cbchucdanh.Text = tt.ChucDanh;
                txttencongty.Text = tt.TenCongTy;
                txtphongban.Text = tt.TenPhongBan;
                txttendoi.Text = tt.TenDoi;
                txtnguoiky.Text = tt.NguoiKy;
                cblydo.Text = tt.LyDo;
                ckdanghoatdong.Checked = tt.DangHoatDong.Value;
                slksohdld.EditValue = tt.SoHDLD;
                txtloaihopdong.Text = tt.LoaiHDLD;
                lbfile.Text = tt.FileQuyetDinh;
                dtngayquyetdinh.Value = tt.NgayQuyetDinh.Value;
                //qtct.Created_Date = DateTime.Now;
                dtngayhieuluc.Value = tt.NgayHieuLuc.Value;
            }
        }
    }
}

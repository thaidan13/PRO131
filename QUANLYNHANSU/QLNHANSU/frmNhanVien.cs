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
using QLNHANSU.Reports;
using BusinessLayer.DTO;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;

namespace QLNHANSU
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        

        public static Image Logo = null;
        NhanVien_BUS _nhanvien;
        DanToc_BUS _dantoc;
        TrinhDo_BUS _trinhdo;
        ChucVu_BUS _chucvu;
        TonGiao_BUS _tongiao;
        PhongBan_BUS _phongban;
        BoPhan_BUS _bophan;
        bool _Them;
        int _id;
        List<NhanVien_DTO> _lstNVDTO;

        InSoYeuLyLich_BUS _in;



        #region METHODS
        void _ShowHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnIn.Enabled = kt;
            txthoten.Enabled = !kt;
            txtcccd.Enabled = !kt;
            txtdienthoai.Enabled = !kt;
            txtdiachi.Enabled = !kt;
            checkgioitinh.Checked = !kt;

            cbbophan.Enabled = !kt;
            cbphongban.Enabled = !kt;
            cbtrinhdo.Enabled = !kt;
            cbchucvu.Enabled = !kt;
            cbdantoc.Enabled = !kt;
            cbtongiao.Enabled = !kt;
            btnhinhanh.Enabled = !kt;
            dtngaysinh.Enabled = !kt;
        }

        void _reset()
        {
            txthoten.Text = string.Empty;
            txtcccd.Text = string.Empty;
            txtdienthoai.Text = string.Empty;
            txtdiachi.Text = string.Empty;
            checkgioitinh.Checked = false;
        }

        void loadcombox()
        {
            cbbophan.DataSource = _bophan.getList();
            cbbophan.DisplayMember = "TenBoPhan";
            cbbophan.ValueMember = "IDBP";

            cbphongban.DataSource = _phongban.getList();
            cbphongban.DisplayMember = "TenPB";
            cbphongban.ValueMember = "IDPB";

            cbtrinhdo.DataSource = _trinhdo.getList();
            cbtrinhdo.DisplayMember = "TenTrinhDo";
            cbtrinhdo.ValueMember = "IDTD";

            cbchucvu.DataSource = _chucvu.getList();
            cbchucvu.DisplayMember = "TenChucVu";
            cbchucvu.ValueMember = "IDCV";

            cbdantoc.DataSource = _dantoc.getList();
            cbdantoc.DisplayMember = "TenDanToc";
            cbdantoc.ValueMember = "IDDanToc";

            cbtongiao.DataSource = _tongiao.getList();
            cbtongiao.DisplayMember = "TenTonGiao";
            cbtongiao.ValueMember = "IDTonGiao";

        }

        void loaddata()
        {
            gcDanhSach.DataSource = _nhanvien.getListFull();
            gridControl1.DataSource = _nhanvien.getListFull();
            //gcDanhSach.DataSource = _nhanvien.getNhanVienFull();
            gvDanhSach.OptionsBehavior.Editable = false;
            _lstNVDTO = _nhanvien.getListFull();
        }

        public byte[] ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                return imageBytes;
            }
        }

        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        void SaveData()
        {
            if (_Them)
            {
                tb_NhanVien dt = new tb_NhanVien();
                dt.HoTen = txthoten.Text;
                dt.GioiTinh = checkgioitinh.Checked;
                dt.NgaySinh = dtngaysinh.Value;
                dt.DienThoai = txtdienthoai.Text;
                dt.CCCD = txtcccd.Text;
                dt.DiaChi = txtdiachi.Text;
                dt.DaThoiViec = ckhoatdong.Checked;
                dt.HinhAnh = ImageToBase64(pichinhanh.Image, pichinhanh.Image.RawFormat);
                dt.IDBP = int.Parse(cbbophan.SelectedValue.ToString());
                dt.IDPB = int.Parse(cbphongban.SelectedValue.ToString());
                dt.IDTD = int.Parse(cbtrinhdo.SelectedValue.ToString());
                dt.IDCV = int.Parse(cbchucvu.SelectedValue.ToString());
                dt.IDDanToc = int.Parse(cbdantoc.SelectedValue.ToString());
                dt.IDTonGiao = int.Parse(cbtongiao.SelectedValue.ToString());
                dt.IDCongTy = 1;
                _nhanvien.Add(dt);
            }
            else
            {
                var dt = _nhanvien.getItem(_id);
                dt.HoTen = txthoten.Text;
                dt.GioiTinh = checkgioitinh.Checked;
                dt.NgaySinh = dtngaysinh.Value;
                dt.DienThoai = txtdienthoai.Text;
                dt.CCCD = txtcccd.Text;
                dt.DaThoiViec = ckhoatdong.Checked;
                dt.DiaChi = txtdiachi.Text;
                dt.HinhAnh = ImageToBase64(pichinhanh.Image, pichinhanh.Image.RawFormat);
                dt.IDBP = int.Parse(cbbophan.SelectedValue.ToString());
                dt.IDPB = int.Parse(cbphongban.SelectedValue.ToString());
                dt.IDTD = int.Parse(cbtrinhdo.SelectedValue.ToString());
                dt.IDCV = int.Parse(cbchucvu.SelectedValue.ToString());
                dt.IDDanToc = int.Parse(cbdantoc.SelectedValue.ToString());
                dt.IDTonGiao = int.Parse(cbtongiao.SelectedValue.ToString());
                dt.IDCongTy = 1;
                _nhanvien.Edit(dt);
            }
        }
        #endregion


        #region EVEN
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //txtdantoc.Text = String.Empty;
            splitContainer1.Panel1Collapsed = false;
            splitContainer1.Panel2.Enabled = false;
            _reset();
            _ShowHide(false);
            _Them = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainer1.Panel1Collapsed = false;
            _Them = false;
            _ShowHide(false);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xoá không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _nhanvien.Delete(_id);
                loaddata();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
            splitContainer1.Panel2.Enabled = true;
            SplashScreenManager.ShowForm(typeof(frmWaiting), true, true);
            SaveData();
            loaddata();
            SplashScreenManager.CloseForm();
            
            _Them = false;
            _ShowHide(true);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
            splitContainer1.Panel2.Enabled = true;
            _Them = false;
            _ShowHide(true);
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rptDanhSachNhanVien rpt = new rptDanhSachNhanVien(_lstNVDTO);
            rpt.ShowRibbonPreview();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            _in = new InSoYeuLyLich_BUS();
            _Them = false;
            _nhanvien = new NhanVien_BUS();
            _dantoc = new DanToc_BUS();
            _trinhdo = new TrinhDo_BUS();
            _chucvu = new ChucVu_BUS();
            _tongiao = new TonGiao_BUS();
            _phongban = new PhongBan_BUS();
            _bophan = new BoPhan_BUS();
            _ShowHide(true);
            loadcombox();
            loaddata();
            splitContainer1.Panel1Collapsed = true;
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            if(gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MaNV").ToString());
                var dt = _nhanvien.getItem(_id);
                txthoten.Text = dt.HoTen;
                checkgioitinh.Checked = dt.GioiTinh.Value;
                dtngaysinh.Value = dt.NgaySinh.Value;
                txtdienthoai.Text = dt.DienThoai;
                txtcccd.Text = dt.CCCD;
                txtdiachi.Text = dt.DiaChi;
                pichinhanh.Image = Base64ToImage(dt.HinhAnh);
                cbbophan.SelectedValue = dt.IDBP;
                cbphongban.SelectedValue = dt.IDPB;
                cbtrinhdo.SelectedValue = dt.IDTD;
                cbchucvu.SelectedValue = dt.IDCV;
                cbdantoc.SelectedValue = dt.IDDanToc;
                cbtongiao.SelectedValue = dt.IDTonGiao;
                ckhoatdong.Checked = dt.DaThoiViec.Value;
                //dt.IDCongTy = 1;
            }
        }

        private void btnhinhanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Picture file (.png, .jpg)|*.png;*.jpg";
            openFileDialog.Title = "Chọn hình ảnh";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pichinhanh.Image = Image.FromFile(openFileDialog.FileName);
                pichinhanh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        #endregion

        private void thôngTinCơBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logo = pichinhanh.Image;

            frmThongTinNhanVien frmThongTinNhanVien = new frmThongTinNhanVien();
            frmThongTinNhanVien._manv = _id;
            frmThongTinNhanVien._hoten = txthoten.Text;
            frmThongTinNhanVien._phongban = cbphongban.Text;
            frmThongTinNhanVien._cccd = txtcccd.Text;
            frmThongTinNhanVien._check = checkgioitinh.Checked;

            frmThongTinNhanVien.ShowDialog();
        }

        private void quốcTịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logo = pichinhanh.Image;

            frmQuocTich_TonGiao frmQuocTich_TonGiao = new frmQuocTich_TonGiao();
            frmQuocTich_TonGiao._manv = _id;
            frmQuocTich_TonGiao._tongiao = cbtongiao.Text;
            frmQuocTich_TonGiao._dantoc = cbdantoc.Text;
            frmQuocTich_TonGiao._check = checkgioitinh.Checked;
            frmQuocTich_TonGiao._ckhoatdong = ckhoatdong.Checked;
            frmQuocTich_TonGiao.ShowDialog();
        }

        private void quêQuánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logo = pichinhanh.Image;

            frmQueQuan frmquequan = new frmQueQuan();

            frmquequan._manv = _id;
            frmquequan._check = checkgioitinh.Checked;
            frmquequan.ShowDialog();
        }

        private void thôngTinLiênLạcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logo = pichinhanh.Image;

            frmDienThoai_LienLac frmlienhe = new frmDienThoai_LienLac();

            frmlienhe._manv = _id;
            frmlienhe._check = checkgioitinh.Checked;
            frmlienhe.ShowDialog();
        }

        private void thườngTrúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logo = pichinhanh.Image;

            frmThuongTru frmthuongtru = new frmThuongTru();

            frmthuongtru._manv = _id;
            frmthuongtru._check = checkgioitinh.Checked;
            frmthuongtru.ShowDialog();
        }

        private void tạmTrúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logo = pichinhanh.Image;

            frmTamTru frmtamtru = new frmTamTru();

            frmtamtru._manv = _id;
            frmtamtru._check = checkgioitinh.Checked;
            frmtamtru.ShowDialog();
        }

        private void thôngTinTrìnhĐộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logo = pichinhanh.Image;

            frmQuaTrinhDaoTao frmtrinhdo = new frmQuaTrinhDaoTao();
            //frmQuaTrinhDaoTao frmqua = new frmQuaTrinhDaoTao();

            frmtrinhdo._manv = _id;
            frmtrinhdo._hoten = txthoten.Text;
            frmtrinhdo._phongban = cbphongban.Text;
            frmtrinhdo._dtdd = txtdienthoai.Text;
            
            
            frmtrinhdo.ShowDialog();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if (tileView1.RowCount > 0)
            {
                _id = int.Parse(tileView1.GetFocusedRowCellValue("MaNV").ToString());
                var dt = _nhanvien.getItem(_id);
                txthoten.Text = dt.HoTen;
                checkgioitinh.Checked = dt.GioiTinh.Value;
                dtngaysinh.Value = dt.NgaySinh.Value;
                txtdienthoai.Text = dt.DienThoai;
                txtcccd.Text = dt.CCCD;
                txtdiachi.Text = dt.DiaChi;
                pichinhanh.Image = Base64ToImage(dt.HinhAnh);
                cbbophan.SelectedValue = dt.IDBP;
                cbphongban.SelectedValue = dt.IDPB;
                cbtrinhdo.SelectedValue = dt.IDTD;
                cbchucvu.SelectedValue = dt.IDCV;
                cbdantoc.SelectedValue = dt.IDDanToc;
                cbtongiao.SelectedValue = dt.IDTonGiao;
                ckhoatdong.Checked = dt.DaThoiViec.Value;
                //dt.IDCongTy = 1;
            }
        }

        private void thôngTinĐoànĐảngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logo = pichinhanh.Image;

            frmThongTinDoanDang frmdoandang = new frmThongTinDoanDang();

            frmdoandang._manv = _id;
            frmdoandang._hoten = txthoten.Text;
            frmdoandang._phongban = cbphongban.Text;
            frmdoandang._dtdd = txtdienthoai.Text;

            frmdoandang.ShowDialog();
        }

        private void điNướcNgoàiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logo = pichinhanh.Image;

            frmDiNuocNgoai frmnuocngoai = new frmDiNuocNgoai();

            frmnuocngoai._manv = _id;
            frmnuocngoai._hoten = txthoten.Text;
            frmnuocngoai._phongban = cbphongban.Text;

            frmnuocngoai.ShowDialog();
        }

        private void QuaTrinhDaoTaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logo = pichinhanh.Image;

            frmDaoTaoQuaTrinh frmquatrinh = new frmDaoTaoQuaTrinh();

            frmquatrinh._manv = _id;
            frmquatrinh._hoten = txthoten.Text;
            frmquatrinh._phongban = cbphongban.Text;

            frmquatrinh.ShowDialog();
        }

        private void KhenThuongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logo = pichinhanh.Image;

            frmThongTinKhenThuong frmkhenthuong = new frmThongTinKhenThuong();

            frmkhenthuong._manv = _id;
            frmkhenthuong._hoten = txthoten.Text;
            frmkhenthuong._phongban = cbphongban.Text;

            frmkhenthuong.ShowDialog();
        }

        private void KyLuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logo = pichinhanh.Image;

            frmThongTinKyLuat frmkyluat = new frmThongTinKyLuat();

            frmkyluat._manv = _id;
            frmkyluat._hoten = txthoten.Text;
            frmkyluat._phongban = cbphongban.Text;

            frmkyluat.ShowDialog();
        }

        private void hồSơTuyểnDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logo = pichinhanh.Image;

            frmHoSoTuyenDung frmhoso = new frmHoSoTuyenDung();

            frmhoso._manv = _id;
            frmhoso._hoten = txthoten.Text;
            frmhoso._phongban = cbphongban.Text;

            frmhoso.ShowDialog();
        }

        private void hồSơLiênQuanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logo = pichinhanh.Image;

            frmHoSoLienQuan frmhoso = new frmHoSoLienQuan();

            frmhoso._manv = _id;
            frmhoso._hoten = txthoten.Text;
            frmhoso._phongban = cbphongban.Text;

            frmhoso.ShowDialog();
        }

        private void thôngTinGiaĐìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logo = pichinhanh.Image;

            frmThongTinGiaDinh frmgiadinh = new frmThongTinGiaDinh();

            frmgiadinh._manv = _id;
            frmgiadinh._hoten = txthoten.Text;
            frmgiadinh._phongban = cbphongban.Text;

            frmgiadinh.ShowDialog();
        }

        private void thôngTinLúcNhỏToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logo = pichinhanh.Image;

            frmLichSuBanThanNhanVien frmlichsu = new frmLichSuBanThanNhanVien();

            frmlichsu._manv = _id;
            frmlichsu._hoten = txthoten.Text;
            frmlichsu._phongban = cbphongban.Text;

            frmlichsu.ShowDialog();
        }

        private void hợpĐồngLaoĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logo = pichinhanh.Image;

            frmThongTinHopDongLaoDong frmhopdong = new frmThongTinHopDongLaoDong();

            frmhopdong._manv = _id;
            frmhopdong._hoten = txthoten.Text;
            frmhopdong._phongban = cbphongban.Text;

            frmhopdong.ShowDialog();
        }

        private void quáTrìnhCôngTácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logo = pichinhanh.Image;

            frmCongTac frmcongtac = new frmCongTac();

            frmcongtac._manv = _id;
            frmcongtac._hoten = txthoten.Text;
            frmcongtac._phongban = cbphongban.Text;

            frmcongtac.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _lstNVDTO = _in.getItemFull(_id);
            rptSoYeuLyLich rpt = new rptSoYeuLyLich(_lstNVDTO);
            rpt.ShowRibbonPreview();
        }
    }
}
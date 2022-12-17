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
    public partial class frmKhenThuong : DevExpress.XtraEditors.XtraForm
    {
        public frmKhenThuong()
        {
            InitializeComponent();
        }

        bool _Them;
        string _soQD;
        KhenThuong_KyLuat_BUS _ktkl;
        NhanVien_BUS _nhanvien;


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
            gcDanhSach.Enabled = kt;
            txtSoQD.Enabled = !kt;
            txtLyDo.Enabled = !kt;
            txtNoiDung.Enabled = !kt;
            slknhanvien.Enabled = !kt;
        }

        void _reset()
        {
            txtSoQD.Text = string.Empty;
            txtLyDo.Text = string.Empty;
            txtNoiDung.Text = string.Empty;
            //dtngaybatdau.Value = DateTime.Now;
            //dtngayketthuc.Value = dtngaybatdau.Value.AddMonths(6);        
        }

        void loadnhanvien()
        {
            slknhanvien.Properties.DataSource = _nhanvien.getList();
            slknhanvien.Properties.ValueMember = "MaNV";
            slknhanvien.Properties.DisplayMember = "HoTen";
        }

        void loaddata()
        {
            gcDanhSach.DataSource = _ktkl.getListFull(1);
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void SaveData()
        {
            if (_Them)
            {
                var maxSoQD = _ktkl.MaxSoQuyetDinh(1);
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;

                tb_KhenThuong_KyLuat kt = new tb_KhenThuong_KyLuat();
                kt.SoQuyetDinh = so.ToString("00000") + @"/" + DateTime.Now.Year.ToString() + @"/QĐKT";
                kt.Ngay = dtngay.Value;
                kt.LyDo = txtLyDo.Text;
                kt.NoiDung = txtNoiDung.Text;
                kt.MaNV = int.Parse(slknhanvien.EditValue.ToString());
                kt.Loai = 1;
                kt.Created_By = 1;
                kt.Created_Date = DateTime.Now;
                _ktkl.Add(kt);
            }
            else
            {
                var kt = _ktkl.getItem(_soQD);
                kt.MaNV = int.Parse(slknhanvien.EditValue.ToString());
                kt.Ngay = dtngay.Value;
                kt.LyDo = txtLyDo.Text;
                kt.NoiDung = txtNoiDung.Text;
                kt.Update_By = 1;
                kt.Update_Date = DateTime.Now;
                _ktkl.Update(kt);
            }
        }
        #endregion

        #region EVEN

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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
                _ktkl.Delete(_soQD, 1);
                loaddata();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
            splitContainer1.Panel2.Enabled = true;
            SaveData();
            loaddata();
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

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmKhenThuong_Load(object sender, EventArgs e)
        {
            _ktkl = new KhenThuong_KyLuat_BUS();
            _nhanvien = new NhanVien_BUS();
            _Them = false;
            _ShowHide(true);
            loadnhanvien();
            loaddata();
            splitContainer1.Panel1Collapsed = true;
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _soQD = gvDanhSach.GetFocusedRowCellValue("SoQuyetDinh").ToString();
                var kt = _ktkl.getItem(_soQD);
                txtSoQD.Text = _soQD;
                dtngay.Value = kt.Ngay.Value;
                slknhanvien.EditValue = kt.MaNV;
                txtNoiDung.Text = kt.NoiDung;
                txtLyDo.Text = kt.LyDo;
            }
        }

        #endregion
    }
}
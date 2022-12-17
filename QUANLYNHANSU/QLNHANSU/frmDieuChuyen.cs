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
    public partial class frmDieuChuyen : DevExpress.XtraEditors.XtraForm
    {
        public frmDieuChuyen()
        {
            InitializeComponent();
        }

        bool _Them;
        string _soQD;
        DieuChuyen_BUS _nvdc;
        NhanVien_BUS _nhanvien;
        PhongBan_BUS _phongban;

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
            txtGhiChu.Enabled = !kt;
            cboDonViDen.Enabled = !kt;
            slknhanvien.Enabled = !kt;
        }

        void _reset()
        {
            txtSoQD.Text = string.Empty;
            txtLyDo.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
        }

        void loadnhanvien()
        {
            slknhanvien.Properties.DataSource = _nhanvien.getListFull();
            slknhanvien.Properties.ValueMember = "MaNV";
            slknhanvien.Properties.DisplayMember = "HoTen";
        }

        void loaddata()
        {
            gcDanhSach.DataSource = _nvdc.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void loadDonViDen()
        {
            cboDonViDen.DataSource = _phongban.getList();
            cboDonViDen.DisplayMember = "TenPB";
            cboDonViDen.ValueMember = "IDPB";
        }

        void SaveData()
        {
            tb_DieuChuyen dc;
            if (_Them)
            {
                var maxSoQD = _nvdc.MaxSoQuyetDinh();
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;

                dc = new tb_DieuChuyen();
                dc.SoQD = so.ToString("00000") + @"/" + DateTime.Now.Year.ToString() + @"/QĐĐC";
                dc.Ngay = dtngay.Value;
                dc.LyDo = txtLyDo.Text;
                dc.GhiChu = txtGhiChu.Text;
                dc.MaNV = int.Parse(slknhanvien.EditValue.ToString());
                dc.MaPB = _nhanvien.getItem(int.Parse(slknhanvien.EditValue.ToString())).IDPB; // xóa Nullable ở tb_NhanVien
                dc.MaPB2 = int.Parse(cboDonViDen.SelectedValue.ToString());
                dc.Created_By = 1;
                dc.Created_Date = DateTime.Now;
                _nvdc.Add(dc);
            }
            else
            {
                dc = _nvdc.getItem(_soQD);
                dc.Ngay = dtngay.Value;
                dc.LyDo = txtLyDo.Text;
                dc.GhiChu = txtGhiChu.Text;
                dc.MaNV = int.Parse(slknhanvien.EditValue.ToString());
                dc.MaPB2 = int.Parse(cboDonViDen.SelectedValue.ToString());
                dc.Update_By = 1;
                dc.Update_Date = DateTime.Now;
                _nvdc.Update(dc);
            }
            var nv = _nhanvien.getItem(dc.MaNV.Value); // thêm Nullable ở tb_DieuChuyen
            nv.IDPB = dc.MaPB2;
            _nhanvien.Edit(nv);
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
                _nvdc.Delete(_soQD, 1);
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

        private void frmDieuChuyen_Load(object sender, EventArgs e)
        {
            _nvdc = new DieuChuyen_BUS();
            _nhanvien = new NhanVien_BUS();
            _phongban = new PhongBan_BUS();
            _Them = false;
            _ShowHide(true);
            loadnhanvien();
            loadDonViDen();
            loaddata();
            splitContainer1.Panel1Collapsed = true;
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _soQD = gvDanhSach.GetFocusedRowCellValue("SoQD").ToString();
                var dc = _nvdc.getItem(_soQD);
                txtSoQD.Text = _soQD;
                dtngay.Value = dc.Ngay.Value; // xóa Nullable ở tb_NhanVien
                slknhanvien.EditValue = dc.MaNV;
                txtGhiChu.Text = dc.GhiChu;
                txtLyDo.Text = dc.LyDo;
                cboDonViDen.SelectedValue = dc.MaPB2;
            }
        }
        #endregion

        private void gvDanhSach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "Delete_By" && e.CellValue != null)
            {
                Image img = Properties.Resources.del_icon;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }
    }
}
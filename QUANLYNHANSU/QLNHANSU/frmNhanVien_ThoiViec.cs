﻿using DevExpress.XtraEditors;
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
    public partial class frmNhanVien_ThoiViec : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien_ThoiViec()
        {
            InitializeComponent();
        }

        bool _Them;
        string _soQD;
        ThoiViec_BUS _nvtv;
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
            txtGhiChu.Enabled = !kt;
            slknhanvien.Enabled = !kt;
            dtngaynopdon.Enabled = !kt;

        }

        void _reset()
        {
            txtSoQD.Text = string.Empty;
            txtLyDo.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            dtngaynopdon.Value = DateTime.Now;
            dtngaynghi.Value = dtngaynopdon.Value.AddDays(45);
        }

        void loadnhanvien()
        {
            slknhanvien.Properties.DataSource = _nhanvien.getListFull();
            slknhanvien.Properties.ValueMember = "MaNV";
            slknhanvien.Properties.DisplayMember = "HoTen";
        }

        void loaddata()
        {
            gcDanhSach.DataSource = _nvtv.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void SaveData()
        {
            tb_ThoiViec tv;
            if (_Them)
            {
                var maxSoQD = _nvtv.MaxSoQuyetDinh();
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;

                tv = new tb_ThoiViec();
                tv.SoQD = so.ToString("00000") + @"/" + DateTime.Now.Year.ToString() + @"/QĐTV";
                tv.NgayNopDon = dtngaynopdon.Value;
                tv.NgayNghi = dtngaynghi.Value;
                tv.LyDo = txtLyDo.Text;
                tv.GhiChu = txtGhiChu.Text;
                tv.MaNV = int.Parse(slknhanvien.EditValue.ToString());
                tv.Created_By = 1;
                tv.Created_Date = DateTime.Now;
                _nvtv.Add(tv);
            }
            else
            {
                tv = _nvtv.getItem(_soQD);
                tv.NgayNopDon = dtngaynopdon.Value;
                tv.NgayNghi = dtngaynghi.Value;
                tv.LyDo = txtLyDo.Text;
                tv.GhiChu = txtGhiChu.Text;
                tv.MaNV = int.Parse(slknhanvien.EditValue.ToString());
                tv.Update_By = 1;
                tv.Update_Date = DateTime.Now;
                _nvtv.Update(tv);
            }
            var nv = _nhanvien.getItem(tv.MaNV.Value); // thêm Nullable ở tb_DieuChuyen
            nv.DaThoiViec = true;
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
                _nvtv.Delete(_soQD, 1);
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

        private void frmNhanVien_ThoiViec_Load(object sender, EventArgs e)
        {
            _nvtv = new ThoiViec_BUS();
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
                _soQD = gvDanhSach.GetFocusedRowCellValue("SoQD").ToString();
                var tv = _nvtv.getItem(_soQD);
                txtSoQD.Text = _soQD;
                dtngaynopdon.Value = tv.NgayNopDon.Value;
                dtngaynghi.Value = tv.NgayNghi.Value;
                slknhanvien.EditValue = tv.MaNV;
                txtGhiChu.Text = tv.GhiChu;
                txtLyDo.Text = tv.LyDo;
            }
        }

        private void gvDanhSach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "Delete_By" && e.CellValue != null)
            {
                Image img = Properties.Resources.del_icon;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }

        private void dtngaynghi_ValueChanged(object sender, EventArgs e)
        {
            dtngaynghi.Value = dtngaynopdon.Value.AddDays(45);
        }

        #endregion
    }
}
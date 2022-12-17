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
    public partial class frmNangLuong : DevExpress.XtraEditors.XtraForm
    {
        public frmNangLuong()
        {
            InitializeComponent();
        }

        bool _Them;
        string _soQD;
        NhanVien_NangLuong_BUS _nvnl;
        HopDongLaoDong_BUS _hdld;

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
            //txtLyDo.Enabled = !kt;
            txtGhiChu.Enabled = !kt;
            slkhopdong.Enabled = !kt;
            //dtngaynopdon.Enabled = !kt;

        }

        void _reset()
        {
            txtSoQD.Text = string.Empty;
            //txtLyDo.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            dtngayky.Value = DateTime.Now;
            dtngaylenluong.Value = dtngaylenluong.Value.AddDays(45);
        }

        void loadhopdong()
        {
            slkhopdong.Properties.DataSource = _hdld.getListFull();
            slkhopdong.Properties.ValueMember = "SoHD";
            slkhopdong.Properties.DisplayMember = "SoHD";
        }

        void loaddata()
        {
            gcDanhSach.DataSource = _nvnl.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void SaveData()
        {
            tb_NangLuong nangLuong;
            if (_Them)
            {
                var maxSoQD = _nvnl.MaxSoQuyetDinh();
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;

                nangLuong = new tb_NangLuong();
                nangLuong.SoQD = so.ToString("00000") + @"/" + DateTime.Now.Year.ToString() + @"/QĐNL";
                nangLuong.SoHD = slkhopdong.EditValue.ToString();
                nangLuong.NgayKy = dtngayky.Value;
                nangLuong.NgayLenLuong = dtngaylenluong.Value;
                nangLuong.HeSoLuongHienTai = _hdld.getItem(slkhopdong.EditValue.ToString()).HeSoLuong;
                nangLuong.HeSoLuongMoi = double.Parse(sphesoluongmoi.EditValue.ToString());
                nangLuong.GhiChu = txtGhiChu.Text;
                nangLuong.MaNV = _hdld.getItem(slkhopdong.EditValue.ToString()).MaNV;
                nangLuong.Created_By = 1;
                nangLuong.Created_Date = DateTime.Now;
                _nvnl.Add(nangLuong);
            }
            else
            {
                nangLuong = _nvnl.getItem(_soQD);
                nangLuong.SoHD = slkhopdong.EditValue.ToString();
                nangLuong.NgayKy = dtngayky.Value;
                nangLuong.NgayLenLuong = dtngaylenluong.Value;
                nangLuong.HeSoLuongHienTai = _hdld.getItem(slkhopdong.EditValue.ToString()).HeSoLuong;
                nangLuong.HeSoLuongMoi = double.Parse(sphesoluongmoi.EditValue.ToString());
                nangLuong.GhiChu = txtGhiChu.Text;
                nangLuong.MaNV = _hdld.getItem(slkhopdong.EditValue.ToString()).MaNV;
                nangLuong.Update_By = 1;
                nangLuong.Update_Date = DateTime.Now;
                _nvnl.Update(nangLuong);
            }
            var hd = _hdld.getItem(slkhopdong.EditValue.ToString()); // thêm Nullable ở tb_DieuChuyen
            hd.HeSoLuong = double.Parse(sphesoluongmoi.EditValue.ToString());
            _hdld.EDIT(hd);
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
                _nvnl.Delete(_soQD, 1);
                var hd = _hdld.getItem(slkhopdong.EditValue.ToString()); // thêm Nullable ở tb_DieuChuyen
                hd.HeSoLuong = double.Parse(sphesohientai.EditValue.ToString());
                _hdld.EDIT(hd);
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

        private void frmNangLuong_Load(object sender, EventArgs e)
        {
            _nvnl = new NhanVien_NangLuong_BUS();
            _hdld = new HopDongLaoDong_BUS();
            _Them = false;
            _ShowHide(true);
            loadhopdong();
            loaddata();
            splitContainer1.Panel1Collapsed = true;
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _soQD = gvDanhSach.GetFocusedRowCellValue("SoQD").ToString();
                var nl = _nvnl.getItem(_soQD);
                txtSoQD.Text = _soQD;
                dtngayky.Value = nl.NgayKy.Value;
                dtngaylenluong.Value = nl.NgayLenLuong.Value;
                slkhopdong.EditValue = nl.SoHD;
                txtGhiChu.Text = nl.GhiChu;
                sphesohientai.EditValue = nl.HeSoLuongHienTai;
                sphesoluongmoi.EditValue = nl.HeSoLuongMoi;
                txtnhanvien.Text = gvDanhSach.GetFocusedRowCellValue("HoTen").ToString();
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

        private void slkhopdong_EditValueChanged(object sender, EventArgs e)
        {
            var hd = _hdld.getItemFull(slkhopdong.EditValue.ToString());
            if(hd.Count != 0)
            {
                txtnhanvien.Text = hd[0].MaNV + " - " + hd[0].HoTen;
                sphesohientai.EditValue = hd[0].HeSoLuong;
            }
        }

        #endregion
    }
}
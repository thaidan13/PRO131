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
    public partial class frmBangCong : DevExpress.XtraEditors.XtraForm
    {
        public frmBangCong()
        {
            InitializeComponent();
        }

        KyCong_BUS _kycong;
        int _makycong;
        bool _Them;



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
            cbnam.Enabled = !kt;
            //txtLyDo.Enabled = !kt;
            cbthang.Enabled = !kt;
            ckkhoa.Enabled = !kt;
            cktrangthai.Enabled = !kt;
            //dtngaynopdon.Enabled = !kt;

        }

        //void _reset()
        //{
        //    cbnam.Text = string.Empty;
        //    //txtLyDo.Text = string.Empty;
        //    txtGhiChu.Text = string.Empty;
        //    dtngayky.Value = DateTime.Now;
        //    dtngaylenluong.Value = dtngaylenluong.Value.AddDays(45);
        //}


        void loaddata()
        {
            gcDanhSach.DataSource = _kycong.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void SaveData()
        {
            if (_Them)
            {
                tb_KyCong kc = new tb_KyCong();
                kc.MaKyCong = int.Parse(cbnam.Text) * 100 + int.Parse(cbthang.Text);
                kc.Nam = int.Parse(cbnam.Text);
                kc.Thang = int.Parse(cbthang.Text);
                kc.Khoa = ckkhoa.Checked;
                kc.TrangThai = cktrangthai.Checked;
                kc.IDCongTy = 1;
                kc.NgayCongTrongThang = Function_QLNS.demSoNgayLamViecTrongThang(int.Parse(cbthang.Text), int.Parse(cbnam.Text));
                kc.NgayTinhCong = DateTime.Now;
                kc.Created_By = 1;
                kc.Created_Date = DateTime.Now;
                _kycong.Add(kc);
            }
            else
            {
                var kc = _kycong.getItem(_makycong);
                kc.IDCongTy = 1;
                kc.MaKyCong = int.Parse(cbnam.Text) * 100 + int.Parse(cbthang.Text);
                kc.Nam = int.Parse(cbnam.Text);
                kc.Thang = int.Parse(cbthang.Text);
                kc.Khoa = ckkhoa.Checked;
                kc.TrangThai = cktrangthai.Checked;
                kc.NgayCongTrongThang = Function_QLNS.demSoNgayLamViecTrongThang(int.Parse(cbthang.Text), int.Parse(cbnam.Text));
                kc.NgayTinhCong = DateTime.Now;
                kc.Updated_By = 1;
                kc.Updated_Date = DateTime.Now;
                _kycong.Update(kc);
            }



        }


        #endregion




        #region EVEN

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainer1.Panel1Collapsed = false;
            splitContainer1.Panel2.Enabled = false;
            //_reset();
            cbnam.Text = DateTime.Now.Year.ToString();
            cbnam.Text = DateTime.Now.Month.ToString();
            ckkhoa.Checked = false;
            cktrangthai.Checked = false;
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
                _kycong.Delete(_makycong, 1);
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

        private void frmBangCong_Load(object sender, EventArgs e)
        {
            _kycong = new KyCong_BUS();
            _Them = false;
            _ShowHide(true);
            loaddata();
            splitContainer1.Panel1Collapsed = true;
            cbnam.Text = DateTime.Now.Year.ToString();
            cbthang.Text = DateTime.Now.Month.ToString();
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            if(gvDanhSach.RowCount > 1)
            {
                _makycong = int.Parse(gvDanhSach.GetFocusedRowCellValue("MaKyCong").ToString());
                cbnam.Text = gvDanhSach.GetFocusedRowCellValue("Nam").ToString();
                cbthang.Text = gvDanhSach.GetFocusedRowCellValue("Thang").ToString();
                ckkhoa.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("Khoa").ToString());
                cktrangthai.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("TrangThai").ToString());
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

        private void btnxembangcong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBangCongChiTiet frmbcct = new frmBangCongChiTiet();
            frmbcct._makycong = _makycong;
            frmbcct._thang = int.Parse(cbthang.Text);
            frmbcct._nam = int.Parse(cbnam.Text);
            frmbcct._macty = 1;
            frmbcct.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loaddata();
        }

        #endregion


    }
}
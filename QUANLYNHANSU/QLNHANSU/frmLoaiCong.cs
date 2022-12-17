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
    public partial class frmLoaiCong : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiCong()
        {
            InitializeComponent();
        }

        LOAICONG _loaicong;
        bool _Them;
        int _id;

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
            txtloaicong.Enabled = !kt;
            spheso.Enabled = !kt;
        }
        void loadData()
        {
            gcDanhSach.DataSource = _loaicong.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void SaveData()
        {
            if (_Them)
            {
                tb_LoaiCong lc = new tb_LoaiCong();
                lc.TenLoaiCong = txtloaicong.Text;
                lc.Heso = double.Parse(spheso.EditValue.ToString());
                lc.Created_By = 1;
                lc.Created_Date = DateTime.Now;
                _loaicong.Add(lc);
            }
            else
            {
                var lc = _loaicong.getItem(_id);
                lc.TenLoaiCong = txtloaicong.Text;
                lc.Heso = double.Parse(spheso.EditValue.ToString());
                lc.Update_By = 1;
                lc.Update_Date = DateTime.Now;
                _loaicong.Update(lc);

            }
        }

        #endregion

        #region EVEN
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainer1.Panel1Collapsed = false;
            splitContainer1.Panel2.Enabled = false;
            //_reset();
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
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _loaicong.Delete(_id, 1);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
            splitContainer1.Panel2.Enabled = true;
            SaveData();
            loadData();
            _Them = false;
            _ShowHide(true);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _Them = false;
            _ShowHide(true);
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmLoaiCong_Load(object sender, EventArgs e)
        {
            _Them = false;
            _loaicong = new LOAICONG();
            _ShowHide(true);
            loadData();
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDLoaiCong").ToString());
                txtloaicong.Text = gvDanhSach.GetFocusedRowCellValue("TenLoaiCong").ToString();
                spheso.Text = gvDanhSach.GetFocusedRowCellValue("Heso").ToString();
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
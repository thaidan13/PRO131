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
    public partial class frmBoPhan : DevExpress.XtraEditors.XtraForm
    {
        public frmBoPhan()
        {
            InitializeComponent();
        }


        BoPhan_BUS _bophan;
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
            txtbophan.Enabled = !kt;
        }

        void loaddata()
        {
            gcDanhSach.DataSource = _bophan.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void SaveData()
        {
            if (_Them)
            {
                tb_BoPhan dt = new tb_BoPhan();
                dt.TenBoPhan = txtbophan.Text;
                _bophan.Add(dt);
            }
            else
            {
                var dt = _bophan.getItem(_id);
                dt.TenBoPhan = txtbophan.Text;
                _bophan.Edit(dt);
            }
        }
        #endregion


        #region EVENT
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtbophan.Text = String.Empty;
            _ShowHide(false);
            _Them = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _Them = false;
            _ShowHide(false);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xoá không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _bophan.Delete(_id);
                loaddata();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loaddata();
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

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDBP").ToString());
            txtbophan.Text = gvDanhSach.GetFocusedRowCellValue("TenBoPhan").ToString();
        }

        private void frmBoPhan_Load(object sender, EventArgs e)
        {
            _Them = false;
            _bophan = new BoPhan_BUS();
            _ShowHide(true);
            loaddata();
        }
        #endregion
    }
}
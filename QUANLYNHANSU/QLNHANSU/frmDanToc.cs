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
using BusinessLayer;
using DataLayer;

namespace QLNHANSU
{
    public partial class frmDanToc : DevExpress.XtraEditors.XtraForm
    {

        DanToc_BUS _dantoc;
        bool _Them;
        int _id;

        public frmDanToc()
        {
            InitializeComponent();
        }


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
            txtdantoc.Enabled = !kt;
        }

        void loaddata()
        {
            gcDanhSach.DataSource = _dantoc.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void SaveData()
        {
            if (_Them)
            {
                tb_DanToc dt = new tb_DanToc();
                dt.TenDanToc = txtdantoc.Text;
                _dantoc.Add(dt);
            }
            else
            {
                var dt = _dantoc.getItem(_id);
                dt.TenDanToc = txtdantoc.Text;
                _dantoc.Edit(dt);
            }
        }



        #endregion


        #region EVEN

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtdantoc.Text = String.Empty;
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
                _dantoc.Delete(_id);
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

        private void frmDanToc_Load(object sender, EventArgs e)
        {
            _Them = false;
            _dantoc = new DanToc_BUS();
            _ShowHide(true);
            loaddata();
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDDanToc").ToString());
            txtdantoc.Text = gvDanhSach.GetFocusedRowCellValue("TenDanToc").ToString();
        }

        #endregion
    }
}
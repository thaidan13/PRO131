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
    public partial class frmTonGiao : DevExpress.XtraEditors.XtraForm
    {
        public frmTonGiao()
        {
            InitializeComponent();
        }

        TonGiao_BUS _tongiao;
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
            txttongiao.Enabled = !kt;
        }

        void loaddata()
        {
            gcDanhSach.DataSource = _tongiao.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void SaveData()
        {
            if (_Them)
            {
                tb_TonGiao dt = new tb_TonGiao();
                dt.TenTonGiao = txttongiao.Text;
                _tongiao.Add(dt);
            }
            else
            {
                var dt = _tongiao.getItem(_id);
                dt.TenTonGiao = txttongiao.Text;
                _tongiao.Edit(dt);
            }
        }

        #endregion

        #region EVEN

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txttongiao.Text = String.Empty;
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
                _tongiao.Delete(_id);
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

        private void frmTonGiao_Load(object sender, EventArgs e)
        {
            _Them = false;
            _tongiao = new TonGiao_BUS();
            _ShowHide(true);
            loaddata();
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDTonGiao").ToString());
            txttongiao.Text = gvDanhSach.GetFocusedRowCellValue("TenTonGiao").ToString();
        }

        #endregion
    }
}
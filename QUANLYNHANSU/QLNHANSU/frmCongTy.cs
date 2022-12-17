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
    public partial class frmCongTy : DevExpress.XtraEditors.XtraForm
    {
        public frmCongTy()
        {
            InitializeComponent();
        }

        CongTy_BUS _congty;
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
            txtcongty.Enabled = !kt;
            txtdiachi.Enabled = !kt;
            txtdienthoai.Enabled = !kt;
            txtEmail.Enabled = !kt;
        }

        void loaddata()
        {
            gcDanhSach.DataSource = _congty.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void SaveData()
        {
            if (_Them)
            {
                tb_CongTy dt = new tb_CongTy();
                dt.TenCongTy = txtcongty.Text;
                dt.DiaChi = txtdiachi.Text;
                dt.Email = txtEmail.Text;
                dt.DienThoai = txtdienthoai.Text;
                _congty.Add(dt);
            }
            else
            {
                var dt = _congty.getItem(_id);
                dt.TenCongTy = txtcongty.Text;
                dt.DiaChi = txtdiachi.Text;
                dt.Email = txtEmail.Text;
                dt.DienThoai = txtdienthoai.Text;
                _congty.Edit(dt);
            }
        }
        #endregion



        #region EVEN
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtcongty.Text = String.Empty;
            txtdiachi.Text = String.Empty;
            txtdienthoai.Text = String.Empty;
            txtEmail.Text = String.Empty;
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
                _congty.Delete(_id);
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

        private void frmCongTy_Load(object sender, EventArgs e)
        {
            _Them = false;
            _congty = new CongTy_BUS();
            _ShowHide(true);
            loaddata();
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            if(gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDCongTy").ToString());
                txtcongty.Text = gvDanhSach.GetFocusedRowCellValue("TenCongTy").ToString();
                txtEmail.Text = gvDanhSach.GetFocusedRowCellValue("Email").ToString();
                txtdienthoai.Text = gvDanhSach.GetFocusedRowCellValue("DienThoai").ToString();
                txtdiachi.Text = gvDanhSach.GetFocusedRowCellValue("DiaChi").ToString();
            }
        }
        #endregion
    }
}
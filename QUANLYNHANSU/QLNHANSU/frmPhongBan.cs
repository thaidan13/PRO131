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
    public partial class frmPhongBan : DevExpress.XtraEditors.XtraForm
    {
        public frmPhongBan()
        {
            InitializeComponent();
        }

        PhongBan_BUS _phongban;
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
            txtphongban.Enabled = !kt;
        }

        void loaddata()
        {
            gcDanhSach.DataSource = _phongban.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void SaveData()
        {
            if (_Them)
            {
                tb_PhongBan dt = new tb_PhongBan();
                dt.TenPB = txtphongban.Text;
                _phongban.Add(dt);
            }
            else
            {
                var dt = _phongban.getItem(_id);
                dt.TenPB = txtphongban.Text;
                _phongban.Edit(dt);
            }
        }
        #endregion


        #region EVEN
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtphongban.Text = String.Empty;
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
                _phongban.Delete(_id);
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

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            _Them = false;
            _phongban = new PhongBan_BUS();
            _ShowHide(true);
            loaddata();
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDPB").ToString());
            txtphongban.Text = gvDanhSach.GetFocusedRowCellValue("TenPB").ToString();
        }

        #endregion
    }
}
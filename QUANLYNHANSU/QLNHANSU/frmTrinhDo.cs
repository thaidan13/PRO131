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
    public partial class frmTrinhDo : DevExpress.XtraEditors.XtraForm
    {
        public frmTrinhDo()
        {
            InitializeComponent();
        }


        TrinhDo_BUS _trinhdo;
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
            txttrinhdo.Enabled = !kt;
        }

        void loaddata()
        {
            gcDanhSach.DataSource = _trinhdo.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void SaveData()
        {
            if (_Them)
            {
                tb_TrinhDo dt = new tb_TrinhDo();
                dt.TenTrinhDo = txttrinhdo.Text;
                _trinhdo.Add(dt);
            }
            else
            {
                var dt = _trinhdo.getItem(_id);
                dt.TenTrinhDo = txttrinhdo.Text;
                _trinhdo.Edit(dt);
            }
        }
        #endregion


        #region EVEN

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txttrinhdo.Text = String.Empty;
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
                _trinhdo.Delete(_id);
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

        private void frmTrinhDo_Load(object sender, EventArgs e)
        {
            _Them = false;
            _trinhdo = new TrinhDo_BUS();
            _ShowHide(true);
            loaddata();
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDTD").ToString());
            txttrinhdo.Text = gvDanhSach.GetFocusedRowCellValue("TenTrinhDo").ToString();
        }
        #endregion
    }
}
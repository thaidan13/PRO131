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

namespace QLNHANSU.ChamCong
{
    public partial class frmLoaiCa : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiCa()
        {
            InitializeComponent();
        }

        bool _Them;
        LoaiCa_BUS _lc;
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
            gcDanhSach.Enabled = kt;
            txtloaica.Enabled = !kt;
            spheso.Enabled = !kt;

        }

        void _reset()
        {
            txtloaica.Text = string.Empty;
            spheso.Text = string.Empty;
            
        }

        

        void loaddata()
        {
            gcDanhSach.DataSource = _lc.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void SaveData()
        {
            if (_Them)
            {
                tb_LoaiCa lc = new tb_LoaiCa();
                lc.TenLoaiCa = txtloaica.Text;
                lc.HeSo = double.Parse(spheso.EditValue.ToString());
                lc.Created_By = 1;
                lc.Created_Date = DateTime.Now;
                _lc.Add(lc);
            }
            else
            {
                var lc = _lc.getItem(_id);
                lc.TenLoaiCa = txtloaica.Text;
                lc.HeSo = double.Parse(spheso.EditValue.ToString());
                lc.Update_By = 1;
                lc.Update_Date = DateTime.Now;
                _lc.Update(lc);
            }
            
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
                _lc.Delete(_id, 1);
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

        private void frmLoaiCa_Load(object sender, EventArgs e)
        {
            _Them = false;
            _ShowHide(true);
           loaddata();
            splitContainer1.Panel1Collapsed = true;
            _lc = new LoaiCa_BUS();
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            if(gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDLoaiCa").ToString());
                txtloaica.Text = gvDanhSach.GetFocusedRowCellValue("TenLoaiCa").ToString();
                spheso.Text = gvDanhSach.GetFocusedRowCellValue("HeSo").ToString();
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

        #endregion
    }
}
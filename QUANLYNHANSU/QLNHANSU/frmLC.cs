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
    public partial class frmLC : DevExpress.XtraEditors.XtraForm
    {
        public frmLC()
        {
            InitializeComponent();
        }

        bool _Them;
        //LoaiCa_BUS _loaica;
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
            
            LoaiCa_BUS _loaica = new LoaiCa_BUS();
            gcDanhSach.DataSource = _loaica.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void SaveData()
        {
            LoaiCa_BUS _loaica = new LoaiCa_BUS();
            if (_Them)
            {
                tb_LoaiCa lc = new tb_LoaiCa();
                lc.TenLoaiCa = txtloaica.Text;
                lc.HeSo = double.Parse(spheso.EditValue.ToString());
                lc.Created_By = 1;
                lc.Created_Date = DateTime.Now;
                _loaica.Add(lc);
            }
            else
            {
                var lc = _loaica.getItem(_id);
                lc.TenLoaiCa = txtloaica.Text;
                lc.HeSo = double.Parse(spheso.EditValue.ToString());
                lc.Update_By = 1;
                lc.Update_Date = DateTime.Now;
                _loaica.Update(lc);
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
            LoaiCa_BUS _loaica = new LoaiCa_BUS();
            if (MessageBox.Show("Bạn có chắc chắn xoá không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _loaica.Delete(_id, 1);
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

        private void frmLC_Load(object sender, EventArgs e)
        {
            _Them = false;
            _ShowHide(true);
            loaddata();
            splitContainer1.Panel1Collapsed = true;
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
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
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
    public partial class frmPhuCap : DevExpress.XtraEditors.XtraForm
    {
        public frmPhuCap()
        {
            InitializeComponent();
        }

        PhuCap_BUS _pc;
        bool _Them;
        int _id;
        NhanVien_BUS _nhanvien;


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
            txtghichu.Enabled = !kt;
            slknhanvien.Enabled = !kt;
            sptien.Enabled = !kt;
            slkphucap.Enabled = !kt;

        }

        void loaddata()
        {
            gcDanhSach.DataSource = _pc.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void loadnhanvien()
        {
            slknhanvien.Properties.DataSource = _nhanvien.getList();
            slknhanvien.Properties.ValueMember = "MaNV";
            slknhanvien.Properties.DisplayMember = "HoTen";
        }
        
        void loadphucap()
        {
            //cbphucap.DataSource = _pc.getListPC();
            //cbphucap.DisplayMember = "TenPhuCap";
            //cbphucap.ValueMember = "IDPhuCap";
        }

        void loadphucap1()
        {
            slkphucap.Properties.DataSource = _pc.getListPC();
            slkphucap.Properties.DisplayMember = "TenPhuCap";
            slkphucap.Properties.ValueMember = "IDPhuCap";
        }

        void _reset()
        {
            slknhanvien.Text = string.Empty;
            //txtLyDo.Text = string.Empty;
            //slkphucap.Text = string.Empty;
            sptien.EditValue = string.Empty;
            txtghichu.Text = string.Empty;
        }

        void SaveData()
        {
            if (_Them)
            {
                tb_NhanVien_PhuCap nvpc = new tb_NhanVien_PhuCap();
                nvpc.IDPhuCap = int.Parse(slkphucap.EditValue.ToString());
                nvpc.SoTien = double.Parse(sptien.EditValue.ToString());
                nvpc.MaNV = int.Parse(slknhanvien.EditValue.ToString());
                nvpc.NoiDung = txtghichu.Text;
                nvpc.Ngay = DateTime.Now;
                _pc.Add(nvpc);
            }
            else
            {
                var nvpc = _pc.getItem(_id);
                nvpc.IDPhuCap = int.Parse(slkphucap.EditValue.ToString());
                nvpc.SoTien = double.Parse(sptien.EditValue.ToString());
                nvpc.MaNV = int.Parse(slknhanvien.EditValue.ToString());
                nvpc.NoiDung = txtghichu.Text;
                nvpc.Ngay = DateTime.Now;
                _pc.Update(nvpc);
            }
        }
        #endregion


        #region EVEN
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _ShowHide(false);
            _Them = true;
            _reset();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _Them = false;
            _ShowHide(false);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
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

        private void frmPhuCap_Load(object sender, EventArgs e)
        {
            _reset();
            _pc = new PhuCap_BUS();
            _nhanvien = new NhanVien_BUS();
            loadnhanvien();
            loaddata();
            loadphucap();
            _Them = false;
            _ShowHide(true);
            //cbphucap.SelectedIndexChanged += cbphucap_SelectedIndexChanged;
            //cbphucap.Text = null;
            loadphucap1();
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse (gvDanhSach.GetFocusedRowCellValue("ID").ToString());
                var pc = _pc.getItem(_id);
                txtghichu.Text = gvDanhSach.GetFocusedRowCellValue("NoiDung").ToString();
                sptien.EditValue = gvDanhSach.GetFocusedRowCellValue("SoTien").ToString();
                slkphucap.EditValue = gvDanhSach.GetFocusedRowCellValue("IDPhuCap").ToString();
                slknhanvien.EditValue = pc.MaNV;

            }
        }
        #endregion

        private void cbphucap_SelectedIndexChanged(object sender, EventArgs e)
        {
            //PhuCap_BUS _phucap = new PhuCap_BUS();
            //var pc = _pc.getItemPC(int.Parse(cbphucap.SelectedValue.ToString()));
            //if (pc != null)
            //{
            //    sptien.EditValue = pc.SoTien;
            //}
        }

        private void slkphucap_EditValueChanged(object sender, EventArgs e)
        {
            var pc = _pc.getItemPC(int.Parse(slkphucap.EditValue.ToString()));
            if (pc != null)
            {
                sptien.EditValue = pc.SoTien;
            }
        }
    }
}
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
using DevExpress.XtraReports.UI;
using QLNHANSU.Reports;
using BusinessLayer.DTO;

namespace QLNHANSU
{
    public partial class frmHopDongLaoDong : DevExpress.XtraEditors.XtraForm
    {
        public frmHopDongLaoDong()
        {
            InitializeComponent();
        }

        HopDongLaoDong_BUS _hdld;
        bool _Them;
        string _soHD;
        //string _MaxSoHD;
        NhanVien_BUS _nhanvien;
        List<HopDong_DTO> _lsthd;



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
            //gcDanhSach.Enabled = kt;
        }

        void _reset()
        {
            txthopdong.Text = string.Empty;
            dtngaybatdau.Value = DateTime.Now;
            dtngayketthuc.Value = dtngaybatdau.Value.AddMonths(6);
            dtngayky.Value = DateTime.Now;
            splanky.Text = "1";
            sphesoluong.Text = "1";
        }

        void loaddata()
        {
            gcDanhSach.DataSource = _hdld.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void loadnhanvien()
        {
            slknhanvien.Properties.DataSource = _nhanvien.getList();
            slknhanvien.Properties.ValueMember = "MaNV";
            slknhanvien.Properties.DisplayMember = "HoTen";
        }

        void SaveData()
        {
            if (_Them)
            {
                var maxSoHD = _hdld.MaxSoHopDong();
                int so = int.Parse(maxSoHD.Substring(0, 5)) + 1;
                tb_HopDong hd = new tb_HopDong();
                hd.SoHD = so.ToString("00000") + @"/"+ DateTime.Now.Year.ToString() + @"/HĐLĐ";
                hd.NgayBatDau = dtngaybatdau.Value;
                hd.NgayKetThuc = dtngayketthuc.Value;
                hd.NgayKy = dtngayky.Value;
                hd.ThoiHan = cbthoihan.Text;
                hd.Luong = double.Parse(txtluong.Text);
                hd.NoiDung = txtnoidung.RtfText;
                hd.HeSoLuong = double.Parse(sphesoluong.EditValue.ToString());
                hd.LanKy = int.Parse(splanky.EditValue.ToString());
                hd.MaNV = int.Parse(slknhanvien.EditValue.ToString());
                hd.IDCongTy = 1;
                hd.CREATED_BY = 1;
                hd.CREATED_DATE = DateTime.Now;
                _hdld.Add(hd);
            }
            else
            {
                var hd = _hdld.getItem(_soHD);
                hd.NgayBatDau = dtngaybatdau.Value;
                hd.NgayKetThuc = dtngayketthuc.Value;
                hd.NgayKy = dtngayky.Value;
                hd.ThoiHan = cbthoihan.Text;
                hd.Luong = double.Parse(txtluong.Text);
                hd.NoiDung = txtnoidung.RtfText;
                hd.HeSoLuong = double.Parse(sphesoluong.EditValue.ToString());
                hd.LanKy = int.Parse(splanky.EditValue.ToString());
                hd.MaNV = int.Parse(slknhanvien.EditValue.ToString());
                hd.IDCongTy = 1;
                hd.CREATED_BY = 1;
                hd.CREATED_DATE = DateTime.Now;
                _hdld.EDIT(hd);
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
                _hdld.Detele(_soHD,1);
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

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _lsthd = _hdld.getItemFull(_soHD);
            rptHopDongLaoDong rpt = new rptHopDongLaoDong(_lsthd);
            rpt.ShowRibbonPreview();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmHopDongLaoDong_Load(object sender, EventArgs e)
        {
            _hdld = new HopDongLaoDong_BUS();
            _Them = false;
            _ShowHide(true);
            loaddata();
            splitContainer1.Panel1Collapsed = true;
            _nhanvien = new NhanVien_BUS();
            loadnhanvien();
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _soHD = gvDanhSach.GetFocusedRowCellValue("SoHD").ToString();
                var hd = _hdld.getItem(_soHD);
                txthopdong.Text = _soHD;
                dtngaybatdau.Value = hd.NgayBatDau.Value;
                dtngayketthuc.Value = hd.NgayKetThuc.Value;
                txtluong.Text = hd.Luong.ToString();
                dtngayky.Value = hd.NgayKy.Value;
                cbthoihan.Text = hd.ThoiHan;
                sphesoluong.Text = hd.HeSoLuong.ToString();
                splanky.Text = hd.LanKy.ToString();
                slknhanvien.EditValue = hd.MaNV;
                txtnoidung.RtfText = hd.NoiDung;
                _lsthd = _hdld.getItemFull(_soHD);
            }
        }

        #endregion
    }
}
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using BusinessLayer.DTO;
using System.Collections.Generic;

namespace QLNHANSU.Reports
{
    public partial class rptDanhSachNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDanhSachNhanVien()
        {
            InitializeComponent();
        }

        List<NhanVien_DTO> _lstNV;

        public rptDanhSachNhanVien(List<NhanVien_DTO> lstNV)
        {
            InitializeComponent();
            this._lstNV = lstNV;
            this.DataSource = _lstNV;
            loaddata();
        }

        void loaddata()
        {
            lblMaNV.DataBindings.Add("Text", _lstNV, "MaNV");
            lblHoTen.DataBindings.Add("Text", _lstNV, "HoTen");
            lblGioiTinh.DataBindings.Add("Text", _lstNV, "GioiTinh");
            lblNgaySinh.DataBindings.Add("Text", _lstNV, "NgaySinh");
            lblCCCD.DataBindings.Add("Text", _lstNV, "CCCD");
            lblDienThoai.DataBindings.Add("Text", _lstNV, "DienThoai");
            lblPhongBan.DataBindings.Add("Text", _lstNV, "TenPB");
            lblChucVu.DataBindings.Add("Text", _lstNV, "TenChucVu");
            lblTrinhDo.DataBindings.Add("Text", _lstNV, "TenTrinhDo");
            lblDanToc.DataBindings.Add("Text", _lstNV, "TenDanToc");
            lblTonGiao.DataBindings.Add("Text", _lstNV, "TenTonGiao");
            lblDiaChi.DataBindings.Add("Text", _lstNV, "DiaChi");
        }

    }
}

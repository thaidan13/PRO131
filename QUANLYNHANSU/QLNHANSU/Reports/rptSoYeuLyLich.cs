using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using BusinessLayer.DTO;
using System.Collections.Generic;

namespace QLNHANSU.Reports
{
    public partial class rptSoYeuLyLich : DevExpress.XtraReports.UI.XtraReport
    {
        public rptSoYeuLyLich()
        {
            InitializeComponent();
        }

        public rptSoYeuLyLich(List<NhanVien_DTO> lstnv)
        {
            InitializeComponent();
            this._lstNv = lstnv;
            this.DataSource = _lstNv;
            loadata();
        }

        List<NhanVien_DTO> _lstNv;

        void loadata()
        {
            xrmanhanvien.DataBindings.Add("Text", _lstNv, "SoHD");

            xrPictureBox1.DataBindings.Add("Image", _lstNv, "HinhAnh");
        }
    }
}

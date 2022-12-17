using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using BusinessLayer.DTO;
using System.Collections.Generic;

namespace QLNHANSU.Reports
{
    public partial class rptHopDongLaoDong : DevExpress.XtraReports.UI.XtraReport
    {
        public rptHopDongLaoDong()
        {
            InitializeComponent();
        }
        List<HopDong_DTO> _lstHD;

        public rptHopDongLaoDong(List<HopDong_DTO> lsthd)
        {
            InitializeComponent();
            this._lstHD = lsthd;
            this.DataSource = _lstHD;
            loadata();
        }

        void loadata()
        {
            xrsohd.DataBindings.Add("Text", _lstHD, "SoHD");
        }

    }
}

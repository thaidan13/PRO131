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
    public partial class frmCapNhatNgayCong : DevExpress.XtraEditors.XtraForm
    {
        public frmCapNhatNgayCong()
        {
            InitializeComponent();
        }

        public int _manv;
        public string _hoten;
        public int _makycong;
        public string _ngay;
        public int _cNgay;
        KyCongChiTiet_BUS _kcct;
        frmBangCongChiTiet frmBCCC = (frmBangCongChiTiet)Application.OpenForms["frmBangCongChiTiet"];
        BangCong_NV_CT_BUS _bcct_nv;


        private void btncapnhat_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(_manv.ToString() + " - " + _makycong.ToString() + " - " + _ngay);
            string _valueChamCong = rdgchamcong.Properties.Items[rdgchamcong.SelectedIndex].Value.ToString();
            string _valueNgayNghi = rdgthoigiannghi.Properties.Items[rdgthoigiannghi.SelectedIndex].Value.ToString();
            string fieldName = "D" + _cNgay.ToString();
            var kcct = _kcct.getItem(_makycong, _manv);

            //double? tongngaycong = kcct.TONGNGAYCONG;
            //double? tongngayphep = kcct.NGAYPHEP;
            //double? tongngaykhongphep = kcct.NGHIKHONGPHEP; ;
            //double? tongngayle = kcct.CONGNGAYLE;//2022*100+1=202201
            if (cldngaycong.SelectionRange.Start.Year * 100 + cldngaycong.SelectionRange.Start.Month != +_makycong)
            {
                MessageBox.Show("Thực hiện chấm công không đúng kỳ công. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            tb_BANGCONG_NHANVIEN_CHITIET bcctnv = _bcct_nv.getItem(_makycong, _manv, cldngaycong.SelectionStart.Day);
            bcctnv.KYHIEU = _valueChamCong;

            switch (_valueChamCong)
            {
                case "P":

                    if (_valueNgayNghi == "NN")
                    {
                        bcctnv.NGAYPHEP = 1;
                        bcctnv.NGAYCONG = 0;

                    }
                    else
                    {
                        bcctnv.NGAYPHEP = 0.5;
                        bcctnv.NGAYCONG = 0.5;

                    }
                    break;
                case "CT":
                    if (_valueNgayNghi == "NN")
                    {
                        bcctnv.NGAYCONG = 1;
                    }
                    else
                    {
                        bcctnv.NGAYCONG = 0.5;
                        bcctnv.NGAYPHEP = 0.5;
                    }
                    break;
                case "VR":
                    if(_valueNgayNghi == "NN")
                    {
                        bcctnv.NGAYVANG = 1;
                        bcctnv.NGAYCONG = 0;
                    }
                    else
                    {
                        bcctnv.NGAYVANG = 0.5;
                        bcctnv.NGAYCONG = 0.5;
                    }
                    break;
                case "V":
                    if (_valueNgayNghi == "NN")
                    {
                        bcctnv.NGAYVANG = 1;
                        bcctnv.NGAYCONG = 0;
                    }
                    else
                    {
                        bcctnv.NGAYVANG = 0.5;
                        bcctnv.NGAYCONG = 0.5;
                    }
                    break;
                default:
                    break;
            }


            //Update tb_BANGCONG_NV_CT
            _bcct_nv.Update(bcctnv);

            //Tính lại tổng các ngày: ngày phép, ngày công, ngày vắng,...
            double tongngaycong = _bcct_nv.tongNgayCong(_makycong, _manv);
            double tongngayphep = _bcct_nv.tongNgayPhep(_makycong, _manv);
            double tongngayvang = _bcct_nv.tongNgayVang(_makycong, _manv);
            kcct.NGAYPHEP = tongngayphep;
            kcct.TONGNGAYCONG = tongngaycong;
            kcct.NGHIKHONGPHEP = tongngayvang;
            _kcct.Update(kcct);


            //Cập nhật KYCONGCHITIET=> cập nhật BANGCONG_NV_CT
            Function_QLNS.execQuery("UPDATE tb_KYCONGCHITIET SET " + fieldName + "='" + _valueChamCong + "' WHERE MaKyCong=" + _makycong + " AND MaNV=" + _manv);

            frmBCCC.loadBangCong();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCapNhatNgayCong_Load(object sender, EventArgs e)
        {
            lbid.Text = _manv.ToString();
            lbhoten.Text = _hoten.ToString();
            string nam = _makycong.ToString().Substring(0, 4);
            string thang = _makycong.ToString().Substring(4);
            string ngay = _ngay.Substring(1);
            DateTime _d = DateTime.Parse(nam + "-" + thang + "-" + ngay);
            cldngaycong.SetDate(_d);
            _kcct = new KyCongChiTiet_BUS();
            _bcct_nv = new BangCong_NV_CT_BUS();
        }

        private void cldngaycong_DateSelected(object sender, DateRangeEventArgs e)
        {
            _cNgay = cldngaycong.SelectionRange.Start.Day;
        }
    }
}
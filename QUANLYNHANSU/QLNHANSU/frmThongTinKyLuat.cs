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
using System.IO;
using System.Diagnostics;

namespace QLNHANSU
{
    public partial class frmThongTinKyLuat : DevExpress.XtraEditors.XtraForm
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public frmThongTinKyLuat()
        {
            InitializeComponent();
        }

        ChiTietKyLuat_BUS _ctkl;
        
        int _Id;
        public int _manv;
        public string _hoten;
        public string _phongban;
        public string _email;
        public string _dienthoainha;
        public string _dtdd;

        private void frmThongTinKyLuat_Load(object sender, EventArgs e)
        {
            _ctkl = new ChiTietKyLuat_BUS();

            txtnhanvien.Text = _hoten;
            pictureEdit1.Image = frmNhanVien.Logo;
            lbmanv.Text = _manv.ToString();
            lbhoten.Text = _hoten.ToString();
            lbphongban.Text = _phongban.ToString();

            loaddata(_manv);
            loaddataNV();
        }

        private void lbmorong_Click(object sender, EventArgs e)
        {
            gcThongTin.Visible = false;
            groupControl1.Visible = true;
            label20.Visible = true;
            lbmorong.Visible = false;
        }

        private void label20_Click(object sender, EventArgs e)
        {
            groupControl1.Visible = false;
            label20.Visible = false;
            lbmorong.Visible = true;
            gcThongTin.Visible = true;
        }

        #region METHODS

        void loaddata(int mnv)
        {
            try
            {
                int manv = int.Parse(_manv.ToString());
                var item = db.tb_DienThoaiLienHe.Where(x => x.MaNV == manv).SingleOrDefault();

                if (_ctkl.checkthongtinlienlac(manv) < 1)
                {
                    MessageBox.Show("Thông liên hệ chưa đầy đủ, vui lòng nhập đầy đủ!", "Thông báo");
                    return;
                }
                lbdienthoai.Text = item.DienThoaiNha;
                lbdtdd.Text = item.DTDD;
                lbemail.Text = item.Email;
            }
            //catch (Exception ex)
            //{

            //    throw new Exception("Lỗi: " + ex.Message);
            //}
            catch
            {
                MessageBox.Show("Chưa có thông tin đầy đủ", "Thông báo");
            }
        }

        void loaddataNV()
        {
            //var obj = (from a in db.tb_NVDiNuocNgoai
            //           where a.MaNV == _manv
            //           select a).ToList();

            var obj2 = _ctkl.getList(_manv);

            gcThongTin.DataSource = obj2;
            gvThongTin.OptionsBehavior.Editable = false;
        }

        void Savedata()
        {
            tb_ChiTietKyLuat ctkt = new tb_ChiTietKyLuat();

            ctkt.MaNV = int.Parse(_manv.ToString());
            ctkt.HoTen = _hoten;
            ctkt.HinhThuc = txthinhthuc.Text;
            ctkt.TuNgay = dttungay.Value;
            ctkt.DenNgay = dtdenngay.Value;
            ctkt.LyDo = txtlydo.Text;
            ctkt.CapQuyetDinh = txtcapquyetdinh.Text;
            ctkt.SoQuyetDinh = txtsoquyetdinh.Text;
            ctkt.NguoiKy = txtnguoiky.Text;
            ctkt.NgayKy = dtngayky.Value;
            ctkt.GhiChu = txtghichu.Text;
            ctkt.DinhKem = lbfile.Text;

            _ctkl.Add(ctkt);
            loaddataNV();
        }

        void Updatedata()
        {
            tb_ChiTietKhenThuong ctkt = new tb_ChiTietKhenThuong();
            _Id = int.Parse(gvThongTin.GetFocusedRowCellValue("Id").ToString());
            var kt = _ctkl.getItem(_Id);
            kt.HinhThuc = txthinhthuc.Text;
            kt.TuNgay = dttungay.Value;
            kt.DenNgay = dtdenngay.Value;
            kt.LyDo = txtlydo.Text;
            kt.CapQuyetDinh = txtcapquyetdinh.Text;
            kt.SoQuyetDinh = txtsoquyetdinh.Text;
            kt.NguoiKy = txtnguoiky.Text;
            kt.NgayKy = dtngayky.Value;
            kt.GhiChu = txtghichu.Text;
            kt.DinhKem = lbfile.Text;

            _ctkl.Update(kt);
            loaddataNV();
        }




        #endregion

        private void btnluu_Click(object sender, EventArgs e)
        {
            Savedata();
            MessageBox.Show("Đã cập nhật thành công!", "Thông Báo");
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            Updatedata();
            MessageBox.Show("Đã cập nhật thành công!", "Thông Báo");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gcThongTin_Click(object sender, EventArgs e)
        {
            if (gvThongTin.RowCount > 0)
            {
                _Id = int.Parse(gvThongTin.GetFocusedRowCellValue("Id").ToString());
                var tt = _ctkl.getItem(_Id);

                txthinhthuc.Text = tt.HinhThuc;
                dttungay.Value = tt.TuNgay.Value;
                dtdenngay.Value = tt.DenNgay.Value;
                txtlydo.Text = tt.LyDo;
                txtcapquyetdinh.Text = tt.CapQuyetDinh;
                txtsoquyetdinh.Text = tt.SoQuyetDinh;
                txtnguoiky.Text = tt.NguoiKy;
                dtngayky.Value = tt.NgayKy.Value;
                txtghichu.Text = tt.GhiChu;
                lbfile.Text = tt.DinhKem;
            }
        }

        private void lbfile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lbfile.Text = Path.GetFileName(openFileDialog1.FileName);
                lbfile.Text = Path.GetFullPath(openFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 file!", "Thông báo");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("file:///" + lbfile.Text);
        }
    }
}
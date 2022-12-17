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
    public partial class frmTTQuaTrinhLamViecNT : DevExpress.XtraEditors.XtraForm
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public frmTTQuaTrinhLamViecNT()
        {
            InitializeComponent();
        }

        QuaTrinhLamViecThanNhan_BUS _qtlvtn;
        int _Id;
        public int _IdThanNhan;
        public int _manv;
        public string _hoten;
        public string _phongban;
        public string _email;
        public string _dienthoainha;
        public string _dtdd;
        public string _thannhan;
        public string _quanhe;

        private void frmTTQuaTrinhLamViecNT_Load(object sender, EventArgs e)
        {
            _qtlvtn = new QuaTrinhLamViecThanNhan_BUS();

            pictureEdit1.Image = frmThongTinGiaDinh.Logo;
            lbmanv.Text = _manv.ToString();
            lbhoten.Text = _hoten.ToString();
            lbphongban.Text = _phongban.ToString();

            lbemail.Text = _email;
            lbdtdd.Text = _dtdd;
            lbdienthoai.Text = _dienthoainha;

            lbtenthannhan.Text = _thannhan;
            lbquanhe.Text = _quanhe;
            //label15.Text = (_IdThanNhan.ToString());

            loaddataNV();
        }

        void loaddataNV()
        {
            //var obj = (from a in db.tb_NVDiNuocNgoai
            //           where a.MaNV == _manv
            //           select a).ToList();

            var obj2 = _qtlvtn.getList(_IdThanNhan);

            gcThongTin.DataSource = obj2;
            gvThongTin.OptionsBehavior.Editable = false;
        }

        void Savedata()
        {
            tb_QuaTrinhLamViecCuaThanNhan qtlvtn = new tb_QuaTrinhLamViecCuaThanNhan();

            qtlvtn.IdThongtinThanNhan = int.Parse(_IdThanNhan.ToString());
            qtlvtn.TuNam = dttungay.Value;
            qtlvtn.DenNam = dtdenngay.Value;
            qtlvtn.CongViec = txtcongviec.Text;
            qtlvtn.DonVi = txtdonvi.Text;
            qtlvtn.CapBac = txtcapbac.Text;
            qtlvtn.ChucVu = txtchucvu.Text;
            qtlvtn.LoaiChucVu = cbloaidonvi.Text;
            qtlvtn.TrongNganh = cktrongnganh.Checked;

            _qtlvtn.Add(qtlvtn);
            loaddataNV();
        }

        void Updatedata()
        {
            _Id = int.Parse(gvThongTin.GetFocusedRowCellValue("Id").ToString());
            var qtlvtn = _qtlvtn.getItem(_Id);
            qtlvtn.TuNam = dttungay.Value;
            qtlvtn.DenNam = dtdenngay.Value;
            qtlvtn.CongViec = txtcongviec.Text;
            qtlvtn.DonVi = txtdonvi.Text;
            qtlvtn.CapBac = txtcapbac.Text;
            qtlvtn.ChucVu = txtchucvu.Text;
            qtlvtn.LoaiChucVu = cbloaidonvi.Text;
            qtlvtn.TrongNganh = cktrongnganh.Checked;

            _qtlvtn.Update(qtlvtn);
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

        private void lbtrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbthem_Click(object sender, EventArgs e)
        {
            Savedata();
            MessageBox.Show("Đã cập nhật thành công!", "Thông Báo");
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            Updatedata();
            MessageBox.Show("Đã cập nhật thành công!", "Thông Báo");
        }

        private void gcThongTin_Click(object sender, EventArgs e)
        {
            if (gvThongTin.RowCount > 0)
            {
                _Id = int.Parse(gvThongTin.GetFocusedRowCellValue("Id").ToString());
                var tt = _qtlvtn.getItem(_Id);

                dttungay.Value = tt.TuNam.Value;
                dtdenngay.Value = tt.DenNam.Value;
                txtcongviec.Text = tt.CongViec;
                txtdonvi.Text = tt.DonVi;
                txtcapbac.Text = tt.CapBac;
                txtchucvu.Text = tt.ChucVu;
                cbloaidonvi.Text = tt.LoaiChucVu;
                cktrongnganh.Checked = tt.TrongNganh.Value;
            }
        }
    }
}
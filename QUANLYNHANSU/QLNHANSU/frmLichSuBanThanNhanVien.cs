﻿using DevExpress.XtraEditors;
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
    public partial class frmLichSuBanThanNhanVien : DevExpress.XtraEditors.XtraForm
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public frmLichSuBanThanNhanVien()
        {
            InitializeComponent();
        }

        LichSuNhanVien_BUS _lsnv;

        int _Id;
        public int _manv;
        public string _hoten;
        public string _phongban;
        public string _email;
        public string _dienthoainha;
        public string _dtdd;

        private void frmLichSuBanThanNhanVien_Load(object sender, EventArgs e)
        {
            _lsnv = new LichSuNhanVien_BUS();

            pictureEdit1.Image = frmNhanVien.Logo;
            lbmanv.Text = _manv.ToString();
            lbhoten.Text = _hoten.ToString();
            lbphongban.Text = _phongban.ToString();

            loaddata(_manv);
            loaddataNV();
        }

        void loaddata(int mnv)
        {
            try
            {
                int manv = int.Parse(_manv.ToString());
                var item = db.tb_DienThoaiLienHe.Where(x => x.MaNV == manv).SingleOrDefault();

                if (_lsnv.checkthongtinlienlac(manv) < 1)
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

            var obj2 = _lsnv.getList(_manv);

            gcThongTin.DataSource = obj2;
            gvThongTin.OptionsBehavior.Editable = false;
        }

        void Savedata()
        {
            tb_LichSuBanThanNhanVien lsnv = new tb_LichSuBanThanNhanVien();

            lsnv.MaNV = int.Parse(_manv.ToString());
            lsnv.TuNgay = dttungay.Value;
            lsnv.DenNam = dtdenngay.Value;
            lsnv.LamGi = txtlamgi.Text;
            lsnv.ODau = txtodau.Text;

            _lsnv.Add(lsnv);
            loaddataNV();
        }

        void Updatedata()
        {
            _Id = int.Parse(gvThongTin.GetFocusedRowCellValue("Id").ToString());
            var lsnv = _lsnv.getItem(_Id);
            lsnv.TuNgay = dttungay.Value;
            lsnv.DenNam = dtdenngay.Value;
            lsnv.LamGi = txtlamgi.Text;
            lsnv.ODau = txtodau.Text;

            _lsnv.Update(lsnv);
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

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            Updatedata();
            MessageBox.Show("Đã cập nhật thành công!", "Thông Báo");
        }

        private void lbthem_Click(object sender, EventArgs e)
        {
            Savedata();
            MessageBox.Show("Đã cập nhật thành công!", "Thông Báo");
        }

        private void lbtrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gcThongTin_Click(object sender, EventArgs e)
        {
            if (gvThongTin.RowCount > 0)
            {
                _Id = int.Parse(gvThongTin.GetFocusedRowCellValue("Id").ToString());
                var tt = _lsnv.getItem(_Id);

                dttungay.Value = tt.TuNgay.Value;
                dtdenngay.Value = tt.DenNam.Value;
                txtlamgi.Text = tt.LamGi;
                txtodau.Text = tt.ODau;
            }
        }
    }
}
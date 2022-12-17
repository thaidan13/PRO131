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
    public partial class frmNgoaiNgu : DevExpress.XtraEditors.XtraForm
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public frmNgoaiNgu()
        {
            InitializeComponent();
        }

        NgoaiNgu_BUS _ttng;
        public int _manv;
        int _Id;

        private void frmNgoaiNgu_Load(object sender, EventArgs e)
        {
            _ttng = new NgoaiNgu_BUS();
            loaddata();
        }

        void loaddata()
        {
            var obj = (from a in db.tb_ThongTinNgoaiNgu
                       where a.MaNV == _manv
                       select a).ToList();

            gcthongtin.DataSource = obj;
            gvthongtin.OptionsBehavior.Editable = false;
        }

        void Savedata()
        {
            tb_ThongTinNgoaiNgu ttng = new tb_ThongTinNgoaiNgu();
            ttng.NgoaiNgu = cbngoaingu.Text;
            ttng.KetQua = cbketqua.Text;
            ttng.MaNV = int.Parse(_manv.ToString());
            ttng.BangCap = cbbangcap.Text;
            ttng.NgayCap = dtngaycap.Value;
            ttng.KinhPhi =double.Parse(cbkinhphi.Text);
            ttng.NguonKinhPhi = txtnguonkinhphi.Text;
            ttng.GhiChu = txtghichu.Text;
            ttng.ChinhPhu = ckchinhphu.Checked;
            
            _ttng.Add(ttng);
        }

        void Updatedata()
        {
            _Id = int.Parse(gvthongtin.GetFocusedRowCellValue("Id").ToString());
            var ttng = _ttng.getItem(_Id);
            ttng.NgoaiNgu = cbngoaingu.Text;
            ttng.KetQua = cbketqua.Text;
            ttng.MaNV = int.Parse(_manv.ToString());
            ttng.BangCap = cbbangcap.Text;
            ttng.NgayCap = dtngaycap.Value;
            ttng.KinhPhi = double.Parse(cbkinhphi.Text);
            ttng.NguonKinhPhi = txtnguonkinhphi.Text;
            ttng.GhiChu = txtghichu.Text;
            ttng.ChinhPhu = ckchinhphu.Checked;
            _ttng.Update(ttng);
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            Savedata();
            MessageBox.Show("Đã cập nhật thành công!", "Thông Báo");
            loaddata();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            Updatedata();
            loaddata();
            MessageBox.Show("Đã cập nhật thành công!", "Thông Báo");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gcthongtin_Click(object sender, EventArgs e)
        {
            if (gvthongtin.RowCount > 0)
            {
                _Id = int.Parse(gvthongtin.GetFocusedRowCellValue("Id").ToString());
                var tt = _ttng.getItem(_Id);
                cbngoaingu.Text = tt.NgoaiNgu;
                cbketqua.Text = tt.KetQua;
                ckchinhphu.Checked = tt.ChinhPhu.Value;
                cbbangcap.Text = tt.BangCap;
                dtngaycap.Value = tt.NgayCap.Value;
                cbkinhphi.Text = tt.KinhPhi.ToString();
                txtnguonkinhphi.Text = tt.NguonKinhPhi;
                txtghichu.Text = tt.GhiChu;
            }
        }
    }
}
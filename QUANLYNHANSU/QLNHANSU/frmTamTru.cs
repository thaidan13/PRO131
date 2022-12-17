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
    public partial class frmTamTru : DevExpress.XtraEditors.XtraForm
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public frmTamTru()
        {
            InitializeComponent();
        }

        TamTru_BUS _tt;
        public int _manv;
        public bool _check;

        private void frmTamTru_Load(object sender, EventArgs e)
        {
            _tt = new TamTru_BUS();
            pictureEdit1.Image = frmNhanVien.Logo;

            ckgioitinh.Checked = _check;
        }

        void loaddata(int mnv)
        {
            try
            {
                int manv = int.Parse(_manv.ToString());
                var item = db.tb_TamTru.Where(x => x.MaNV == manv).SingleOrDefault();

                txtdiachi.Text = item.DiaChi;
                txtphuongxa.Text = item.PhuongXa;
                txtquanhuyen.Text = item.QuanHhuyen;
                cbthanhpho.Text = item.ThanhPho;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }

        }

        void Savedata()
        {
            tb_TamTru tt = new tb_TamTru();
            tt.DiaChi = txtdiachi.Text;
            tt.PhuongXa = txtphuongxa.Text;
            tt.QuanHhuyen = txtquanhuyen.Text;
            tt.MaNV = int.Parse(_manv.ToString());
            tt.ThanhPho = cbthanhpho.Text;

            _tt.Add(tt);
        }

        void Updatedata()
        {
            var tt = _tt.getItem(_manv);
            tt.PhuongXa = txtphuongxa.Text;
            tt.QuanHhuyen = txtquanhuyen.Text;
            tt.MaNV = int.Parse(_manv.ToString());
            tt.ThanhPho = cbthanhpho.Text;
            _tt.Update(tt);
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (_tt.check(_manv) >= 1)
            {
                MessageBox.Show("Chưa có dữ liệu!", "Thông Báo");
                btnluu.Enabled = false;
                return;
            }
            Savedata();
            MessageBox.Show("Đã cập nhật thành công!", "Thông Báo");
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            Updatedata();
            MessageBox.Show("Đã cập nhật thành công!", "Thông Báo");
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            if (_tt.check(_manv) < 1)
            {
                MessageBox.Show("Chưa có dữ liệu!", "Thông Báo");
                return;
            }
            int id = int.Parse(_manv.ToString());
            loaddata(id);
        }
    }
}
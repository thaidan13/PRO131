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
    public partial class frmQueQuan : DevExpress.XtraEditors.XtraForm
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public frmQueQuan()
        {
            InitializeComponent();
        }

        QueQuan_BUS _quequan;

        public int _manv;
        public bool _check;

        void loaddata(int mnv)
        {
            try
            {
                int manv = int.Parse(_manv.ToString());
                var item = db.tb_QueQuan.Where(x => x.MaNV == manv).SingleOrDefault();

                txtphuongxa.Text = item.PhuongXa;
                txtquanhuyen.Text = item.QuanHuyen;
                cbthanhpho.Text = item.ThanhPho;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }

        }

        private void frmQueQuan_Load(object sender, EventArgs e)
        {
            pictureEdit1.Image = frmNhanVien.Logo;
            _quequan = new QueQuan_BUS();

            ckgioitinh.Checked = _check;
        }

        void Savedata()
        {
            tb_QueQuan qq = new tb_QueQuan();
            qq.PhuongXa = txtphuongxa.Text;
            qq.QuanHuyen = txtquanhuyen.Text;
            qq.MaNV = int.Parse(_manv.ToString());
            qq.ThanhPho = cbthanhpho.Text;

            _quequan.Add(qq);
        }

        void Updatedata()
        {
            var qq = _quequan.getItem(_manv);
            qq.PhuongXa = txtphuongxa.Text;
            qq.QuanHuyen = txtquanhuyen.Text;
            qq.MaNV = int.Parse(_manv.ToString());
            qq.ThanhPho = cbthanhpho.Text;
            _quequan.Update(qq);
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (_quequan.check(_manv) >= 1)
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
            if (_quequan.check(_manv) < 1)
            {
                MessageBox.Show("Chưa có dữ liệu!", "Thông Báo");
                return;
            }
            int id = int.Parse(_manv.ToString());
            loaddata(id);
        }
    }
}
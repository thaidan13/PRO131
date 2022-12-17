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
    public partial class frmDienThoai_LienLac : DevExpress.XtraEditors.XtraForm
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public frmDienThoai_LienLac()
        {
            InitializeComponent();
        }

        DienThoaiDiDong_BUS _dtdd;
        public int _manv;
        public bool _check;


        //public string _dienthoainha;
        //public string _didong;
        //public string _email;

        private void frmDienThoai_LienLac_Load(object sender, EventArgs e)
        {
            
            _dtdd = new DienThoaiDiDong_BUS();
            pictureEdit1.Image = frmNhanVien.Logo;

            ckgioitinh.Checked = _check;
        }

        
        void loaddata(int mnv)
        {
            try
            {
                int manv = int.Parse(_manv.ToString());
                var item = db.tb_DienThoaiLienHe.Where(x => x.MaNV == manv).SingleOrDefault();

                txtdienthoainha.Text = item.DienThoaiNha;
                txtdtdd.Text = item.DTDD;
                txtemail.Text = item.Email;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }

        }

        void Savedata()
        {
            tb_DienThoaiLienHe dtdd = new tb_DienThoaiLienHe();
            dtdd.DienThoaiNha = txtdienthoainha.Text;
            dtdd.DTDD = txtdtdd.Text;
            dtdd.MaNV = int.Parse(_manv.ToString());
            dtdd.Email = txtemail.Text;

            _dtdd.Add(dtdd);
        }

        void Updatedata()
        {
            var dtdd = _dtdd.getItem(_manv);
            dtdd.DienThoaiNha = txtdienthoainha.Text;
            dtdd.DTDD = txtdtdd.Text;
            dtdd.MaNV = int.Parse(_manv.ToString());
            dtdd.Email = txtemail.Text;
            _dtdd.Update(dtdd);
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (_dtdd.check(_manv) >= 1)
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
            if (_dtdd.check(_manv) < 1)
            {
                MessageBox.Show("Chưa có dữ liệu!", "Thông Báo");
                return;
            }
            int id = int.Parse(_manv.ToString());
            loaddata(id);
        }
    }
}
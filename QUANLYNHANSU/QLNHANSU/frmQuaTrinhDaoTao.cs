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
    public partial class frmQuaTrinhDaoTao : DevExpress.XtraEditors.XtraForm
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public frmQuaTrinhDaoTao()
        {
            InitializeComponent();
        }

        DienThoaiDiDong_BUS _dt;
        ThongTinDoanDang_BUS _ttdd;

        public int _manv;
        public string _hoten;
        public string _phongban;
        public string _email;
        public string _dienthoainha;
        public string _dtdd;

        void loaddata(int mnv)
        {
            try
            {
                int manv = int.Parse(_manv.ToString());
                var item = db.tb_DienThoaiLienHe.Where(x => x.MaNV == manv).SingleOrDefault();

                if (_ttdd.checkthongtinlienlac(manv) < 1)
                {
                    //MessageBox.Show("Thông liên hệ chưa đầy đủ, vui lòng nhập đầy đủ!", "Thông báo");
                    return;
                }

                lbdienthoai.Text = item.DienThoaiNha;
                lbdtdd.Text = item.DTDD;
                lbemail.Text = item.Email;
            }
            catch (Exception ex)
            {
                
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        private void frmQuaTrinhDaoTao_Load(object sender, EventArgs e)
        {
            _ttdd = new ThongTinDoanDang_BUS();
            _dt = new DienThoaiDiDong_BUS();
            loaddata(_manv);

            pictureEdit1.Image = frmNhanVien.Logo;
            lbmanv.Text = _manv.ToString();
            lbhoten.Text = _hoten.ToString();
            lbphongban.Text = _phongban.ToString();
            

        }

        private void btnquatrinhdaotao_Click(object sender, EventArgs e)
        {
            frmNhapThongTinTrinhDo frmNhapThongTin = new frmNhapThongTinTrinhDo();
            frmNhapThongTin._manv = _manv;
            frmNhapThongTin.ShowDialog();
        }

        private void btnngoaingu_Click(object sender, EventArgs e)
        {
            frmNgoaiNgu frmngoaingu = new frmNgoaiNgu();
            frmngoaingu._manv = _manv;
            frmngoaingu.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frmViTinh frmvitinh = new frmViTinh();
            frmvitinh._manv = _manv;
            frmvitinh.ShowDialog();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            frmchinhtri frmct = new frmchinhtri();
            frmct._manv = _manv;
            frmct.ShowDialog();
        }
    }
}
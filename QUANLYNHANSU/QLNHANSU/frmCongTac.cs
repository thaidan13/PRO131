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
    public partial class frmCongTac : DevExpress.XtraEditors.XtraForm
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public frmCongTac()
        {
            InitializeComponent();
        }

        int _Id;
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
                ThongTinHopDong_BUS _tthdld = new ThongTinHopDong_BUS();
                int manv = int.Parse(_manv.ToString());
                var item = db.tb_DienThoaiLienHe.Where(x => x.MaNV == manv).SingleOrDefault();

                if (_tthdld.checkthongtinlienlac(manv) < 1)
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


        private void btnquatrinhcongtactrongcongty_Click(object sender, EventArgs e)
        {
            

            panel4.Visible = false;
            panel5.Visible = true;

            frmCongTacTrongCongTy frmtrongCY = new frmCongTacTrongCongTy();
            addUserControl(frmtrongCY);

            frmtrongCY._manv = _manv;
        }

        private void btnngoaingu_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel5.Visible = false;

            frmCongTacNgoaiCongTy frmngoaiCY = new frmCongTacNgoaiCongTy();
            addUserControl(frmngoaiCY);

            frmngoaiCY._manv = _manv;
        }

        private void addUserControl(UserControl uc)
        {
            panel6.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            panel6.Controls.Add(uc);
        }

        private void lbmorong_Click(object sender, EventArgs e)
        {
            groupControl1.Visible = true;
            label20.Visible = true;
            lbmorong.Visible = false;
        }

        private void label20_Click(object sender, EventArgs e)
        {
            groupControl1.Visible = false;
            label20.Visible = false;
            lbmorong.Visible = true;
        }

        private void frmCongTac_Load(object sender, EventArgs e)
        {
            pictureEdit1.Image = frmNhanVien.Logo;
            lbmanv.Text = _manv.ToString();
            lbhoten.Text = _hoten.ToString();
            lbphongban.Text = _phongban.ToString();

            loaddata(_manv);
        }
    }
}
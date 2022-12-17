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
    public partial class frmQuocTich_TonGiao : DevExpress.XtraEditors.XtraForm
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public frmQuocTich_TonGiao()
        {
            InitializeComponent();
        }

        ThongTinQuocTich_BUS _ttqt;

        public int _manv;
        public string _tongiao;
        public string _dantoc;
        public bool _check;
        public bool _ckhoatdong;

        void loaddata(int mnv)
        {
            try
            {
                int manv = int.Parse(_manv.ToString());
                var item = db.tb_QuocTich.Where(x => x.MaNV == manv).SingleOrDefault();

                cbquoctich.Text = item.QuocTich;
                cbgocnguoi.Text = item.GocNguoi;
                cbthanhphangiadinh.Text = item.ThanhPhanGiaDinh;
                cbchieucao.Text = (item.ChieuCao).ToString();
                txtnhandang.Text = item.NhanDang;

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }

        }

        private void frmQuocTich_TonGiao_Load(object sender, EventArgs e)
        {
            pictureEdit1.Image = frmNhanVien.Logo;

            _ttqt = new ThongTinQuocTich_BUS();
            cbdantoc.Text = _dantoc.ToString();
            cbtongiao.Text = _tongiao.ToString();
            ckgioitinh.Checked = _check;
            ckhoatdong.Checked = _ckhoatdong;
        }

        void Savedata()
        {
            tb_QuocTich ttqt = new tb_QuocTich();
            ttqt.QuocTich = cbquoctich.Text;
            ttqt.GocNguoi = cbgocnguoi.Text;
            ttqt.MaNV = int.Parse(_manv.ToString());
            ttqt.ThanhPhanGiaDinh = cbthanhphangiadinh.Text;
            ttqt.ChieuCao = int.Parse(cbchieucao.Text);
            ttqt.NhanDang = txtnhandang.Text;
            
            _ttqt.Add(ttqt);
        }

        void Updatedata()
        {
            var ttqt = _ttqt.getItem(_manv);
            ttqt.QuocTich = cbquoctich.Text;
            ttqt.GocNguoi = cbgocnguoi.Text;
            ttqt.MaNV = int.Parse(_manv.ToString());
            ttqt.ThanhPhanGiaDinh = cbthanhphangiadinh.Text;
            ttqt.ChieuCao = int.Parse(cbchieucao.Text);
            ttqt.NhanDang = txtnhandang.Text;
            _ttqt.Update(ttqt);
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (_ttqt.check(_manv) >= 1)
            {
                MessageBox.Show("Đã có dữ liệu!", "Thông Báo");
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
            if (_ttqt.check(_manv) < 1)
            {
                MessageBox.Show("Chưa có dữ liệu!", "Thông Báo");
                return;
            }
            int id = int.Parse(_manv.ToString());
            loaddata(id);
        }
    }
}
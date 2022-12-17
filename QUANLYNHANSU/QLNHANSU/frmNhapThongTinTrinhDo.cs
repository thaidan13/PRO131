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
using BusinessLayer;
using DataLayer;

namespace QLNHANSU
{
    public partial class frmNhapThongTinTrinhDo : DevExpress.XtraEditors.XtraForm
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public frmNhapThongTinTrinhDo()
        {
            InitializeComponent();
        }

        QuaTrinhDaoTao_BUS _qtdt;
        public int _manv;
        int _Id;

        private void frmNhapThongTinTrinhDo_Load(object sender, EventArgs e)
        {
            //int id = int.Parse(_manv.ToString());
            loaddata();
            _qtdt = new QuaTrinhDaoTao_BUS();
        }

        void loaddata()
        {
            var obj = (from a in db.tb_ThongTinTrinhDo
                       where a.MaNV == _manv
                       select a).ToList();

            //var obj2 = _qtdt.getList(_manv);

            gcthongtin.DataSource = obj;
            gvthongtin.OptionsBehavior.Editable = false;
        }


        void Savedata()
        {
            tb_ThongTinTrinhDo tttd = new tb_ThongTinTrinhDo();
            tttd.TuNam = dttunam.Value;
            tttd.DenNam = dtdennam.Value;
            tttd.MaNV = int.Parse(_manv.ToString());
            tttd.CheDoHoc = cbchedohoc.Text;
            tttd.LoaiDaoTao = cbloaidaotao.Text;
            tttd.TruongDaoTao = cbtruongdaotao.Text;
            tttd.NganhDaoTao = cbnghanhdaotao.Text;
            tttd.BangCap = cbbangcap.Text;
            tttd.NoiDung = txtnoidung.Text;
            tttd.KetQua = cbketqua.Text;
            tttd.ThoiGian = txtthoigian.Text;
            tttd.ChuyenMon = txtchuyenmon.Text;
            tttd.SoBang = txtsobang.Text;
            tttd.NgayCap = dtngaycap.Value;
            tttd.QuocGia = cbquocgia.Text;

            _qtdt.Add(tttd);
        }

        void Updatedata()
        {
            _Id = int.Parse(gvthongtin.GetFocusedRowCellValue("Id").ToString());
            var tttd = _qtdt.getItem(_Id);
            tttd.TuNam = dttunam.Value;
            tttd.DenNam = dtdennam.Value;
            tttd.MaNV = int.Parse(_manv.ToString());
            tttd.CheDoHoc = cbchedohoc.Text;
            tttd.LoaiDaoTao = cbloaidaotao.Text;
            tttd.TruongDaoTao = cbtruongdaotao.Text;
            tttd.NganhDaoTao = cbnghanhdaotao.Text;
            tttd.BangCap = cbbangcap.Text;
            tttd.NoiDung = txtnoidung.Text;
            tttd.KetQua = cbketqua.Text;
            tttd.ThoiGian = txtthoigian.Text;
            tttd.ChuyenMon = txtchuyenmon.Text;
            tttd.SoBang = txtsobang.Text;
            tttd.NgayCap = dtngaycap.Value;
            tttd.QuocGia = cbquocgia.Text;
            _qtdt.Update(tttd);
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
                var tt = _qtdt.getItem(_Id);
                dttunam.Value = tt.TuNam.Value;
                dtdennam.Value= tt.DenNam.Value;
                cbchedohoc.Text = tt.CheDoHoc;
                cbloaidaotao.Text = tt.LoaiDaoTao;
                cbtruongdaotao.Text = tt.TruongDaoTao;
                cbnghanhdaotao.Text = tt.NganhDaoTao;
                cbbangcap.Text = tt.BangCap;
                txtnoidung.Text = tt.NoiDung;
                cbketqua.Text = tt.KetQua;
                txtthoigian.Text = tt.ThoiGian;
                txtchuyenmon.Text = tt.ChuyenMon;
                txtsobang.Text = tt.SoBang;
                dtngaycap.Value = tt.NgayCap.Value;
                cbquocgia.Text = tt.QuocGia;
            }
        }
    }
}
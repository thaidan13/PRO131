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
    public partial class frmQuaTrinhDaoTaoMoi : DevExpress.XtraEditors.XtraForm
    {
        public frmQuaTrinhDaoTaoMoi()
        {
            InitializeComponent();
        }

        QuaTrinhDaoTaoMoi_BUS _dtc;
        public int _manv;
        public string _hoten;
        int _Id;

        private void frmQuaTrinhDaoTaoMoi_Load(object sender, EventArgs e)
        {
            txtnhanvien.Text = _hoten;
            _dtc = new QuaTrinhDaoTaoMoi_BUS();
            loaddata();
        }

        void loaddata()
        {
            //var obj = (from a in db.tb_ThongTinViTinh
            //           where a.MaNV == _manv
            //           select a).ToList();

            var obj2 = _dtc.getList(_manv);

            gcthongtin.DataSource = obj2;
            gvthongtin.OptionsBehavior.Editable = false;
        }

        void Savedata()
        {
            tb_QuaTrinhDaoTaoMoi dtc = new tb_QuaTrinhDaoTaoMoi();

            dtc.MaNV = int.Parse(_manv.ToString());
            dtc.HoTen = _hoten;
            dtc.KhoaHoc = txtnoidung.Text;
            dtc.Truong_DonVi = txtnoidaotao.Text;
            dtc.HoanTat = ckhoantat.Checked;
            dtc.Bang = txtdangbang.Text;
            dtc.NgayBatDau = dtbatdau.Value;
            dtc.NgayKetThuc = dtketthuc.Value;
            dtc.SoQuyetDinh = txtsoquyetdinh.Text;
            dtc.HinhThuc = txthinhthuc.Text;
            dtc.TenBang = txttenbang.Text;
            dtc.SoBang = txtsobang.Text;
            dtc.DangBang = txtdangbang.Text;
            dtc.NgayCap = dtngaycap.Value;
            dtc.HetHan = ckhethan.Checked;
            dtc.KetQua = txtketqua.Text;
            dtc.DiaDiem = txtdiachi.Text;
            dtc.GhiChu = txtghichu.Text;

            _dtc.Add(dtc);
            loaddata();
        }

        void Updatedata()
        {
            _Id = int.Parse(gvthongtin.GetFocusedRowCellValue("Id").ToString());
            //var tt = _dtc.getItem(_Id);
            var dtc = _dtc.getItem(_Id);
            dtc.MaNV = int.Parse(_manv.ToString());
            dtc.HoTen = _hoten;
            dtc.KhoaHoc = txtnoidung.Text;
            dtc.Truong_DonVi = txtnoidaotao.Text;
            dtc.HoanTat = ckhoantat.Checked;
            dtc.Bang = txtdangbang.Text;
            dtc.NgayBatDau = dtbatdau.Value;
            dtc.NgayKetThuc = dtketthuc.Value;
            dtc.SoQuyetDinh = txtsoquyetdinh.Text;
            dtc.HinhThuc = txthinhthuc.Text;
            dtc.TenBang = txttenbang.Text;
            dtc.SoBang = txtsobang.Text;
            dtc.DangBang = txtdangbang.Text;
            dtc.NgayCap = dtngaycap.Value;
            dtc.HetHan = ckhethan.Checked;
            dtc.KetQua = txtketqua.Text;
            dtc.DiaDiem = txtdiachi.Text;
            dtc.GhiChu = txtghichu.Text;
            _dtc.Update(dtc);
            loaddata();
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
                var tt = _dtc.getItem(_Id);

                txtnoidung.Text = tt.KhoaHoc;
                txtnoidaotao.Text = tt.Truong_DonVi;
                ckhoantat.Checked = tt.HoanTat.Value;
                txtdangbang.Text = tt.DangBang;
                dtbatdau.Value = tt.NgayBatDau.Value;
                dtketthuc.Value = tt.NgayKetThuc.Value;
                txtsoquyetdinh.Text = tt.SoQuyetDinh;
                txthinhthuc.Text = tt.HinhThuc;
                txttenbang.Text = tt.TenBang;
                txtsobang.Text = tt.SoBang;
                txtdangbang.Text = tt.DangBang;
                dtngaycap.Value = tt.NgayCap.Value;
                ckhethan.Checked = tt.HetHan.Value;
                txtketqua.Text = tt.KetQua;
                txtdiachi.Text = tt.DiaDiem;
                txtghichu.Text = tt.GhiChu;
            }
        }
    }
}
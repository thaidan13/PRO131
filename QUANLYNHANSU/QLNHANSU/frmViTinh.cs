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
    public partial class frmViTinh : DevExpress.XtraEditors.XtraForm
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public frmViTinh()
        {
            InitializeComponent();
        }

        ViTinh_BUS _ttvt;
        public int _manv;
        int _Id;

        private void frmViTinh_Load(object sender, EventArgs e)
        {
            _ttvt = new ViTinh_BUS();
            loaddata();
        }

        void loaddata()
        {
            var obj = (from a in db.tb_ThongTinViTinh
                       where a.MaNV == _manv
                       select a).ToList();

            var obj2 = _ttvt.getList(_manv);

            gcthongtin.DataSource = obj2;
            gvthongtin.OptionsBehavior.Editable = false;
        }

        void Savedata()
        {
            tb_ThongTinViTinh ttvt = new tb_ThongTinViTinh();
            
            ttvt.MaNV = int.Parse(_manv.ToString());
            ttvt.SoBang = int.Parse(cbsobang.Text);
            ttvt.BangCap = cbbangcap.Text;
            ttvt.NgayCap = dtngaycap.Value;
            ttvt.KinhPhi = double.Parse(txtkinhphi.Text);
            ttvt.NguonKinhPhi = txtnguonkinhphi.Text;
            ttvt.NoiDung = txtnoidung.Text;
            ttvt.CheDoHoc = cbchedohoc.Text;
            ttvt.TuNgay = dttungay.Value;
            ttvt.DenNgay = dtdenngay.Value;
            ttvt.NgayCap = dtngaycap.Value;

            _ttvt.Add(ttvt);
            loaddata();
        }

        void Updatedata()
        {
            var ttvt = _ttvt.getItem(_manv);
            ttvt.MaNV = int.Parse(_manv.ToString());
            ttvt.BangCap = cbbangcap.Text;
            ttvt.NgayCap = dtngaycap.Value;
            ttvt.KinhPhi = double.Parse(txtkinhphi.Text);
            ttvt.SoBang = int.Parse(cbsobang.Text);
            ttvt.NguonKinhPhi = txtnguonkinhphi.Text;
            ttvt.NoiDung = txtnoidung.Text;
            ttvt.CheDoHoc = cbchedohoc.Text;
            ttvt.TuNgay = dttungay.Value;
            ttvt.DenNgay = dtdenngay.Value;
            ttvt.NgayCap = dtngaycap.Value;
            _ttvt.Update(ttvt);
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
                var tt = _ttvt.getItem(_Id);
                cbbangcap.Text = tt.BangCap;
                dtngaycap.Value = tt.NgayCap.Value;
                txtkinhphi.Text = tt.KinhPhi.ToString();
                txtnguonkinhphi.Text = tt.NguonKinhPhi;
                txtnoidung.Text = tt.NoiDung;
                cbchedohoc.Text = tt.CheDoHoc;
                dttungay.Value = tt.TuNgay.Value;
                dtdenngay.Value = tt.DenNgay.Value;
                cbsobang.Text = tt.SoBang.ToString();
                
            }
        }
    }
}
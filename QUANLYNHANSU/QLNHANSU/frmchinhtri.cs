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
    public partial class frmchinhtri : DevExpress.XtraEditors.XtraForm
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public frmchinhtri()
        {
            InitializeComponent();
        }

        ChinhTri_BUS _ttct;
        public int _manv;
        int _Id;

        private void frmchinhtri_Load(object sender, EventArgs e)
        {
            _ttct = new ChinhTri_BUS();
            loaddata();
        }

        void loaddata()
        {
            var obj = (from a in db.tb_ThongTinChinhTri
                       where a.MaNV == _manv
                       select a).ToList();

            gcthongtin.DataSource = obj;
            gvthongtin.OptionsBehavior.Editable = false;
        }

        void Savedata()
        {
            tb_ThongTinChinhTri ttct = new tb_ThongTinChinhTri();
           
            ttct.MaNV = int.Parse(_manv.ToString());
            ttct.TrinhDoChinhTri = cbtrinhdochinhtri.Text;
            ttct.NgayCap = dtngaycap.Value;
            ttct.KinhPhi = double.Parse(txtkinhphi.Text);
            ttct.NguonKinhPhi = txtnguonkinhphi.Text;
            ttct.CheDoHoc = cbchedohoc.Text;
            ttct.TuNgay = dttungay.Value;
            ttct.DenNgay = dtdenngay.Value;

            _ttct.Add(ttct);
        }

        void Updatedata()
        {
            _Id = int.Parse(gvthongtin.GetFocusedRowCellValue("Id").ToString());
            var ttct = _ttct.getItem(_Id);
            ttct.MaNV = int.Parse(_manv.ToString());
            ttct.TrinhDoChinhTri = cbtrinhdochinhtri.Text;
            ttct.NgayCap = dtngaycap.Value;
            ttct.KinhPhi = double.Parse(txtkinhphi.Text);
            ttct.NguonKinhPhi = txtnguonkinhphi.Text;
            ttct.CheDoHoc = cbchedohoc.Text;
            ttct.TuNgay = dttungay.Value;
            ttct.DenNgay = dtdenngay.Value;
            _ttct.Update(ttct);
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
            MessageBox.Show("Đã cập nhật thành công!", "Thông Báo");
            loaddata();
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
                var tt = _ttct.getItem(_Id);
                cbtrinhdochinhtri.Text = tt.TrinhDoChinhTri;
                dtngaycap.Value = tt.NgayCap.Value;
                txtkinhphi.Text = tt.KinhPhi.ToString();
                txtnguonkinhphi.Text = tt.NguonKinhPhi;
                cbchedohoc.Text = tt.CheDoHoc;
                dttungay.Value = tt.TuNgay.Value;
                dtdenngay.Value = tt.DenNgay.Value;
            }
        }
    }
}
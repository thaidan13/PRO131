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
    public partial class frmDiNuocNgoai : DevExpress.XtraEditors.XtraForm
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        public frmDiNuocNgoai()
        {
            InitializeComponent();
        }

        #region Biến toàn cục
        DiNuocNgoai_BUS _dnn;

        int _Id;
        public int _manv;
        public string _hoten;
        public string _phongban;
        public string _email;
        public string _dienthoainha;
        public string _dtdd;
        #endregion

        #region METHOS
        void loaddata(int mnv)
        {
            try
            {
                int manv = int.Parse(_manv.ToString());
                var item = db.tb_DienThoaiLienHe.Where(x => x.MaNV == manv).SingleOrDefault();

                if (_dnn.checkthongtinlienlac(manv) < 1)
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

        void loaddataNV()
        {
            var obj = (from a in db.tb_NVDiNuocNgoai
                       where a.MaNV == _manv
                       select a).ToList();

            var obj2 = _dnn.getList(_manv);

            gcThongTin.DataSource = obj2;
            gvThongTin.OptionsBehavior.Editable = false;
        }

        void Savedata()
        {
            tb_NVDiNuocNgoai ttdnn = new tb_NVDiNuocNgoai();

            ttdnn.MaNV = int.Parse(_manv.ToString());
            ttdnn.NgayDi = dtngaydi.Value;
            ttdnn.NgayVe = dtngayve.Value;
            ttdnn.ThoiGian = cbquocgiaden.Text;
            ttdnn.QuocGiaDen = cbquocgiaden.Text;
            ttdnn.MucDich = txtmucdich.Text;

            _dnn.Add(ttdnn);
            loaddataNV();
        }

        void Updatedata()
        {
            tb_NVDiNuocNgoai ttdnn = new tb_NVDiNuocNgoai();

            var dnn = _dnn.getItem(_manv);
            dnn.MaNV = int.Parse(_manv.ToString());
            dnn.NgayDi = dtngaydi.Value;
            dnn.NgayVe = dtngayve.Value;
            dnn.ThoiGian = txtthoigian.Text;
            dnn.QuocGiaDen = cbquocgiaden.Text;
            dnn.MucDich = txtmucdich.Text;
            _dnn.Update(dnn);
            loaddataNV();
        }
        #endregion

        #region EVEN

        private void frmDiNuocNgoai_Load(object sender, EventArgs e)
        {
            _dnn = new DiNuocNgoai_BUS();

            pictureEdit1.Image = frmNhanVien.Logo;
            lbmanv.Text = _manv.ToString();
            lbhoten.Text = _hoten.ToString();
            lbphongban.Text = _phongban.ToString();

            loaddata(_manv);
            loaddataNV();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            Savedata();
            MessageBox.Show("Đã cập nhật thành công!", "Thông Báo");
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            Updatedata();
            MessageBox.Show("Đã cập nhật thành công!", "Thông Báo");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gcThongTin_Click(object sender, EventArgs e)
        {
            if (gvThongTin.RowCount > 0)
            {
                _Id = int.Parse(gvThongTin.GetFocusedRowCellValue("Id").ToString());
                var tt = _dnn.getItem(_Id);
                dtngaydi.Value = tt.NgayDi.Value;
                dtngayve.Value = tt.NgayVe.Value;
                cbquocgiaden.Text = tt.QuocGiaDen;
                txtthoigian.Text = tt.ThoiGian;
                txtmucdich.Text = tt.MucDich;

            }
        }

        #endregion
    }
}
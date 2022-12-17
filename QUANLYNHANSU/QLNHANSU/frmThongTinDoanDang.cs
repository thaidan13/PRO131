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
    public partial class frmThongTinDoanDang : DevExpress.XtraEditors.XtraForm
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        public frmThongTinDoanDang()
        {
            InitializeComponent();
        }

        ThongTinDoanDang_BUS _ttdd;

        public int _manv;
        public string _hoten;
        public string _phongban;
        public string _email;
        public string _dienthoainha;
        public string _dtdd;

        private void frmThongTinDoanDang_Load(object sender, EventArgs e)
        {
            _ttdd = new ThongTinDoanDang_BUS();

            pictureEdit1.Image = frmNhanVien.Logo;
            lbmanv.Text = _manv.ToString();
            lbhoten.Text = _hoten.ToString();
            lbphongban.Text = _phongban.ToString();
            loaddata(_manv);
        }

        void loaddata(int mnv)
        {
            try
            {
                int manv = int.Parse(_manv.ToString());
                var item = db.tb_DienThoaiLienHe.Where(x => x.MaNV == manv).SingleOrDefault();

                if(_ttdd.check(manv) < 1)
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

        void loaddataALL(int mnv)
        {
            try
            {
                //int manv = int.Parse(_manv.ToString());
                //var item = db.tb_Dang_Doan.Where(x => x.MaNV == manv).SingleOrDefault();

                //txtsothedoan.Text = item.SoTheDoan;
                //dngaycapthe.Value = item.NgayCapThe.Value;
                //ckdavaodang.Checked = item.DaVaoDang.Value;
                //ckdavaodoan.Checked = item.DaVaoDoan.Value;
                //dtngayvaolan1.Value = item.NgayVaoDangLan1.Value;
                //dtngaychinhthuc1.Value = item.NgayChinhThucLan1.Value;
                //dtngayvaolan2.Value = item.NgayVaoDangLan2.Value;
                //dtngaychinhthuc2.Value = item.NgayChinhThucLan2.Value;
                //dtngayvaodoan.Value = item.NgayVaoDoan.Value;

                int manv = int.Parse(_manv.ToString());
                var item = (from a in db.tb_Dang_Doan
                           join b in db.tb_BoDoi
                           on a.MaNV equals b.MaNV
                           join c in db.tb_NguoiGTVaoDang
                           on a.MaNV equals c.MaNV
                           select new
                           {
                               sothedoan = a.SoTheDoan,
                               manv = a.MaNV,
                               ngaycapthe = a.NgayCapThe,
                               davaodang = a.DaVaoDang,
                               davaodoan = a.DaVaoDoan,
                               ngayvaodanglan1 = a.NgayVaoDangLan1,
                               ngaychinhthuc1 = a.NgayChinhThucLan1,
                               ngayvaodanglan2 = a.NgayVaoDangLan2,
                               ngaychinhthuc2 = a.NgayChinhThucLan2,
                               ngayvaodoan = a.NgayVaoDoan,
                               ngaynhapngu = b.NgayNhapNgu,
                               ngayxuatngu = b.NgayXuatNgu,
                               quanhamchucvucaonhat = b.QuanHamChucVuCaoNhat,
                               danhhieuduocphong = b.DanhHieuDuocPhong,
                               sotruong = b.SoTruong,
                               nguoithunhat = c.NguoiThuNhat,
                               nguoithuhai = c.NguoiThuHai,
                               chucvu = c.ChucVu,
                               chucvu1 = c.ChucVu1,
                               diachi = c.DiaChi,
                               diachi2 = c.DiaChi2
                           }).Where(x => x.manv == manv).SingleOrDefault();
                txtsothedoan.Text = item.sothedoan;
                dngaycapthe.Value = item.ngaycapthe.Value;
                ckdavaodang.Checked = item.davaodang.Value;
                ckdavaodoan.Checked = item.davaodoan.Value;
                dtngayvaolan1.Value = item.ngayvaodanglan1.Value;
                dtngaychinhthuc1.Value = item.ngaychinhthuc1.Value;
                dtngayvaolan2.Value = item.ngayvaodanglan2.Value;
                dtngaychinhthuc2.Value = item.ngaychinhthuc2.Value;
                dtngayvaodoan.Value = item.ngayvaodoan.Value;

                txtnguoithunhat.Text = item.nguoithunhat;
                txtchucvu1.Text = item.chucvu;
                txtdiachi1.Text = item.diachi;
                txtnguoithuhai.Text = item.nguoithuhai;
                txtchucvu2.Text = item.chucvu1;
                txtdiachi2.Text = item.diachi2;

                dtngaynhapngu.Value = item.ngaynhapngu.Value;
                dtngayxuatngu.Value = item.ngayxuatngu.Value;
                txtquanham.Text = item.quanhamchucvucaonhat;
                txtdanhhieu.Text = item.danhhieuduocphong;
                txtsotruong.Text = item.sotruong;

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
            


        }

        void Savedata()
        {
            tb_Dang_Doan ttdd = new tb_Dang_Doan();
            ttdd.SoTheDoan = txtsothedoan.Text;
            ttdd.NgayCapThe = dngaycapthe.Value;
            ttdd.MaNV = int.Parse(_manv.ToString());
            ttdd.DaVaoDoan = ckdavaodoan.Checked;
            ttdd.NgayVaoDangLan1 = dtngayvaolan1.Value;
            ttdd.NgayChinhThucLan1 = dtngaychinhthuc1.Value;
            ttdd.NgayVaoDangLan2 = dtngayvaolan2.Value;
            ttdd.NgayChinhThucLan2 = dtngaychinhthuc2.Value;
            ttdd.NgayVaoDoan = dtngayvaodoan.Value;
            ttdd.DaVaoDang = ckdavaodang.Checked;

            tb_BoDoi ttbd = new tb_BoDoi();
            ttbd.MaNV = int.Parse(_manv.ToString());
            ttbd.NgayNhapNgu = dtngaynhapngu.Value;
            ttbd.NgayXuatNgu = dtngayxuatngu.Value;
            ttbd.QuanHamChucVuCaoNhat = txtquanham.Text;
            ttbd.DanhHieuDuocPhong = txtdanhhieu.Text;
            ttbd.SoTruong = txtsotruong.Text;

            tb_NguoiGTVaoDang ttnggt = new tb_NguoiGTVaoDang();
            ttnggt.MaNV = int.Parse(_manv.ToString());
            ttnggt.NguoiThuNhat = txtnguoithunhat.Text;
            ttnggt.NguoiThuHai = txtnguoithuhai.Text;
            ttnggt.ChucVu = txtchucvu1.Text;
            ttnggt.ChucVu1 = txtchucvu2.Text;
            ttnggt.DiaChi = txtdiachi1.Text;
            ttnggt.DiaChi2 = txtdiachi2.Text;


            _ttdd.Add_Dang_Doan(ttdd);
            _ttdd.Add_Bo_Doi(ttbd);
            _ttdd.Add_NguoiGT(ttnggt);
        }

        void Updatedata()
        {
            var ttdd = _ttdd.getItem_Dang_Doan(_manv);
            ttdd.SoTheDoan = txtsothedoan.Text;
            ttdd.NgayCapThe = dngaycapthe.Value;
            ttdd.MaNV = int.Parse(_manv.ToString());
            ttdd.DaVaoDoan = ckdavaodoan.Checked;
            ttdd.NgayVaoDangLan1 = dtngayvaolan1.Value;
            ttdd.NgayChinhThucLan1 = dtngaychinhthuc1.Value;
            ttdd.NgayVaoDangLan2 = dtngayvaolan2.Value;
            ttdd.NgayChinhThucLan2 = dtngaychinhthuc2.Value;
            ttdd.NgayVaoDoan = dtngayvaodoan.Value;
            ttdd.DaVaoDang = ckdavaodang.Checked;

            var ttbd = _ttdd.getItem_BoDoi(_manv);
            ttbd.MaNV = int.Parse(_manv.ToString());
            ttbd.NgayNhapNgu = dtngaynhapngu.Value;
            ttbd.NgayXuatNgu = dtngayxuatngu.Value;
            ttbd.QuanHamChucVuCaoNhat = txtquanham.Text;
            ttbd.DanhHieuDuocPhong = txtdanhhieu.Text;
            ttbd.SoTruong = txtsotruong.Text;

            var ttnggt = _ttdd.getItem_NguoiGT(_manv);
            ttnggt.MaNV = int.Parse(_manv.ToString());
            ttnggt.NguoiThuNhat = txtnguoithunhat.Text;
            ttnggt.NguoiThuHai = txtnguoithuhai.Text;
            ttnggt.ChucVu = txtchucvu1.Text;
            ttnggt.ChucVu1 = txtchucvu2.Text;
            ttnggt.DiaChi = txtdiachi1.Text;
            ttnggt.DiaChi2 = txtdiachi2.Text;

            _ttdd.Update_Dang_Doan(ttdd);
            _ttdd.Update_BoDoi(ttbd);
            _ttdd.Update_NguoiGT(ttnggt);

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if(_ttdd.check(_manv) >= 1)
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

        private void btnxemthongtin_Click(object sender, EventArgs e)
        {
            if(_ttdd.check(_manv) < 1)
            {
                MessageBox.Show("Chưa để hiển thị có dữ liệu!", "Thông Báo");
                return;
            }
            //btnluu.Enabled = false;
            int id = int.Parse(lbmanv.Text);
            loaddataALL(id);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
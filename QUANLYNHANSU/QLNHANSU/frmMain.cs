using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNHANSU.ChamCong;
using DevExpress.XtraSplashScreen;

namespace QLNHANSU
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string vaitro = "";

        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(string email, string pass, string vaitro)
        {
            InitializeComponent();
            this.vaitro = vaitro;
            
        }

        void openForm(Type typeForm)
        {
            foreach (var frm in MdiChildren)
            {
                if (frm.GetType() == typeForm)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (vaitro == "KeToan")
            {
                ribbonPage2.Visible = false;
                ribbonPage3.Visible = true;
            }
            else if(vaitro == "Admin")
            {
                ribbonPage3.Visible = true;
                ribbonPage2.Visible = true;
            }
            else if(vaitro == null)
            {
                ribbonPage3.Visible = false;
                ribbonPage2.Visible = false;
            }
            ribbon.SelectedPage = ribbonPage2;
            
        }

        private void btnDanToc_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmDanToc));
        }

        private void btnTonGiao_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmTonGiao));
        }

        private void btnTrinhDo_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmTrinhDo));
        }

        private void btnPhongBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmPhongBan));
        }

        private void btncongty_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmCongTy));
        }

        private void btnbophan_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmBoPhan));
        }

        private void btnchucvu_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmChucVu));
        }

        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmWaiting), true, true);
            openForm(typeof(frmNhanVien));
            SplashScreenManager.CloseForm();
        }

        private void btnHopDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmWaiting), true, true);
            openForm(typeof(frmHopDongLaoDong));
            SplashScreenManager.CloseForm();
        }

        private void btnKhenThuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmKhenThuong));
        }

        private void btnkyluat_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmKyLuat));
        }

        private void btnDieuKhien_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmDieuChuyen));
        }

        private void btnThoiViec_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmNhanVien_ThoiViec));
        }

        private void btnLoaiCa_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmLC));
        }

        private void btnLoaiCong_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmLoaiCong));
        }

        private void btnnangluong_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmNangLuong));
        }

        private void btnBangCong_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmBangCong));
        }

        private void btnPhuCap_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmPhuCap));
        }

        private void btndangnhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmDangNhap));
            //frmDangNhap frmdn = new frmDangNhap();
            //frmdn.ShowDialog();
        }

        void checkQuyen(string quyen)
        {
            
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            
        }
    }
}
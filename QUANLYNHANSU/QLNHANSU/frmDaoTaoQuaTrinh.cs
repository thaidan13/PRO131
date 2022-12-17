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

namespace QLNHANSU
{
    public partial class frmDaoTaoQuaTrinh : DevExpress.XtraEditors.XtraForm
    {
        public frmDaoTaoQuaTrinh()
        {
            InitializeComponent();
        }

        //int _Id;
        public int _manv;
        public string _hoten;
        public string _phongban;
        public string _email;
        public string _dienthoainha;
        public string _dtdd;

        private void frmDaoTaoQuaTrinh_Load(object sender, EventArgs e)
        {
            pictureEdit1.Image = frmNhanVien.Logo;
            lbmanv.Text = _manv.ToString();
            lbhoten.Text = _hoten.ToString();
            lbphongban.Text = _phongban.ToString();
        }

        private void btnquatrinhdaotaocu_Click(object sender, EventArgs e)
        {
            frmQuaTrinhDaoTaoCu frmdaotaocu = new frmQuaTrinhDaoTaoCu();

            frmdaotaocu._manv = _manv;
            frmdaotaocu._hoten = _hoten;
            frmdaotaocu.ShowDialog();
        }

        private void btnquatrinhdaotaomoi_Click(object sender, EventArgs e)
        {
            frmQuaTrinhDaoTaoMoi frmdaotaomoi = new frmQuaTrinhDaoTaoMoi();

            frmdaotaomoi._manv = _manv;
            frmdaotaomoi._hoten = _hoten;
            frmdaotaomoi.ShowDialog();
        }
    }
}
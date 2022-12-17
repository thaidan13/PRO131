using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.DAL;
using BusinessLayer.DTO;
using BusinessLayer;
using System.Net.Mail;
using System.Net;

namespace QLNHANSU
{
    public partial class frmDangNhap : KryptonForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        TaiKhoan_DTO taikhoan_dto = new TaiKhoan_DTO();
        DangNhap_BUS dangnhap_bus = new DangNhap_BUS();
        public string vaitro { set; get; }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            TaiKhoan_DTO nv = new TaiKhoan_DTO();
            nv.EMAIL = txtemail.Text;
            nv.MATKHAU = (txtmatkhau.Text);// ma mat khau de so sanh voi mat khau da ma hoa trong csdl
            if (dangnhap_bus.NhanVienDangNhap(nv))//successfull login
            {
                Properties.Settings.Default.isSave = tglRememberMe.Checked;
                if (tglRememberMe.Checked)
                {
                    Properties.Settings.Default.email = txtemail.Text;
                    Properties.Settings.Default.password = txtmatkhau.Text;
                }
                Properties.Settings.Default.Save();


                DataTable dt = dangnhap_bus.VaiTroNhanVien(nv.EMAIL);
                vaitro = dt.Rows[0][0].ToString();
                frmMain main = new frmMain(txtemail.Text, txtmatkhau.Text, dt.Rows[0][0].ToString());
                

                //frmMain main = new frmMain();
                //this.Hide();
                main.ShowDialog();
                //this.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công, kiểm tra lại email hoặc mật khẩu");
                txtemail.Text = null;
                txtmatkhau.Text = null;
                txtemail.Focus();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isSave)
            {
                txtemail.Text = Properties.Settings.Default.email;
                txtmatkhau.Text = Properties.Settings.Default.password;
                tglRememberMe.Checked = true;
            }
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        public void SendMail(string email, string matkhau)
        {
            try
            {
                string from, to, pass, content;
                from = "quynhngo030502@gmail.com";
                to = txtemail.Text.Trim();
                pass = "ngoquynh020503";
                content = "Mật khẩu mới của anh/chị là " + matkhau;

                MailMessage mail = new MailMessage();
                mail.To.Add(to);
                mail.From = new MailAddress(from);
                mail.Subject = "Test send email C#";
                mail.Body = content;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                smtp.Credentials = new System.Net.NetworkCredential("quynhngo030502@gmail.com", "cxsnpvrgqikrodia");
                try
                {
                    smtp.Send(mail);
                    MessageBox.Show("Email sent successfully.", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // If Mail Doesnt Send Error Mesage Will Be Displayed
                MessageBox.Show(ex.Message);
            }
        }

        private void labelQuenMatKhau_Click(object sender, EventArgs e)
        {
            if (txtemail.Text != "")
            {
                if (dangnhap_bus.NhanVienQuenMatKhau(txtemail.Text))//show form input email. If true will send pass random
                {
                    StringBuilder builder = new StringBuilder();
                    builder.Append(RandomString(4, true));
                    builder.Append(RandomNumber(1000, 9999));
                    builder.Append(RandomString(2, false));
                    //MessageBox.Show(builder.ToString());
                    string matkhaumoi = (builder.ToString());
                    dangnhap_bus.TaoMauKhau(txtemail.Text, matkhaumoi);// update new pass to database
                    SendMail(txtemail.Text, builder.ToString());// send new pass to email
                }
                else
                {
                    MessageBox.Show("Email không tồn tại, vui lòng nhập lại email!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Bạn cần cập nhập email để đổi mật khẩu", "Thông báo");
                txtemail.Focus();
            }
        }
    }
}


namespace QLNHANSU
{
    partial class frmCapNhatNgayCong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapNhatNgayCong));
            this.btncapnhat = new DevExpress.XtraEditors.SimpleButton();
            this.cldngaycong = new System.Windows.Forms.MonthCalendar();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rdgchamcong = new DevExpress.XtraEditors.RadioGroup();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.rdgthoigiannghi = new DevExpress.XtraEditors.RadioGroup();
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbhoten = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgchamcong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgthoigiannghi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncapnhat
            // 
            this.btncapnhat.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncapnhat.Appearance.Options.UseFont = true;
            this.btncapnhat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btncapnhat.ImageOptions.SvgImage")));
            this.btncapnhat.Location = new System.Drawing.Point(285, 281);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(123, 51);
            this.btncapnhat.TabIndex = 0;
            this.btncapnhat.Text = "Cập Nhật";
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // cldngaycong
            // 
            this.cldngaycong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cldngaycong.Location = new System.Drawing.Point(9, 4);
            this.cldngaycong.Name = "cldngaycong";
            this.cldngaycong.TabIndex = 1;
            this.cldngaycong.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.cldngaycong_DateSelected);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Blue;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.rdgchamcong);
            this.groupControl1.Location = new System.Drawing.Point(285, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(238, 138);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Chấm Công";
            // 
            // rdgchamcong
            // 
            this.rdgchamcong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdgchamcong.EditValue = "P";
            this.rdgchamcong.Location = new System.Drawing.Point(2, 28);
            this.rdgchamcong.Name = "rdgchamcong";
            this.rdgchamcong.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Nghỉ Phép"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("V", "Vắng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("VR", "Việc Riêng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("CT", "Công Tác")});
            this.rdgchamcong.Size = new System.Drawing.Size(234, 108);
            this.rdgchamcong.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Blue;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add(this.rdgthoigiannghi);
            this.groupControl2.Location = new System.Drawing.Point(283, 154);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(242, 107);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Thời Gian Nghỉ";
            // 
            // rdgthoigiannghi
            // 
            this.rdgthoigiannghi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdgthoigiannghi.EditValue = "S";
            this.rdgthoigiannghi.Location = new System.Drawing.Point(2, 28);
            this.rdgthoigiannghi.Name = "rdgthoigiannghi";
            this.rdgthoigiannghi.Properties.Columns = 2;
            this.rdgthoigiannghi.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Sáng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("C", "Chiều"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("NN", "Nguyên Ngày")});
            this.rdgthoigiannghi.Size = new System.Drawing.Size(238, 77);
            this.rdgthoigiannghi.TabIndex = 0;
            // 
            // btnthoat
            // 
            this.btnthoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Appearance.Options.UseFont = true;
            this.btnthoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnthoat.ImageOptions.SvgImage")));
            this.btnthoat.Location = new System.Drawing.Point(416, 281);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(109, 51);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.Blue;
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl3.Controls.Add(this.lbhoten);
            this.groupControl3.Controls.Add(this.label2);
            this.groupControl3.Controls.Add(this.lbid);
            this.groupControl3.Controls.Add(this.label1);
            this.groupControl3.Location = new System.Drawing.Point(12, 223);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(259, 109);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "Thông Tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbid.ForeColor = System.Drawing.Color.Red;
            this.lbid.Location = new System.Drawing.Point(90, 32);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(33, 19);
            this.lbid.TabIndex = 1;
            this.lbid.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Tên:";
            // 
            // lbhoten
            // 
            this.lbhoten.AutoSize = true;
            this.lbhoten.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhoten.ForeColor = System.Drawing.Color.Red;
            this.lbhoten.Location = new System.Drawing.Point(90, 58);
            this.lbhoten.Name = "lbhoten";
            this.lbhoten.Size = new System.Drawing.Size(56, 19);
            this.lbhoten.TabIndex = 3;
            this.lbhoten.Text = "HoTen";
            // 
            // frmCapNhatNgayCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 354);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.cldngaycong);
            this.Controls.Add(this.btncapnhat);
            this.Name = "frmCapNhatNgayCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Ngày Công";
            this.Load += new System.EventHandler(this.frmCapNhatNgayCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdgchamcong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdgthoigiannghi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btncapnhat;
        private System.Windows.Forms.MonthCalendar cldngaycong;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.RadioGroup rdgchamcong;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.RadioGroup rdgthoigiannghi;
        private DevExpress.XtraEditors.SimpleButton btnthoat;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Label lbhoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Label label1;
    }
}
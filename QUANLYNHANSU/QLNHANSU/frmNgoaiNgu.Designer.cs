
namespace QLNHANSU
{
    partial class frmNgoaiNgu
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbngoaingu = new System.Windows.Forms.ComboBox();
            this.ckchinhphu = new System.Windows.Forms.CheckBox();
            this.dtngaycap = new System.Windows.Forms.DateTimePicker();
            this.cbbangcap = new System.Windows.Forms.ComboBox();
            this.txtghichu = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnguonkinhphi = new System.Windows.Forms.RichTextBox();
            this.cbkinhphi = new System.Windows.Forms.ComboBox();
            this.cbketqua = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gcthongtin = new DevExpress.XtraGrid.GridControl();
            this.gvthongtin = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NgoaiNgu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BangCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KetQua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KinhPhi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChinhPhu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguonKinhPhi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            this.btncapnhat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcthongtin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvthongtin)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.cbngoaingu);
            this.groupControl1.Controls.Add(this.ckchinhphu);
            this.groupControl1.Controls.Add(this.dtngaycap);
            this.groupControl1.Controls.Add(this.cbbangcap);
            this.groupControl1.Controls.Add(this.txtghichu);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.txtnguonkinhphi);
            this.groupControl1.Controls.Add(this.cbkinhphi);
            this.groupControl1.Controls.Add(this.cbketqua);
            this.groupControl1.Controls.Add(this.label15);
            this.groupControl1.Controls.Add(this.label14);
            this.groupControl1.Controls.Add(this.label12);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(963, 393);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // cbngoaingu
            // 
            this.cbngoaingu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbngoaingu.FormattingEnabled = true;
            this.cbngoaingu.Location = new System.Drawing.Point(170, 53);
            this.cbngoaingu.Name = "cbngoaingu";
            this.cbngoaingu.Size = new System.Drawing.Size(254, 27);
            this.cbngoaingu.TabIndex = 82;
            // 
            // ckchinhphu
            // 
            this.ckchinhphu.AutoSize = true;
            this.ckchinhphu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckchinhphu.Location = new System.Drawing.Point(619, 156);
            this.ckchinhphu.Name = "ckchinhphu";
            this.ckchinhphu.Size = new System.Drawing.Size(110, 23);
            this.ckchinhphu.TabIndex = 81;
            this.ckchinhphu.Text = "Chính/Phụ";
            this.ckchinhphu.UseVisualStyleBackColor = true;
            // 
            // dtngaycap
            // 
            this.dtngaycap.CustomFormat = "dd/MM/yyyy";
            this.dtngaycap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtngaycap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngaycap.Location = new System.Drawing.Point(619, 101);
            this.dtngaycap.Name = "dtngaycap";
            this.dtngaycap.Size = new System.Drawing.Size(254, 27);
            this.dtngaycap.TabIndex = 80;
            // 
            // cbbangcap
            // 
            this.cbbangcap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbangcap.FormattingEnabled = true;
            this.cbbangcap.Location = new System.Drawing.Point(619, 53);
            this.cbbangcap.Name = "cbbangcap";
            this.cbbangcap.Size = new System.Drawing.Size(254, 27);
            this.cbbangcap.TabIndex = 79;
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(170, 285);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(703, 43);
            this.txtghichu.TabIndex = 78;
            this.txtghichu.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(80, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 77;
            this.label8.Text = "Ghi Chú";
            // 
            // txtnguonkinhphi
            // 
            this.txtnguonkinhphi.Location = new System.Drawing.Point(170, 208);
            this.txtnguonkinhphi.Name = "txtnguonkinhphi";
            this.txtnguonkinhphi.Size = new System.Drawing.Size(703, 43);
            this.txtnguonkinhphi.TabIndex = 68;
            this.txtnguonkinhphi.Text = "";
            // 
            // cbkinhphi
            // 
            this.cbkinhphi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbkinhphi.FormattingEnabled = true;
            this.cbkinhphi.Location = new System.Drawing.Point(170, 148);
            this.cbkinhphi.Name = "cbkinhphi";
            this.cbkinhphi.Size = new System.Drawing.Size(254, 27);
            this.cbkinhphi.TabIndex = 66;
            // 
            // cbketqua
            // 
            this.cbketqua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbketqua.FormattingEnabled = true;
            this.cbketqua.Location = new System.Drawing.Point(170, 99);
            this.cbketqua.Name = "cbketqua";
            this.cbketqua.Size = new System.Drawing.Size(254, 27);
            this.cbketqua.TabIndex = 65;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(83, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 19);
            this.label15.TabIndex = 62;
            this.label15.Text = "Kết Quả";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(77, 156);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 19);
            this.label14.TabIndex = 61;
            this.label14.Text = "Kinh Phí";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 19);
            this.label12.TabIndex = 59;
            this.label12.Text = "Nguồn Kinh Phí";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(524, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 55;
            this.label7.Text = "Bằng Cấp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(525, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 54;
            this.label6.Text = "Ngày Cấp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 49;
            this.label1.Text = "Ngoại Ngữ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(133)))), ((int)(((byte)(158)))));
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(294, 26);
            this.label11.TabIndex = 48;
            this.label11.Text = "Nhập Thông Tin Ngoại Ngữ";
            // 
            // gcthongtin
            // 
            this.gcthongtin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcthongtin.Location = new System.Drawing.Point(0, 434);
            this.gcthongtin.MainView = this.gvthongtin;
            this.gcthongtin.Name = "gcthongtin";
            this.gcthongtin.Size = new System.Drawing.Size(963, 255);
            this.gcthongtin.TabIndex = 2;
            this.gcthongtin.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvthongtin});
            this.gcthongtin.Click += new System.EventHandler(this.gcthongtin_Click);
            // 
            // gvthongtin
            // 
            this.gvthongtin.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NgoaiNgu,
            this.BangCap,
            this.KetQua,
            this.NgayCap,
            this.KinhPhi,
            this.ChinhPhu,
            this.NguonKinhPhi,
            this.GhiChu,
            this.Id});
            this.gvthongtin.GridControl = this.gcthongtin;
            this.gvthongtin.Name = "gvthongtin";
            // 
            // NgoaiNgu
            // 
            this.NgoaiNgu.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgoaiNgu.AppearanceCell.Options.UseFont = true;
            this.NgoaiNgu.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgoaiNgu.AppearanceHeader.Options.UseFont = true;
            this.NgoaiNgu.Caption = "Ngoại Ngữ";
            this.NgoaiNgu.FieldName = "NgoaiNgu";
            this.NgoaiNgu.MaxWidth = 150;
            this.NgoaiNgu.MinWidth = 150;
            this.NgoaiNgu.Name = "NgoaiNgu";
            this.NgoaiNgu.Visible = true;
            this.NgoaiNgu.VisibleIndex = 0;
            this.NgoaiNgu.Width = 150;
            // 
            // BangCap
            // 
            this.BangCap.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BangCap.AppearanceCell.Options.UseFont = true;
            this.BangCap.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BangCap.AppearanceHeader.Options.UseFont = true;
            this.BangCap.Caption = "Bằng Cấp";
            this.BangCap.FieldName = "BangCap";
            this.BangCap.MaxWidth = 150;
            this.BangCap.MinWidth = 150;
            this.BangCap.Name = "BangCap";
            this.BangCap.Visible = true;
            this.BangCap.VisibleIndex = 1;
            this.BangCap.Width = 150;
            // 
            // KetQua
            // 
            this.KetQua.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KetQua.AppearanceCell.Options.UseFont = true;
            this.KetQua.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KetQua.AppearanceHeader.Options.UseFont = true;
            this.KetQua.Caption = "Kết Quả";
            this.KetQua.FieldName = "KetQua";
            this.KetQua.MaxWidth = 150;
            this.KetQua.MinWidth = 150;
            this.KetQua.Name = "KetQua";
            this.KetQua.Visible = true;
            this.KetQua.VisibleIndex = 2;
            this.KetQua.Width = 150;
            // 
            // NgayCap
            // 
            this.NgayCap.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayCap.AppearanceCell.Options.UseFont = true;
            this.NgayCap.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayCap.AppearanceHeader.Options.UseFont = true;
            this.NgayCap.Caption = "Ngày Cấp";
            this.NgayCap.FieldName = "NgayCap";
            this.NgayCap.MaxWidth = 150;
            this.NgayCap.MinWidth = 150;
            this.NgayCap.Name = "NgayCap";
            this.NgayCap.Visible = true;
            this.NgayCap.VisibleIndex = 3;
            this.NgayCap.Width = 150;
            // 
            // KinhPhi
            // 
            this.KinhPhi.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KinhPhi.AppearanceCell.Options.UseFont = true;
            this.KinhPhi.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KinhPhi.AppearanceHeader.Options.UseFont = true;
            this.KinhPhi.Caption = "Kinh Phí";
            this.KinhPhi.FieldName = "KinhPhi";
            this.KinhPhi.MaxWidth = 150;
            this.KinhPhi.MinWidth = 150;
            this.KinhPhi.Name = "KinhPhi";
            this.KinhPhi.Visible = true;
            this.KinhPhi.VisibleIndex = 4;
            this.KinhPhi.Width = 150;
            // 
            // ChinhPhu
            // 
            this.ChinhPhu.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChinhPhu.AppearanceCell.Options.UseFont = true;
            this.ChinhPhu.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChinhPhu.AppearanceHeader.Options.UseFont = true;
            this.ChinhPhu.Caption = "Chính Phụ";
            this.ChinhPhu.FieldName = "ChinhPhu";
            this.ChinhPhu.MaxWidth = 150;
            this.ChinhPhu.MinWidth = 150;
            this.ChinhPhu.Name = "ChinhPhu";
            this.ChinhPhu.Visible = true;
            this.ChinhPhu.VisibleIndex = 5;
            this.ChinhPhu.Width = 150;
            // 
            // NguonKinhPhi
            // 
            this.NguonKinhPhi.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NguonKinhPhi.AppearanceCell.Options.UseFont = true;
            this.NguonKinhPhi.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NguonKinhPhi.AppearanceHeader.Options.UseFont = true;
            this.NguonKinhPhi.Caption = "Nguồn Kinh Phí";
            this.NguonKinhPhi.FieldName = "NguonKinhPhi";
            this.NguonKinhPhi.MaxWidth = 150;
            this.NguonKinhPhi.MinWidth = 150;
            this.NguonKinhPhi.Name = "NguonKinhPhi";
            this.NguonKinhPhi.Visible = true;
            this.NguonKinhPhi.VisibleIndex = 6;
            this.NguonKinhPhi.Width = 150;
            // 
            // GhiChu
            // 
            this.GhiChu.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GhiChu.AppearanceCell.Options.UseFont = true;
            this.GhiChu.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GhiChu.AppearanceHeader.Options.UseFont = true;
            this.GhiChu.Caption = "Ghi Chú";
            this.GhiChu.FieldName = "GhiChu";
            this.GhiChu.MaxWidth = 150;
            this.GhiChu.MinWidth = 150;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 7;
            this.GhiChu.Width = 150;
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.MinWidth = 25;
            this.Id.Name = "Id";
            this.Id.Width = 94;
            // 
            // btnthoat
            // 
            this.btnthoat.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnthoat.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(133)))), ((int)(((byte)(158)))));
            this.btnthoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Appearance.Options.UseBackColor = true;
            this.btnthoat.Appearance.Options.UseBorderColor = true;
            this.btnthoat.Appearance.Options.UseFont = true;
            this.btnthoat.Location = new System.Drawing.Point(553, 399);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(60, 29);
            this.btnthoat.TabIndex = 47;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnluu
            // 
            this.btnluu.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnluu.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(133)))), ((int)(((byte)(158)))));
            this.btnluu.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Appearance.Options.UseBackColor = true;
            this.btnluu.Appearance.Options.UseBorderColor = true;
            this.btnluu.Appearance.Options.UseFont = true;
            this.btnluu.Location = new System.Drawing.Point(749, 399);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(124, 29);
            this.btnluu.TabIndex = 46;
            this.btnluu.Text = "Lưu Thay Đổi";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btncapnhat.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(133)))), ((int)(((byte)(158)))));
            this.btncapnhat.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncapnhat.Appearance.Options.UseBackColor = true;
            this.btncapnhat.Appearance.Options.UseBorderColor = true;
            this.btncapnhat.Appearance.Options.UseFont = true;
            this.btncapnhat.Location = new System.Drawing.Point(619, 399);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(124, 29);
            this.btncapnhat.TabIndex = 48;
            this.btncapnhat.Text = "Cập Nhật ";
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // frmNgoaiNgu
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 689);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.gcthongtin);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmNgoaiNgu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNgoaiNgu";
            this.Load += new System.EventHandler(this.frmNgoaiNgu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcthongtin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvthongtin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.CheckBox ckchinhphu;
        private System.Windows.Forms.DateTimePicker dtngaycap;
        private System.Windows.Forms.ComboBox cbbangcap;
        private System.Windows.Forms.RichTextBox txtghichu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txtnguonkinhphi;
        private System.Windows.Forms.ComboBox cbkinhphi;
        private System.Windows.Forms.ComboBox cbketqua;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraGrid.Views.Grid.GridView gvthongtin;
        private DevExpress.XtraGrid.Columns.GridColumn NgoaiNgu;
        private DevExpress.XtraGrid.Columns.GridColumn BangCap;
        private DevExpress.XtraGrid.Columns.GridColumn KetQua;
        private DevExpress.XtraGrid.Columns.GridColumn NgayCap;
        private DevExpress.XtraGrid.Columns.GridColumn KinhPhi;
        private DevExpress.XtraGrid.Columns.GridColumn ChinhPhu;
        private DevExpress.XtraGrid.Columns.GridColumn NguonKinhPhi;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
        private DevExpress.XtraEditors.SimpleButton btnthoat;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private System.Windows.Forms.ComboBox cbngoaingu;
        private DevExpress.XtraEditors.SimpleButton btncapnhat;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.GridControl gcthongtin;
    }
}
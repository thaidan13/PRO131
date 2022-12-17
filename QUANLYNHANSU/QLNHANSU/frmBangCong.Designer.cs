
namespace QLNHANSU
{
    partial class frmBangCong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBangCong));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnxembangcong = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cktrangthai = new System.Windows.Forms.CheckBox();
            this.ckkhoa = new System.Windows.Forms.CheckBox();
            this.cbthang = new System.Windows.Forms.ComboBox();
            this.cbnam = new System.Windows.Forms.ComboBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Delete_By = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaKyCong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Khoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayTinhCong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayCongTrongThang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDCongTy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnHuy,
            this.btnDong,
            this.btnIn,
            this.btnxembangcong,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar2.BarAppearance.Normal.Options.UseFont = true;
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnxembangcong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xoá";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLuu.ImageOptions.SvgImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Huỷ";
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnxembangcong
            // 
            this.btnxembangcong.Caption = "Xem Bảng Công";
            this.btnxembangcong.Id = 7;
            this.btnxembangcong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnxembangcong.ImageOptions.SvgImage")));
            this.btnxembangcong.Name = "btnxembangcong";
            this.btnxembangcong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnxembangcong_ItemClick);
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Id = 6;
            this.btnIn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnIn.ImageOptions.SvgImage")));
            this.btnIn.Name = "btnIn";
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 5;
            this.btnDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDong.ImageOptions.SvgImage")));
            this.btnDong.Name = "btnDong";
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1087, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 584);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1087, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 554);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1087, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 554);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cktrangthai);
            this.splitContainer1.Panel1.Controls.Add(this.ckkhoa);
            this.splitContainer1.Panel1.Controls.Add(this.cbthang);
            this.splitContainer1.Panel1.Controls.Add(this.cbnam);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(1087, 554);
            this.splitContainer1.SplitterDistance = 91;
            this.splitContainer1.TabIndex = 8;
            // 
            // cktrangthai
            // 
            this.cktrangthai.AutoSize = true;
            this.cktrangthai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cktrangthai.Location = new System.Drawing.Point(665, 32);
            this.cktrangthai.Name = "cktrangthai";
            this.cktrangthai.Size = new System.Drawing.Size(101, 23);
            this.cktrangthai.TabIndex = 20;
            this.cktrangthai.Text = "Trạng Thái";
            this.cktrangthai.UseVisualStyleBackColor = true;
            // 
            // ckkhoa
            // 
            this.ckkhoa.AutoSize = true;
            this.ckkhoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckkhoa.Location = new System.Drawing.Point(592, 33);
            this.ckkhoa.Name = "ckkhoa";
            this.ckkhoa.Size = new System.Drawing.Size(67, 23);
            this.ckkhoa.TabIndex = 19;
            this.ckkhoa.Text = "Khoá";
            this.ckkhoa.UseVisualStyleBackColor = true;
            // 
            // cbthang
            // 
            this.cbthang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbthang.FormattingEnabled = true;
            this.cbthang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbthang.Location = new System.Drawing.Point(475, 29);
            this.cbthang.Name = "cbthang";
            this.cbthang.Size = new System.Drawing.Size(68, 27);
            this.cbthang.TabIndex = 18;
            // 
            // cbnam
            // 
            this.cbnam.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbnam.FormattingEnabled = true;
            this.cbnam.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035"});
            this.cbnam.Location = new System.Drawing.Point(272, 29);
            this.cbnam.Name = "cbnam";
            this.cbnam.Size = new System.Drawing.Size(121, 27);
            this.cbnam.TabIndex = 17;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(429, 36);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(40, 19);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "Tháng";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(224, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Năm";
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1087, 459);
            this.gcDanhSach.TabIndex = 0;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            this.gcDanhSach.Click += new System.EventHandler(this.gcDanhSach_Click);
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Delete_By,
            this.MaKyCong,
            this.Nam,
            this.Khoa,
            this.NgayTinhCong,
            this.NgayCongTrongThang,
            this.IDCongTy,
            this.TrangThai});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.ShowGroupPanel = false;
            this.gvDanhSach.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvDanhSach_CustomDrawCell);
            // 
            // Delete_By
            // 
            this.Delete_By.Caption = "Delete_By";
            this.Delete_By.FieldName = "Delete_By";
            this.Delete_By.MaxWidth = 25;
            this.Delete_By.MinWidth = 25;
            this.Delete_By.Name = "Delete_By";
            this.Delete_By.Visible = true;
            this.Delete_By.VisibleIndex = 0;
            this.Delete_By.Width = 25;
            // 
            // MaKyCong
            // 
            this.MaKyCong.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaKyCong.AppearanceCell.Options.UseFont = true;
            this.MaKyCong.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaKyCong.AppearanceHeader.Options.UseFont = true;
            this.MaKyCong.Caption = "Mã Kỳ Công";
            this.MaKyCong.FieldName = "MaKyCong";
            this.MaKyCong.MaxWidth = 150;
            this.MaKyCong.MinWidth = 150;
            this.MaKyCong.Name = "MaKyCong";
            this.MaKyCong.Visible = true;
            this.MaKyCong.VisibleIndex = 1;
            this.MaKyCong.Width = 150;
            // 
            // Nam
            // 
            this.Nam.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nam.AppearanceCell.Options.UseFont = true;
            this.Nam.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nam.AppearanceHeader.Options.UseFont = true;
            this.Nam.Caption = "Năm";
            this.Nam.FieldName = "Nam";
            this.Nam.MaxWidth = 100;
            this.Nam.MinWidth = 100;
            this.Nam.Name = "Nam";
            this.Nam.Visible = true;
            this.Nam.VisibleIndex = 2;
            this.Nam.Width = 100;
            // 
            // Khoa
            // 
            this.Khoa.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Khoa.AppearanceCell.Options.UseFont = true;
            this.Khoa.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Khoa.AppearanceHeader.Options.UseFont = true;
            this.Khoa.Caption = "Khoá";
            this.Khoa.FieldName = "Khoa";
            this.Khoa.MaxWidth = 50;
            this.Khoa.MinWidth = 50;
            this.Khoa.Name = "Khoa";
            this.Khoa.Visible = true;
            this.Khoa.VisibleIndex = 3;
            this.Khoa.Width = 50;
            // 
            // NgayTinhCong
            // 
            this.NgayTinhCong.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayTinhCong.AppearanceCell.Options.UseFont = true;
            this.NgayTinhCong.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayTinhCong.AppearanceHeader.Options.UseFont = true;
            this.NgayTinhCong.Caption = "Ngày Tính Công";
            this.NgayTinhCong.FieldName = "NgayTinhCong";
            this.NgayTinhCong.MaxWidth = 150;
            this.NgayTinhCong.MinWidth = 150;
            this.NgayTinhCong.Name = "NgayTinhCong";
            this.NgayTinhCong.Visible = true;
            this.NgayTinhCong.VisibleIndex = 4;
            this.NgayTinhCong.Width = 150;
            // 
            // NgayCongTrongThang
            // 
            this.NgayCongTrongThang.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayCongTrongThang.AppearanceCell.Options.UseFont = true;
            this.NgayCongTrongThang.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayCongTrongThang.AppearanceHeader.Options.UseFont = true;
            this.NgayCongTrongThang.Caption = "Ngày Công Trong Tháng";
            this.NgayCongTrongThang.FieldName = "NgayCongTrongThang";
            this.NgayCongTrongThang.MaxWidth = 200;
            this.NgayCongTrongThang.MinWidth = 200;
            this.NgayCongTrongThang.Name = "NgayCongTrongThang";
            this.NgayCongTrongThang.Visible = true;
            this.NgayCongTrongThang.VisibleIndex = 5;
            this.NgayCongTrongThang.Width = 200;
            // 
            // IDCongTy
            // 
            this.IDCongTy.Caption = "ID Công Ty";
            this.IDCongTy.FieldName = "IDCongTy";
            this.IDCongTy.MinWidth = 25;
            this.IDCongTy.Name = "IDCongTy";
            this.IDCongTy.Width = 94;
            // 
            // TrangThai
            // 
            this.TrangThai.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrangThai.AppearanceCell.Options.UseFont = true;
            this.TrangThai.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrangThai.AppearanceHeader.Options.UseFont = true;
            this.TrangThai.Caption = "Trạng Thái";
            this.TrangThai.FieldName = "TrangThai";
            this.TrangThai.MaxWidth = 100;
            this.TrangThai.MinWidth = 100;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Visible = true;
            this.TrangThai.VisibleIndex = 6;
            this.TrangThai.Width = 100;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Tải Lại";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // frmBangCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 604);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmBangCong";
            this.Text = "frmBangCong";
            this.Load += new System.EventHandler(this.frmBangCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox cktrangthai;
        private System.Windows.Forms.CheckBox ckkhoa;
        private System.Windows.Forms.ComboBox cbthang;
        private System.Windows.Forms.ComboBox cbnam;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn Delete_By;
        private DevExpress.XtraGrid.Columns.GridColumn MaKyCong;
        private DevExpress.XtraGrid.Columns.GridColumn Nam;
        private DevExpress.XtraGrid.Columns.GridColumn Khoa;
        private DevExpress.XtraGrid.Columns.GridColumn NgayTinhCong;
        private DevExpress.XtraGrid.Columns.GridColumn NgayCongTrongThang;
        private DevExpress.XtraGrid.Columns.GridColumn IDCongTy;
        private DevExpress.XtraGrid.Columns.GridColumn TrangThai;
        private DevExpress.XtraBars.BarButtonItem btnxembangcong;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}
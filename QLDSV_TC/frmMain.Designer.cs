
namespace QLDSV_TC
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.HeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MA = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.BaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.CauHinh = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.BtnSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.BtnMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.BtnLopTC = new DevExpress.XtraBars.BarButtonItem();
            this.BtnLopHoc = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDiem = new DevExpress.XtraBars.BarButtonItem();
            this.BtnHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDangKy = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDSLTC = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDKLTC = new DevExpress.XtraBars.BarButtonItem();
            this.BtnBDHM = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPhieuDiem = new DevExpress.XtraBars.BarButtonItem();
            this.BtnHP = new DevExpress.XtraBars.BarButtonItem();
            this.BtnBangDiem = new DevExpress.XtraBars.BarButtonItem();
            this.BtnTaoTK = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDoiMK = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.BtnSinhVien,
            this.BtnMonHoc,
            this.BtnLopTC,
            this.BtnLopHoc,
            this.BtnDiem,
            this.BtnHocPhi,
            this.BtnDangKy,
            this.BtnDSLTC,
            this.BtnDKLTC,
            this.BtnBDHM,
            this.BtnPhieuDiem,
            this.BtnHP,
            this.BtnBangDiem,
            this.BtnTaoTK,
            this.BtnDoiMK,
            this.BtnDangXuat});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(6);
            this.ribbonControl1.MaxItemId = 19;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.HeThong,
            this.BaoCao,
            this.CauHinh});
            this.ribbonControl1.Size = new System.Drawing.Size(1656, 315);
            // 
            // HeThong
            // 
            this.HeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.HeThong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.HeThong.Name = "HeThong";
            this.HeThong.Text = "Hệ Thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnSinhVien);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnLopHoc);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnMonHoc);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnLopTC);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnDiem);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnHocPhi);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnDangKy);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quản lý dữ liệu";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MA,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 650);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1656, 42);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MA
            // 
            this.MA.Name = "MA";
            this.MA.Size = new System.Drawing.Size(52, 32);
            this.MA.Text = "MA";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(92, 32);
            this.HOTEN.Text = "HOTEN";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(90, 32);
            this.NHOM.Text = "NHOM";
            // 
            // BaoCao
            // 
            this.BaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.BaoCao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.ImageOptions.Image")));
            this.BaoCao.Name = "BaoCao";
            this.BaoCao.Text = "Báo Cáo";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnDSLTC);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnDKLTC);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnBDHM);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnPhieuDiem);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnHP);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnBangDiem);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // CauHinh
            // 
            this.CauHinh.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.CauHinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage3.ImageOptions.Image")));
            this.CauHinh.Name = "CauHinh";
            this.CauHinh.Text = "Cấu Hình";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnTaoTK);
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnDoiMK);
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnDangXuat);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Chức năng";
            // 
            // BtnSinhVien
            // 
            this.BtnSinhVien.Caption = "Sinh Viên";
            this.BtnSinhVien.Id = 3;
            this.BtnSinhVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.BtnSinhVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.BtnSinhVien.LargeWidth = 60;
            this.BtnSinhVien.Name = "BtnSinhVien";
            // 
            // BtnMonHoc
            // 
            this.BtnMonHoc.Caption = "Môn Học";
            this.BtnMonHoc.Id = 4;
            this.BtnMonHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.BtnMonHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.BtnMonHoc.LargeWidth = 60;
            this.BtnMonHoc.Name = "BtnMonHoc";
            // 
            // BtnLopTC
            // 
            this.BtnLopTC.Caption = "Lớp TC";
            this.BtnLopTC.Id = 5;
            this.BtnLopTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.BtnLopTC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.BtnLopTC.LargeWidth = 60;
            this.BtnLopTC.Name = "BtnLopTC";
            // 
            // BtnLopHoc
            // 
            this.BtnLopHoc.Caption = "Lớp Học";
            this.BtnLopHoc.Id = 6;
            this.BtnLopHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image1")));
            this.BtnLopHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage1")));
            this.BtnLopHoc.LargeWidth = 60;
            this.BtnLopHoc.Name = "BtnLopHoc";
            // 
            // BtnDiem
            // 
            this.BtnDiem.Caption = "Điểm";
            this.BtnDiem.Id = 7;
            this.BtnDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image2")));
            this.BtnDiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage2")));
            this.BtnDiem.LargeWidth = 60;
            this.BtnDiem.Name = "BtnDiem";
            // 
            // BtnHocPhi
            // 
            this.BtnHocPhi.Caption = "Học Phí";
            this.BtnHocPhi.Id = 8;
            this.BtnHocPhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image3")));
            this.BtnHocPhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage3")));
            this.BtnHocPhi.LargeWidth = 60;
            this.BtnHocPhi.Name = "BtnHocPhi";
            // 
            // BtnDangKy
            // 
            this.BtnDangKy.Caption = "Đăng ký";
            this.BtnDangKy.Id = 9;
            this.BtnDangKy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image4")));
            this.BtnDangKy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage4")));
            this.BtnDangKy.LargeWidth = 60;
            this.BtnDangKy.Name = "BtnDangKy";
            // 
            // BtnDSLTC
            // 
            this.BtnDSLTC.Caption = "In DSLTC";
            this.BtnDSLTC.Id = 10;
            this.BtnDSLTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image5")));
            this.BtnDSLTC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage5")));
            this.BtnDSLTC.LargeWidth = 60;
            this.BtnDSLTC.Name = "BtnDSLTC";
            // 
            // BtnDKLTC
            // 
            this.BtnDKLTC.Caption = "In DSSV DKLTC";
            this.BtnDKLTC.Id = 11;
            this.BtnDKLTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDKLTC.ImageOptions.Image")));
            this.BtnDKLTC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnDKLTC.ImageOptions.LargeImage")));
            this.BtnDKLTC.LargeWidth = 60;
            this.BtnDKLTC.Name = "BtnDKLTC";
            // 
            // BtnBDHM
            // 
            this.BtnBDHM.Caption = "In BDHM";
            this.BtnBDHM.Id = 12;
            this.BtnBDHM.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image6")));
            this.BtnBDHM.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage6")));
            this.BtnBDHM.LargeWidth = 60;
            this.BtnBDHM.Name = "BtnBDHM";
            // 
            // BtnPhieuDiem
            // 
            this.BtnPhieuDiem.Caption = "In Phiếu Điểm SV";
            this.BtnPhieuDiem.Id = 13;
            this.BtnPhieuDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image7")));
            this.BtnPhieuDiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage7")));
            this.BtnPhieuDiem.LargeWidth = 60;
            this.BtnPhieuDiem.Name = "BtnPhieuDiem";
            // 
            // BtnHP
            // 
            this.BtnHP.Caption = "In DS Học Phí";
            this.BtnHP.Id = 14;
            this.BtnHP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image8")));
            this.BtnHP.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage8")));
            this.BtnHP.LargeWidth = 60;
            this.BtnHP.Name = "BtnHP";
            // 
            // BtnBangDiem
            // 
            this.BtnBangDiem.Caption = "In Bảng Điểm TK";
            this.BtnBangDiem.Id = 15;
            this.BtnBangDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image9")));
            this.BtnBangDiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage9")));
            this.BtnBangDiem.LargeWidth = 60;
            this.BtnBangDiem.Name = "BtnBangDiem";
            // 
            // BtnTaoTK
            // 
            this.BtnTaoTK.Caption = "Tạo Tài Khoản";
            this.BtnTaoTK.Id = 16;
            this.BtnTaoTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image10")));
            this.BtnTaoTK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage10")));
            this.BtnTaoTK.LargeWidth = 70;
            this.BtnTaoTK.Name = "BtnTaoTK";
            // 
            // BtnDoiMK
            // 
            this.BtnDoiMK.Caption = "Đổi Mật Khẩu";
            this.BtnDoiMK.Id = 17;
            this.BtnDoiMK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image1")));
            this.BtnDoiMK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage1")));
            this.BtnDoiMK.LargeWidth = 70;
            this.BtnDoiMK.Name = "BtnDoiMK";
            // 
            // BtnDangXuat
            // 
            this.BtnDangXuat.Caption = "Đăng xuất";
            this.BtnDangXuat.Id = 18;
            this.BtnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image11")));
            this.BtnDangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage11")));
            this.BtnDangXuat.LargeWidth = 70;
            this.BtnDangXuat.Name = "BtnDangXuat";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 692);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản lý điểm sinh viên tín chỉ";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage HeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel MA;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
        private DevExpress.XtraBars.Ribbon.RibbonPage BaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage CauHinh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem BtnSinhVien;
        private DevExpress.XtraBars.BarButtonItem BtnMonHoc;
        private DevExpress.XtraBars.BarButtonItem BtnLopTC;
        private DevExpress.XtraBars.BarButtonItem BtnLopHoc;
        private DevExpress.XtraBars.BarButtonItem BtnDiem;
        private DevExpress.XtraBars.BarButtonItem BtnHocPhi;
        private DevExpress.XtraBars.BarButtonItem BtnDangKy;
        private DevExpress.XtraBars.BarButtonItem BtnDSLTC;
        private DevExpress.XtraBars.BarButtonItem BtnDKLTC;
        private DevExpress.XtraBars.BarButtonItem BtnBDHM;
        private DevExpress.XtraBars.BarButtonItem BtnPhieuDiem;
        private DevExpress.XtraBars.BarButtonItem BtnHP;
        private DevExpress.XtraBars.BarButtonItem BtnBangDiem;
        private DevExpress.XtraBars.BarButtonItem BtnTaoTK;
        private DevExpress.XtraBars.BarButtonItem BtnDoiMK;
        private DevExpress.XtraBars.BarButtonItem BtnDangXuat;
    }
}


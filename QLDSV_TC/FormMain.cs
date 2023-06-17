using System;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();

        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            this.MA.Text = "Mã: " + Program.username;
            this.HOTEN.Text = "Họ và tên: " + Program.mHoten;
            this.NHOM.Text = "Nhóm: " + Program.mGroup;
            PhanQuyen();
        }

        void PhanQuyen()
        {
            if (Program.mGroup.Equals("SV"))
            {
                BtnDangKy.Enabled = true;
                BtnDiem.Enabled = BtnHocPhi.Enabled = BtnLopHoc.Enabled = BtnLopTC.Enabled = BtnMonHoc.Enabled = BtnSinhVien.Enabled  = false;
                BaoCao.Visible = false;
            }
            if (Program.mGroup.Equals("PKT"))
            {
                BtnHocPhi.Enabled = true;
                BtnDiem.Enabled = BtnLopHoc.Enabled = BtnLopTC.Enabled = BtnMonHoc.Enabled = BtnSinhVien.Enabled = BtnDangKy.Enabled = false;
            }
            if (Program.mGroup.Equals("PGV") || Program.mGroup.Equals("KHOA"))
            {
                BtnDangKy.Enabled = BtnHocPhi.Enabled = false;
            }
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void BtnDangKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            this.ShowMdiChildren(typeof(XFormDangKy));
        }

        private void BtnLopHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            this.ShowMdiChildren(typeof(FormLopHoc));
        }

        private void BtnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowMdiChildren(typeof(FormSinhVien));
        }

        private void BtnDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            this.ShowMdiChildren(typeof(XFormNhapDiem));
        }

        private void BtnBangDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowMdiChildren(typeof(FormReportBDTK));
        }

        private void ShowMdiChildren(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    f.Activate();
                    return;
                }
            }
            Form form = (Form)Activator.CreateInstance(fType);
            form.MdiParent = this;
            form.Show();
        }

        private void BtnTaoTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowMdiChildren(typeof(FormTaoTaiKhoan));
        }

        private void BtnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormMonHoc));
   
            if (frm != null) frm.Activate();
            else
            {
                Form f = new FormMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void BtnLopTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(FormLopTinChi));
            if (frm != null) frm.Activate();
            else
            {
                Form f = new FormLopTinChi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void BtnHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormHocPhi));
            if (frm != null) frm.Activate();
            else
            {
                Form f = new FormHocPhi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void BtnBDHM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Frpt_BANGDIEMHETMONCUALOP1));
            if (frm != null) frm.Activate();
            else
            {
                Frpt_BANGDIEMHETMONCUALOP1 f = new Frpt_BANGDIEMHETMONCUALOP1();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void BtnPhieuDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Frpt_INPHIEUDIEMSV1));
            if (frm != null) frm.Activate();
            else
            {
                Frpt_INPHIEUDIEMSV1 f = new Frpt_INPHIEUDIEMSV1();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void BtnHP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Frpt_INDANHSACHDONGHOCPHI));
            if (frm != null) frm.Activate();
            else
            {
                Frpt_INDANHSACHDONGHOCPHI f = new Frpt_INDANHSACHDONGHOCPHI();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        bool dangxuat = false;
        public FormMain()
        {
            InitializeComponent();

        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            this.MA.Text = "Mã: " + Program.username;
            this.HOTEN.Text = "Họ và tên: " + Program.mHoten;
            this.NHOM.Text = "Nhóm: " + Program.mGroup;
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
                    if (dangxuat == true)
                    {
                        Program.formDangNhap.Show();
                        dangxuat = false;
                    }else
                    {
                        
                      Application.Exit();
                    }
                }
            }
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

        private void BtnDangKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            this.ShowMdiChildren(typeof(XFormDangKy));
        }

        private void BtnLopHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FormLopHoc)); 
       
        }

        private void BtnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // if (!(Program.MGroup == Program.NhomQuyen[2]))
            //{
                ShowMdiChildren(typeof(FormSinhVien));
            //}
        }

        private void BtnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
            dangxuat = true;
            this.Close();
           

        }

        private void BtnDSLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Frpt_DANHSACHLOPTINCHI));
        }

        private void BtnDKLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Frpt_DanhSachSVDangKyLTC));
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
    }
}

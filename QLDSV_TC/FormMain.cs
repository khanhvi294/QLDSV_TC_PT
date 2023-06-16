using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();

        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
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
                    Application.Exit();
                }
            }
        }

        private void BtnDangKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDangKy));
            if (frm != null) frm.Activate();
            else
            {
                FormDangKy f = new FormDangKy();
                // f.MdiParent = this;
                f.Show();
            }
        }

        private void BtnLopHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormLopHoc f = new FormLopHoc();
            f.Show();
        }

        private void BtnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormSinhVien f = new FormSinhVien();
            f.Show();
        }

        private void BtnDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormNhapDiem f = new FormNhapDiem();
            f.Show();
        }
    }
}

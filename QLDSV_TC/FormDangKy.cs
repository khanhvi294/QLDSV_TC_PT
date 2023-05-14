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

namespace QLDSV_TC
{
    public partial class FormDangKy : DevExpress.XtraEditors.XtraForm
    {
        private string maSV = "";
        private string ho = "";
        private string ten = "";
        private string maLop = "";
        private BindingSource bdsSinhVien = new BindingSource();
        private BindingSource bdsLopTinchi = new BindingSource();
        private BindingSource bdsDSLTC_HUY = new BindingSource();
        public FormDangKy()
        {
            InitializeComponent();
        }

        void LayThongTinSV()
        {
            string cmd = "EXEC dbo.SP_LayThongTinSVDangKy '" + Program.username + "'";
            Program.myReader = Program.ExecSqlDataReader(cmd);
            if (Program.myReader == null) return;
            Program.myReader.Read(); // Đọc 1 dòng nếu dữ liệu có nhiều dùng thì dùng for lặp nếu null thì break
            if (Program.myReader == null) return;
            this.maSV = Program.myReader.GetString(0);
            this.ho = Program.myReader.GetString(1);
            this.ten = Program.myReader.GetString(2);
            this.maLop = Program.myReader.GetString(3);
            Program.myReader.Close();

        }

        void LayDSNienKhoa()
        {
            string cmd = "SELECT * FROM [dbo].[LayDSNienKhoa]";
            DataTable dt = Program.ExecSqlDataTable(cmd);
            BindingSource bdsNienKhoa = new BindingSource();
            bdsNienKhoa.DataSource = dt;
            CmbNienKhoa.DataSource = bdsNienKhoa;
            CmbNienKhoa.DisplayMember = "NIENKHOA";
            CmbNienKhoa.ValueMember = "NIENKHOA";
        }

        void LayDSHocKy(string nienkhoa)
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC SP_LayDSHocKy '" + nienkhoa + "'";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsHocKi = new BindingSource();
            bdsHocKi.DataSource = dt;
            CmbHocKy.DataSource = bdsHocKi;
            CmbHocKy.DisplayMember = "HOCKY";
            CmbHocKy.ValueMember = "HOCKY";
        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {
            LayThongTinSV();
            LayDSNienKhoa();
            this.lbDataMaSV.Text = this.maSV;
            this.lbDataHo.Text = this.ho;
            this.lbDataTen.Text = this.ten;
            this.lbDataMaLop.Text = this.maLop;
            CmbNienKhoa.SelectedIndex = 0;
            LayDSHocKy(CmbNienKhoa.SelectedValue.ToString());
        }

        private void CmbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LayDSHocKy(CmbNienKhoa.Text);
            try
            {
                CmbHocKy.SelectedIndex = 0;
                LayDSHocKy(CmbNienKhoa.SelectedValue.ToString());
            }
            catch
            {
            }

        }

        private void BtnTimDSLTC_Click(object sender, EventArgs e)
        {
            string cmd = "EXEC [dbo].[SP_LayDSLopTinChi] '" + CmbNienKhoa.Text + "', '" + CmbHocKy.Text + "'";
            DataTable tableLopTC = Program.ExecSqlDataTable(cmd);
            this.bdsLopTinchi.DataSource = tableLopTC;
            this.gridControlDSLTC.DataSource = this.bdsLopTinchi;
        }

        private void gridControlDSLTC_Click(object sender, EventArgs e)
        {
            if (bdsLopTinchi.Count > 0)
            {

                this.txbMaLopTC.Text = ((DataRowView)bdsLopTinchi[bdsLopTinchi.Position])["MALTC"].ToString();
                this.txbMaMH.Text = ((DataRowView)bdsLopTinchi[bdsLopTinchi.Position])["MAMH"].ToString();
                this.txbTenMH.Text =((DataRowView)bdsLopTinchi[bdsLopTinchi.Position])["TENMH"].ToString();
                this.txbNhom.Text = ((DataRowView)bdsLopTinchi[bdsLopTinchi.Position])["NHOM"].ToString();
                this.txbGV.Text = ((DataRowView)bdsLopTinchi[bdsLopTinchi.Position])["HOTENGV"].ToString();
                this.btnDangky.Enabled = true;
            }

        }
    }
}
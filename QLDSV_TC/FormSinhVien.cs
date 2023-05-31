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
  
    public partial class FormSinhVien : Form
    {
        int vitri = 0;
        string maLop = "";
        string maKhoa = "";
        public FormSinhVien()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.BdsLH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS2);

        }

        private void FormSinhVien_Load(object sender, EventArgs e)
        {

            DS2.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS2.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.DS2.LOP);
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS2.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.DS2.SINHVIEN);

            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT MAKHOA FROM KHOA");
            BindingSource bdsCN = new BindingSource();
            bdsCN.DataSource = dt;
            maKhoa = ((DataRowView)bdsCN[0])["MAKHOA"].ToString();
            CmbKhoa.DataSource = Program.bds_dspm;
            CmbKhoa.DisplayMember = "TENKHOA";
            CmbKhoa.ValueMember = "TENSERVER";
            CmbKhoa.SelectedIndex = Program.mKhoa;
            panelControl2.Enabled = false;
            if (Program.mGroup == "PGV")
            {
                CmbKhoa.Enabled = true;
            }
            else
            {
                CmbKhoa.Enabled = false;
            }



        }

        private void lOPBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.BdsLH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS2);

        }

        private void BtnThemLH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = BdsLH.Position;
            panelControl2.Enabled = true;
            BdsSv.AddNew();
            TxtMaSV.Focus();
            BtnThem.Enabled = BtnXoa.Enabled = BtnLamMoi.Enabled = BtnThoat.Enabled = BtnSua.Enabled = false;
            BtnGhi.Enabled = BtnPhucHoi.Enabled = true;
            GcLopHoc.Enabled = false;
            GcSinhVien.Enabled = false;
            // TxtMaLop.Text = this.lOPTableAdapter.GetData();
        }

        private void BtnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn hủy bỏ tất cả thao tác?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                BdsSv.CancelEdit();
                if (BtnThem.Enabled == false) BdsLH.Position = vitri;
                BtnThem.Enabled = true;



                GcLopHoc.Enabled = true;
                panelControl2.Enabled = false;
                BtnThem.Enabled = BtnXoa.Enabled = BtnLamMoi.Enabled = BtnThoat.Enabled = BtnSua.Enabled = true;
                BtnGhi.Enabled = BtnPhucHoi.Enabled = false;
            }

        }

        private void BtnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                //check lại chỗ này coi - lỗi maybe
                
                this.lOPTableAdapter.Fill(this.DS2.LOP);
                this.sINHVIENTableAdapter.Fill(this.DS2.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload:" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void CmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.servername = CmbKhoa.SelectedValue.ToString();
            if (CmbKhoa.SelectedIndex != Program.mKhoa)
            {
                Program.login = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.login = Program.mLogin;
                Program.password = Program.mPassword;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                // TODO: This line of code loads data into the 'dS2.LOP' table. You can move, or remove it, as needed.
                this.lOPTableAdapter.Fill(this.DS2.LOP);
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                // TODO: This line of code loads data into the 'dS2.SINHVIEN' table. You can move, or remove it, as needed.
                this.sINHVIENTableAdapter.Fill(this.DS2.SINHVIEN);


                DataTable dt = new DataTable();
                dt = Program.ExecSqlDataTable("SELECT MAKHOA FROM KHOA");
                BindingSource bdsCN = new BindingSource();
                bdsCN.DataSource = dt;
                maKhoa = ((DataRowView)bdsCN[0])["MAKHOA"].ToString();
            }

        }

        private void BtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void BtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = BdsLH.Position;
            BtnSua.Enabled = BtnThem.Enabled = BtnLamMoi.Enabled = BtnThoat.Enabled = BtnXoa.Enabled = false;
            panelControl2.Enabled = BtnPhucHoi.Enabled = BtnGhi.Enabled = true;
            GcLopHoc.Enabled = false;
        }

        private void BtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace QLDSV_TC
{
    public partial class Frpt_BANGDIENMONHOCCUALTC : DevExpress.XtraBars.TabForm
    {
        string maMH;
        public Frpt_BANGDIENMONHOCCUALTC()
        {
            
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frpt_BANGDIENMONHOCCUALTC_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            // TODO: This line of code loads data into the 'dS.HOCKY' table. You can move, or remove it, as needed.
            this.hOCKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hOCKYTableAdapter.Fill(this.dS.HOCKY);
            // TODO: This line of code loads data into the 'dS.NHOM' table. You can move, or remove it, as needed.
            this.nHOMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nHOMTableAdapter.Fill(this.dS.NHOM);
            // TODO: This line of code loads data into the 'dS.TENMONHOC' table. You can move, or remove it, as needed.
            this.tENMONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.tENMONHOCTableAdapter.Fill(this.dS.TENMONHOC);
            // TODO: This line of code loads data into the 'dS.NIENKHOA' table. You can move, or remove it, as needed.
            this.nIENKHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.nIENKHOATableAdapter.Fill(this.dS.NIENKHOA);

            Program.bds_dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            cmbKHOA.DataSource = Program.bds_dspm;
            cmbKHOA.DisplayMember = "TENKHOA";
            cmbKHOA.ValueMember = "TENSERVER";
            cmbKHOA.SelectedIndex = Program.mKhoa;
            if (Program.mGroup == "KHOA")
            {
                cmbKHOA.Enabled = false;

            }
            if (Program.mGroup == "PGV")
            {
                cmbKHOA.Enabled = true;
            }

        }

        private void tENMHComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                maMH = cmbTENMH.SelectedValue.ToString();
            }
            catch(Exception ex)
            {

            }
        }

        private void tENMHLabel_Click(object sender, EventArgs e)
        {

        }

        private void cmbKHOA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKHOA.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbKHOA.SelectedValue.ToString();
            if (cmbKHOA.SelectedIndex != Program.mKhoa)
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
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    // TODO: This line of code loads data into the 'dS.HOCKY' table. You can move, or remove it, as needed.
                    this.hOCKYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.hOCKYTableAdapter.Fill(this.dS.HOCKY);
                    // TODO: This line of code loads data into the 'dS.NHOM' table. You can move, or remove it, as needed.
                    this.nHOMTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nHOMTableAdapter.Fill(this.dS.NHOM);
                    // TODO: This line of code loads data into the 'dS.TENMONHOC' table. You can move, or remove it, as needed.
                    this.tENMONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.tENMONHOCTableAdapter.Fill(this.dS.TENMONHOC);
                    // TODO: This line of code loads data into the 'dS.NIENKHOA' table. You can move, or remove it, as needed.
                    this.nIENKHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nIENKHOATableAdapter.Fill(this.dS.NIENKHOA);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể load dữ liệu từ sever đã chọn", "", MessageBoxButtons.OK);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nienkhoa = cmbNIENKHOA.SelectedValue.ToString();
            int hocky = int.Parse(cmbHOCKY.SelectedValue.ToString());
            int nhom = int.Parse(cmbNHOM.SelectedValue.ToString());

            Xrpt_BANGDIENHEMONCUALOPTC1 rpt = new Xrpt_BANGDIENHEMONCUALOPTC1(nienkhoa, hocky, nhom, maMH);

      /*      rpt.lblTieuDe.Text = “DANH SÁCH PHIẾU “ +cmbLoai.Text.ToUpper() + “ NHÂN VIÊN LẬP TRONG NĂM “ +cmbNam.Text;
            rpt.lblHoTen.Text = cmbHoten.Text;*/

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }
    }
}

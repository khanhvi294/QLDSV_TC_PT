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
    public partial class FormLopHoc : Form
    {
        private string makhoa = "";
        int vitri = 0;
        public FormLopHoc()
        {
            InitializeComponent();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.BdsLH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS1);

        }

        private void FormLopHoc_Load(object sender, EventArgs e)
        {
            DS1.EnforceConstraints=false; //k kiểm tra các ràng buộc khóa ngôaij trên dataset này
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS1.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.DS1.LOP);
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'DS1.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.DS1.SINHVIEN);
            makhoa = ((DataRowView)BdsLH[0])["MAKHOA"].ToString(); //tiềm ẩn lỗi, cần xử lí
            CmbKhoa.DataSource = Program.bds_dspm;
            CmbKhoa.DisplayMember = "TENKHOA";
            CmbKhoa.ValueMember = "TENSERVER";
            CmbKhoa.SelectedIndex = Program.mKhoa;

        }

        private void BtnThemLH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = BdsLH.Position;
            panelControl2.Enabled = true;
            BdsLH.AddNew();
            TxtMaKhoa.Text = makhoa;
            TxtMaLop.Focus();

            BtnThemLH.Enabled = BtnXoaLH.Enabled = BtnLamMoiLH.Enabled = BtnThoatLH.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            GcLopHoc.Enabled = false;
        }

        private void BtnPhucHoiLH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BdsLH.CancelEdit();
            if (BtnThemLH.Enabled = false) BdsLH.Position = vitri;
            GcLopHoc.Enabled = true;
            panelControl2.Enabled = false;
            BtnThemLH.Enabled = BtnXoaLH.Enabled = BtnLamMoiLH.Enabled = BtnThoatLH.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void BtnLamMoiLH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lOPTableAdapter.Fill(this.DS1.LOP);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi Reload:" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void BtnXoaLH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maLH = "";
            if(BdsSV.Count>0)
            {
                MessageBox.Show("Không thể xóa lớp học vì đã có sinh viên đăng kí","",MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa nhân viên này??", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK) // hiện dialog 2 button ok / cancel check ngdung chọn 0k
            {
                try
                {
                    maLH = ((DataRowView)BdsLH[BdsLH.Position])["MALOP"].ToString();//giữ mã để đưa con troe chuột quay lại vị trí lớp này nếu xóa lỗi
                    BdsLH.RemoveCurrent(); //xóa trên máy hiện tại
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.DS1.LOP); // xóa trên csdl
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa lớp thất bại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.lOPTableAdapter.Fill(this.DS1.LOP); //TH xóa trên màn hình( BdsLH.RemoveCurrent();) thành công nhưng xóa DB( this.lOPTableAdapter.Update(this.DS1.LOP);) lỗi để tránh màn hình biến mất nhưng DB k mất thfi ta tải lại dữ liệu)
                    BdsLH.Position = BdsLH.Find("MALOP", maLH);//lệnh FIND tìm khóa chính trên BDS. position bằng số mấy con troe chuột tự động nhảy đến dòng đó
                    return;
                }
            }
            if (BdsLH.Count == 0) BtnXoaLH.Enabled = false;
        }

        private void BtnGhiLH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(TxtMaLop.Text.Trim()=="")
            {
                MessageBox.Show("Mã lớp không được để trống!", "", MessageBoxButtons.OK);
                TxtMaLop.Focus();
                return;
            }
            if (TxtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được để trống!", "", MessageBoxButtons.OK);
                TxtTenLop.Focus();
                return;
            }
            if (TxtKhoaHoc.Text.Trim() == "")
            {
                MessageBox.Show("Khóa học không được để trống!", "", MessageBoxButtons.OK);
                TxtKhoaHoc.Focus();
                return;
            }

            try
            {
                BdsLH.EndEdit(); //kt hiệu chỉnh ghi vào bds
                BdsLH.ResetCurrentItem(); //đưa thông tin lên lưới
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Update(this.DS1.LOP); //update csdl
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp học.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            GcLopHoc.Enabled = true;
            panelControl2.Enabled = false;
            BtnThemLH.Enabled = BtnThoatLH.Enabled = BtnXoaLH.Enabled = BtnLamMoiLH.Enabled = true;
            BtnGhiLH.Enabled = BtnPhucHoiLH.Enabled = false;

        }

        private void BtnThoatLH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}

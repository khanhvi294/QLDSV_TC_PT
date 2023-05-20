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
            BdsLH.AddNew();
            TxtMaSV.Focus();
            BtnThem.Enabled = BtnXoa.Enabled = BtnLamMoi.Enabled = BtnThoat.Enabled = BtnSua.Enabled = false;
            BtnGhi.Enabled = BtnPhucHoi.Enabled = true;
            GcLopHoc.Enabled = false;
            GcSinhVien.Enabled = false;
            // TxtMaLop.Text = this.lOPTableAdapter.GetData();
        }

        private void BtnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // undoStk.Undo();
          /*  this.sINHVIENBindingSource.EndEdit();
            this.sINHVIENBindingSource.ResetCurrentItem();
            this.sINHVIENTableAdapter.Update(this.qLDSVDataSet);

            if (undoStk.Empty())
            {
                undoBtn.Enabled = false;
            }*/
        }

        private void BtnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
    }
}

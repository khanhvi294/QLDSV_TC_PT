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
            // TODO: This line of code loads data into the 'DS1.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.DS1.SINHVIEN);
            // TODO: This line of code loads data into the 'dS1.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.DS1.LOP);

        }
    }
}

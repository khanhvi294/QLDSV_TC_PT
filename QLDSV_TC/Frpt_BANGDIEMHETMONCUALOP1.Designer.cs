
namespace QLDSV_TC
{
    partial class Frpt_BANGDIEMHETMONCUALOP1
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
            System.Windows.Forms.Label tENMHLabel1;
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label nHOMLabel;
            System.Windows.Forms.Label hOCKYLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKHOA = new System.Windows.Forms.ComboBox();
            this.dS = new QLDSV_TC.DS();
            this.tableAdapterManager = new QLDSV_TC.DSTableAdapters.TableAdapterManager();
            this.gIANGVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIANGVIENTableAdapter = new QLDSV_TC.DSTableAdapters.GIANGVIENTableAdapter();
            this.bdsMONHOC = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new QLDSV_TC.DSTableAdapters.MONHOCTableAdapter();
            this.cmbTENMH = new System.Windows.Forms.ComboBox();
            this.nIENKHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nIENKHOATableAdapter = new QLDSV_TC.DSTableAdapters.NIENKHOATableAdapter();
            this.cmbNIENKHOA = new System.Windows.Forms.ComboBox();
            this.nHOMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHOMTableAdapter = new QLDSV_TC.DSTableAdapters.NHOMTableAdapter();
            this.hOCKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOCKYTableAdapter = new QLDSV_TC.DSTableAdapters.HOCKYTableAdapter();
            this.cmbHOCKY = new System.Windows.Forms.ComboBox();
            this.cmbNHOM = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            tENMHLabel1 = new System.Windows.Forms.Label();
            nIENKHOALabel = new System.Windows.Forms.Label();
            nHOMLabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIENKHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tENMHLabel1
            // 
            tENMHLabel1.AutoSize = true;
            tENMHLabel1.Location = new System.Drawing.Point(134, 290);
            tENMHLabel1.Name = "tENMHLabel1";
            tENMHLabel1.Size = new System.Drawing.Size(57, 17);
            tENMHLabel1.TabIndex = 28;
            tENMHLabel1.Text = "TENMH:";
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Location = new System.Drawing.Point(580, 369);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(78, 17);
            nIENKHOALabel.TabIndex = 32;
            nIENKHOALabel.Text = "NIENKHOA:";
            // 
            // nHOMLabel
            // 
            nHOMLabel.AutoSize = true;
            nHOMLabel.Location = new System.Drawing.Point(706, 157);
            nHOMLabel.Name = "nHOMLabel";
            nHOMLabel.Size = new System.Drawing.Size(51, 17);
            nHOMLabel.TabIndex = 34;
            nHOMLabel.Text = "NHOM:";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Location = new System.Drawing.Point(371, 207);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(57, 17);
            hOCKYLabel.TabIndex = 35;
            hOCKYLabel.Text = "HOCKY:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "KHOA";
            // 
            // cmbKHOA
            // 
            this.cmbKHOA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKHOA.FormattingEnabled = true;
            this.cmbKHOA.Location = new System.Drawing.Point(234, 48);
            this.cmbKHOA.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKHOA.Name = "cmbKHOA";
            this.cmbKHOA.Size = new System.Drawing.Size(529, 24);
            this.cmbKHOA.TabIndex = 23;
            this.cmbKHOA.SelectedIndexChanged += new System.EventHandler(this.cmbKHOA_SelectedIndexChanged);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.SP_CHECKMONHOC_ID_NAMETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gIANGVIENBindingSource
            // 
            this.gIANGVIENBindingSource.DataMember = "GIANGVIEN";
            this.gIANGVIENBindingSource.DataSource = this.dS;
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // bdsMONHOC
            // 
            this.bdsMONHOC.DataMember = "MONHOC";
            this.bdsMONHOC.DataSource = this.dS;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // cmbTENMH
            // 
            this.cmbTENMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMONHOC, "TENMH", true));
            this.cmbTENMH.FormattingEnabled = true;
            this.cmbTENMH.Location = new System.Drawing.Point(234, 110);
            this.cmbTENMH.Name = "cmbTENMH";
            this.cmbTENMH.Size = new System.Drawing.Size(121, 24);
            this.cmbTENMH.TabIndex = 29;
            this.cmbTENMH.SelectedIndexChanged += new System.EventHandler(this.cmbTENMH_SelectedIndexChanged_1);
            // 
            // nIENKHOABindingSource
            // 
            this.nIENKHOABindingSource.DataMember = "NIENKHOA";
            this.nIENKHOABindingSource.DataSource = this.dS;
            // 
            // nIENKHOATableAdapter
            // 
            this.nIENKHOATableAdapter.ClearBeforeFill = true;
            // 
            // cmbNIENKHOA
            // 
            this.cmbNIENKHOA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nIENKHOABindingSource, "NIENKHOA", true));
            this.cmbNIENKHOA.FormattingEnabled = true;
            this.cmbNIENKHOA.Location = new System.Drawing.Point(664, 366);
            this.cmbNIENKHOA.Name = "cmbNIENKHOA";
            this.cmbNIENKHOA.Size = new System.Drawing.Size(121, 24);
            this.cmbNIENKHOA.TabIndex = 33;
            // 
            // nHOMBindingSource
            // 
            this.nHOMBindingSource.DataMember = "NHOM";
            this.nHOMBindingSource.DataSource = this.dS;
            // 
            // nHOMTableAdapter
            // 
            this.nHOMTableAdapter.ClearBeforeFill = true;
            // 
            // hOCKYBindingSource
            // 
            this.hOCKYBindingSource.DataMember = "HOCKY";
            this.hOCKYBindingSource.DataSource = this.dS;
            // 
            // hOCKYTableAdapter
            // 
            this.hOCKYTableAdapter.ClearBeforeFill = true;
            // 
            // cmbHOCKY
            // 
            this.cmbHOCKY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHOCKY.FormattingEnabled = true;
            this.cmbHOCKY.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbHOCKY.Location = new System.Drawing.Point(452, 200);
            this.cmbHOCKY.Name = "cmbHOCKY";
            this.cmbHOCKY.Size = new System.Drawing.Size(121, 24);
            this.cmbHOCKY.TabIndex = 36;
            // 
            // cmbNHOM
            // 
            this.cmbNHOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNHOM.FormattingEnabled = true;
            this.cmbNHOM.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbNHOM.Location = new System.Drawing.Point(774, 148);
            this.cmbNHOM.Name = "cmbNHOM";
            this.cmbNHOM.Size = new System.Drawing.Size(121, 24);
            this.cmbNHOM.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "IN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Frpt_BANGDIEMHETMONCUALOP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbNHOM);
            this.Controls.Add(this.cmbHOCKY);
            this.Controls.Add(hOCKYLabel);
            this.Controls.Add(nHOMLabel);
            this.Controls.Add(nIENKHOALabel);
            this.Controls.Add(this.cmbNIENKHOA);
            this.Controls.Add(tENMHLabel1);
            this.Controls.Add(this.cmbTENMH);
            this.Controls.Add(this.cmbKHOA);
            this.Controls.Add(this.label1);
            this.Name = "Frpt_BANGDIEMHETMONCUALOP1";
            this.Text = "XtraForm1";
            this.Load += new System.EventHandler(this.Frpt_BANGDIEMHETMONCUALOP1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIENKHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKHOA;
        private DS dS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource gIANGVIENBindingSource;
        private DSTableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsMONHOC;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.ComboBox cmbTENMH;
        private System.Windows.Forms.BindingSource nIENKHOABindingSource;
        private DSTableAdapters.NIENKHOATableAdapter nIENKHOATableAdapter;
        private System.Windows.Forms.ComboBox cmbNIENKHOA;
        private System.Windows.Forms.BindingSource nHOMBindingSource;
        private DSTableAdapters.NHOMTableAdapter nHOMTableAdapter;
        private System.Windows.Forms.BindingSource hOCKYBindingSource;
        private DSTableAdapters.HOCKYTableAdapter hOCKYTableAdapter;
        private System.Windows.Forms.ComboBox cmbHOCKY;
        private System.Windows.Forms.ComboBox cmbNHOM;
        private System.Windows.Forms.Button button1;
    }
}
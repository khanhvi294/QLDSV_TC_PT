
namespace QLDSV_TC
{
    partial class Frpt_BANGDIENMONHOCCUALTC
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
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label nHOMLabel;
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label tENMHLabel;
            this.cmbKHOA = new System.Windows.Forms.ComboBox();
            this.dS = new QLDSV_TC.DS();
            this.bdsNIENKHOA = new System.Windows.Forms.BindingSource(this.components);
            this.nIENKHOATableAdapter = new QLDSV_TC.DSTableAdapters.NIENKHOATableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DSTableAdapters.TableAdapterManager();
            this.cmbNIENKHOA = new System.Windows.Forms.ComboBox();
            this.bdsTENMOCHOC = new System.Windows.Forms.BindingSource(this.components);
            this.tENMONHOCTableAdapter = new QLDSV_TC.DSTableAdapters.TENMONHOCTableAdapter();
            this.bdsNHOM = new System.Windows.Forms.BindingSource(this.components);
            this.nHOMTableAdapter = new QLDSV_TC.DSTableAdapters.NHOMTableAdapter();
            this.cmbNHOM = new System.Windows.Forms.ComboBox();
            this.bdsHOCKY = new System.Windows.Forms.BindingSource(this.components);
            this.hOCKYTableAdapter = new QLDSV_TC.DSTableAdapters.HOCKYTableAdapter();
            this.cmbHOCKY = new System.Windows.Forms.ComboBox();
            this.cmbTENMH = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabFormControl1 = new DevExpress.XtraBars.TabFormControl();
            this.tabFormContentContainer1 = new DevExpress.XtraBars.TabFormContentContainer();
            this.tabFormPage1 = new DevExpress.XtraBars.TabFormPage();
            nIENKHOALabel = new System.Windows.Forms.Label();
            nHOMLabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNIENKHOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTENMOCHOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNHOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHOCKY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            this.tabFormControl1.SuspendLayout();
            this.tabFormContentContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Location = new System.Drawing.Point(120, 130);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(78, 17);
            nIENKHOALabel.TabIndex = 4;
            nIENKHOALabel.Text = "NIENKHOA:";
            // 
            // nHOMLabel
            // 
            nHOMLabel.AutoSize = true;
            nHOMLabel.Location = new System.Drawing.Point(120, 228);
            nHOMLabel.Name = "nHOMLabel";
            nHOMLabel.Size = new System.Drawing.Size(51, 17);
            nHOMLabel.TabIndex = 7;
            nHOMLabel.Text = "NHOM:";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Location = new System.Drawing.Point(120, 179);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(57, 17);
            hOCKYLabel.TabIndex = 9;
            hOCKYLabel.Text = "HOCKY:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(130, 286);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(57, 17);
            tENMHLabel.TabIndex = 10;
            tENMHLabel.Text = "TENMH:";
            tENMHLabel.Click += new System.EventHandler(this.tENMHLabel_Click);
            // 
            // cmbKHOA
            // 
            this.cmbKHOA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKHOA.FormattingEnabled = true;
            this.cmbKHOA.Location = new System.Drawing.Point(196, 64);
            this.cmbKHOA.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKHOA.Name = "cmbKHOA";
            this.cmbKHOA.Size = new System.Drawing.Size(613, 24);
            this.cmbKHOA.TabIndex = 3;
            this.cmbKHOA.SelectedIndexChanged += new System.EventHandler(this.cmbKHOA_SelectedIndexChanged);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNIENKHOA
            // 
            this.bdsNIENKHOA.DataMember = "NIENKHOA";
            this.bdsNIENKHOA.DataSource = this.dS;
            // 
            // nIENKHOATableAdapter
            // 
            this.nIENKHOATableAdapter.ClearBeforeFill = true;
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
            // cmbNIENKHOA
            // 
            this.cmbNIENKHOA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNIENKHOA.FormattingEnabled = true;
            this.cmbNIENKHOA.Location = new System.Drawing.Point(196, 39);
            this.cmbNIENKHOA.Name = "cmbNIENKHOA";
            this.cmbNIENKHOA.Size = new System.Drawing.Size(613, 24);
            this.cmbNIENKHOA.TabIndex = 5;
            // 
            // bdsTENMOCHOC
            // 
            this.bdsTENMOCHOC.DataMember = "TENMONHOC";
            this.bdsTENMOCHOC.DataSource = this.dS;
            // 
            // tENMONHOCTableAdapter
            // 
            this.tENMONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // bdsNHOM
            // 
            this.bdsNHOM.DataMember = "NHOM";
            this.bdsNHOM.DataSource = this.dS;
            // 
            // nHOMTableAdapter
            // 
            this.nHOMTableAdapter.ClearBeforeFill = true;
            // 
            // cmbNHOM
            // 
            this.cmbNHOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNHOM.FormattingEnabled = true;
            this.cmbNHOM.Location = new System.Drawing.Point(196, 137);
            this.cmbNHOM.Name = "cmbNHOM";
            this.cmbNHOM.Size = new System.Drawing.Size(629, 24);
            this.cmbNHOM.TabIndex = 8;
            // 
            // bdsHOCKY
            // 
            this.bdsHOCKY.DataMember = "HOCKY";
            this.bdsHOCKY.DataSource = this.dS;
            // 
            // hOCKYTableAdapter
            // 
            this.hOCKYTableAdapter.ClearBeforeFill = true;
            // 
            // cmbHOCKY
            // 
            this.cmbHOCKY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHOCKY.FormattingEnabled = true;
            this.cmbHOCKY.Location = new System.Drawing.Point(196, 84);
            this.cmbHOCKY.Name = "cmbHOCKY";
            this.cmbHOCKY.Size = new System.Drawing.Size(629, 24);
            this.cmbHOCKY.TabIndex = 10;
            // 
            // cmbTENMH
            // 
            this.cmbTENMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTENMOCHOC, "TENMH", true));
            this.cmbTENMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTENMH.FormattingEnabled = true;
            this.cmbTENMH.Location = new System.Drawing.Point(196, 191);
            this.cmbTENMH.Name = "cmbTENMH";
            this.cmbTENMH.Size = new System.Drawing.Size(629, 24);
            this.cmbTENMH.TabIndex = 11;
            this.cmbTENMH.SelectedIndexChanged += new System.EventHandler(this.tENMHComboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(679, 82);
            this.button1.TabIndex = 12;
            this.button1.Text = "IN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "KHOA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabFormControl1
            // 
            this.tabFormControl1.Controls.Add(this.cmbKHOA);
            this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.Pages.Add(this.tabFormPage1);
            this.tabFormControl1.SelectedPage = this.tabFormPage1;
            this.tabFormControl1.Size = new System.Drawing.Size(1223, 88);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 13;
            this.tabFormControl1.TabStop = false;
            this.tabFormControl1.Text = "z";
            // 
            // tabFormContentContainer1
            // 
            this.tabFormContentContainer1.Controls.Add(this.cmbNHOM);
            this.tabFormContentContainer1.Controls.Add(this.cmbTENMH);
            this.tabFormContentContainer1.Controls.Add(this.cmbHOCKY);
            this.tabFormContentContainer1.Controls.Add(this.cmbNIENKHOA);
            this.tabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer1.Location = new System.Drawing.Point(0, 88);
            this.tabFormContentContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabFormContentContainer1.Name = "tabFormContentContainer1";
            this.tabFormContentContainer1.Size = new System.Drawing.Size(1223, 362);
            this.tabFormContentContainer1.TabIndex = 14;
            // 
            // tabFormPage1
            // 
            this.tabFormPage1.ContentContainer = this.tabFormContentContainer1;
            this.tabFormPage1.Name = "tabFormPage1";
            this.tabFormPage1.Text = "Page 0";
            // 
            // Frpt_BANGDIENMONHOCCUALTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(tENMHLabel);
            this.Controls.Add(hOCKYLabel);
            this.Controls.Add(nHOMLabel);
            this.Controls.Add(nIENKHOALabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabFormContentContainer1);
            this.Controls.Add(this.tabFormControl1);
            this.Name = "Frpt_BANGDIENMONHOCCUALTC";
            this.TabFormControl = this.tabFormControl1;
            this.Text = "Frpt_BANGDIENMONHOCCUALTC";
            this.Load += new System.EventHandler(this.Frpt_BANGDIENMONHOCCUALTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNIENKHOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTENMOCHOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNHOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHOCKY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            this.tabFormControl1.ResumeLayout(false);
            this.tabFormContentContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKHOA;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsNIENKHOA;
        private DSTableAdapters.NIENKHOATableAdapter nIENKHOATableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbNIENKHOA;
        private System.Windows.Forms.BindingSource bdsTENMOCHOC;
        private DSTableAdapters.TENMONHOCTableAdapter tENMONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsNHOM;
        private DSTableAdapters.NHOMTableAdapter nHOMTableAdapter;
        private System.Windows.Forms.ComboBox cmbNHOM;
        private System.Windows.Forms.BindingSource bdsHOCKY;
        private DSTableAdapters.HOCKYTableAdapter hOCKYTableAdapter;
        private System.Windows.Forms.ComboBox cmbHOCKY;
        private System.Windows.Forms.ComboBox cmbTENMH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.TabFormControl tabFormControl1;
        private DevExpress.XtraBars.TabFormPage tabFormPage1;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
    }
}
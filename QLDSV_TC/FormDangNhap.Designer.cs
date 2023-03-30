
namespace QLDSV_TC
{
    partial class FormDangNhap
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
            this.CmbKhoa = new System.Windows.Forms.ComboBox();
            this.TxbTaiKhoan = new System.Windows.Forms.TextBox();
            this.TxbMatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelTK = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbSinhVien = new System.Windows.Forms.CheckBox();
            this.BtnDangNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbKhoa
            // 
            this.CmbKhoa.FormattingEnabled = true;
            this.CmbKhoa.Location = new System.Drawing.Point(155, 53);
            this.CmbKhoa.Name = "CmbKhoa";
            this.CmbKhoa.Size = new System.Drawing.Size(240, 24);
            this.CmbKhoa.TabIndex = 0;
            this.CmbKhoa.SelectedIndexChanged += new System.EventHandler(this.CmbKhoa_SelectedIndexChanged);
            // 
            // TxbTaiKhoan
            // 
            this.TxbTaiKhoan.Location = new System.Drawing.Point(155, 116);
            this.TxbTaiKhoan.Name = "TxbTaiKhoan";
            this.TxbTaiKhoan.Size = new System.Drawing.Size(240, 22);
            this.TxbTaiKhoan.TabIndex = 1;
            // 
            // TxbMatKhau
            // 
            this.TxbMatKhau.Location = new System.Drawing.Point(155, 180);
            this.TxbMatKhau.Name = "TxbMatKhau";
            this.TxbMatKhau.Size = new System.Drawing.Size(240, 22);
            this.TxbMatKhau.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phòng/Khoa";
            // 
            // LabelTK
            // 
            this.LabelTK.AutoSize = true;
            this.LabelTK.Location = new System.Drawing.Point(152, 96);
            this.LabelTK.Name = "LabelTK";
            this.LabelTK.Size = new System.Drawing.Size(73, 17);
            this.LabelTK.TabIndex = 4;
            this.LabelTK.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật Khẩu";
            // 
            // CbSinhVien
            // 
            this.CbSinhVien.AutoSize = true;
            this.CbSinhVien.Location = new System.Drawing.Point(297, 92);
            this.CbSinhVien.Name = "CbSinhVien";
            this.CbSinhVien.Size = new System.Drawing.Size(90, 21);
            this.CbSinhVien.TabIndex = 6;
            this.CbSinhVien.Text = "Sinh Viên";
            this.CbSinhVien.UseVisualStyleBackColor = true;
            this.CbSinhVien.CheckedChanged += new System.EventHandler(this.CbSinhVien_CheckedChanged);
            // 
            // BtnDangNhap
            // 
            this.BtnDangNhap.Location = new System.Drawing.Point(155, 241);
            this.BtnDangNhap.Name = "BtnDangNhap";
            this.BtnDangNhap.Size = new System.Drawing.Size(240, 23);
            this.BtnDangNhap.TabIndex = 7;
            this.BtnDangNhap.Text = "Đăng Nhập";
            this.BtnDangNhap.UseVisualStyleBackColor = true;
            this.BtnDangNhap.Click += new System.EventHandler(this.BtnDangNhap_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 288);
            this.Controls.Add(this.BtnDangNhap);
            this.Controls.Add(this.CbSinhVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelTK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbMatKhau);
            this.Controls.Add(this.TxbTaiKhoan);
            this.Controls.Add(this.CmbKhoa);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDangNhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbKhoa;
        private System.Windows.Forms.TextBox TxbTaiKhoan;
        private System.Windows.Forms.TextBox TxbMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CbSinhVien;
        private System.Windows.Forms.Button BtnDangNhap;
    }
}
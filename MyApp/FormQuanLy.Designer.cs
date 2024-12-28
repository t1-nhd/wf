namespace MyApp
{
    partial class frmMain
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
            this.txtRole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnNguoiBan = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnHang = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRole
            // 
            this.txtRole.BackColor = System.Drawing.SystemColors.Info;
            this.txtRole.Location = new System.Drawing.Point(295, 11);
            this.txtRole.Margin = new System.Windows.Forms.Padding(2);
            this.txtRole.Multiline = true;
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(75, 23);
            this.txtRole.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Location = new System.Drawing.Point(11, 61);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(158, 45);
            this.btnKhachHang.TabIndex = 2;
            this.btnKhachHang.Text = "Quản lý Khách hàng";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNguoiBan
            // 
            this.btnNguoiBan.Location = new System.Drawing.Point(11, 110);
            this.btnNguoiBan.Margin = new System.Windows.Forms.Padding(2);
            this.btnNguoiBan.Name = "btnNguoiBan";
            this.btnNguoiBan.Size = new System.Drawing.Size(158, 45);
            this.btnNguoiBan.TabIndex = 6;
            this.btnNguoiBan.Text = "Quản lý Người bán";
            this.btnNguoiBan.UseVisualStyleBackColor = true;
            this.btnNguoiBan.Click += new System.EventHandler(this.btnNguoiBan_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(11, 208);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(158, 45);
            this.btnNhap.TabIndex = 7;
            this.btnNhap.Text = "Quản lý nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnHang
            // 
            this.btnHang.Location = new System.Drawing.Point(11, 159);
            this.btnHang.Margin = new System.Windows.Forms.Padding(2);
            this.btnHang.Name = "btnHang";
            this.btnHang.Size = new System.Drawing.Size(158, 45);
            this.btnHang.TabIndex = 4;
            this.btnHang.Text = "Quản lý Hàng hóa";
            this.btnHang.UseVisualStyleBackColor = true;
            this.btnHang.Click += new System.EventHandler(this.btnHang_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Location = new System.Drawing.Point(11, 11);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(158, 45);
            this.btnTaiKhoan.TabIndex = 5;
            this.btnTaiKhoan.Text = "Quản lý Tài khoản";
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(11, 257);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(158, 45);
            this.btnXuat.TabIndex = 7;
            this.btnXuat.Text = "Quản lý xuất";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(283, 273);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 29);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 207);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Đổi mật khẩu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(283, 240);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Đăng xuất";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 311);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.btnNguoiBan);
            this.Controls.Add(this.btnTaiKhoan);
            this.Controls.Add(this.btnHang);
            this.Controls.Add(this.btnKhachHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRole);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.TrangChu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnNguoiBan;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnHang;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
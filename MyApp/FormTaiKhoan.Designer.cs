namespace MyApp
{
    partial class FormTaiKhoan
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
            this.dgv_taiKhoan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginNameTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userNameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.roleCb = new System.Windows.Forms.ComboBox();
            this.searchBt = new System.Windows.Forms.Button();
            this.createBt = new System.Windows.Forms.Button();
            this.backBt = new System.Windows.Forms.Button();
            this.resetBt = new System.Windows.Forms.Button();
            this.updateBt = new System.Windows.Forms.Button();
            this.deleteBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_taiKhoan
            // 
            this.dgv_taiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_taiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_taiKhoan.Location = new System.Drawing.Point(13, 217);
            this.dgv_taiKhoan.Name = "dgv_taiKhoan";
            this.dgv_taiKhoan.Size = new System.Drawing.Size(499, 212);
            this.dgv_taiKhoan.TabIndex = 0;
            this.dgv_taiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_taiKhoan_CellClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên người dùng";
            // 
            // loginNameTb
            // 
            this.loginNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginNameTb.Location = new System.Drawing.Point(167, 60);
            this.loginNameTb.Name = "loginNameTb";
            this.loginNameTb.Size = new System.Drawing.Size(215, 24);
            this.loginNameTb.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tài khoản đăng nhập";
            // 
            // userNameTb
            // 
            this.userNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTb.Location = new System.Drawing.Point(167, 90);
            this.userNameTb.Name = "userNameTb";
            this.userNameTb.Size = new System.Drawing.Size(215, 24);
            this.userNameTb.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Chọn vai trò";
            // 
            // roleCb
            // 
            this.roleCb.AutoCompleteCustomSource.AddRange(new string[] {
            "Director",
            "Inspection_staff",
            "Sales_staff",
            "Accountant"});
            this.roleCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleCb.FormattingEnabled = true;
            this.roleCb.Items.AddRange(new object[] {
            "Director",
            "Inspection_staff",
            "Sales_staff",
            "Accountant"});
            this.roleCb.Location = new System.Drawing.Point(167, 120);
            this.roleCb.Name = "roleCb";
            this.roleCb.Size = new System.Drawing.Size(215, 26);
            this.roleCb.TabIndex = 3;
            // 
            // searchBt
            // 
            this.searchBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBt.Location = new System.Drawing.Point(388, 60);
            this.searchBt.Name = "searchBt";
            this.searchBt.Size = new System.Drawing.Size(123, 28);
            this.searchBt.TabIndex = 4;
            this.searchBt.Text = "Tìm kiếm";
            this.searchBt.UseVisualStyleBackColor = true;
            this.searchBt.Click += new System.EventHandler(this.searchBt_Click);
            // 
            // createBt
            // 
            this.createBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBt.Location = new System.Drawing.Point(130, 172);
            this.createBt.Name = "createBt";
            this.createBt.Size = new System.Drawing.Size(123, 28);
            this.createBt.TabIndex = 5;
            this.createBt.Text = "Thêm tài khoản";
            this.createBt.UseVisualStyleBackColor = true;
            this.createBt.Click += new System.EventHandler(this.createBt_Click);
            // 
            // backBt
            // 
            this.backBt.Location = new System.Drawing.Point(13, 13);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(75, 23);
            this.backBt.TabIndex = 6;
            this.backBt.Text = "Quay lại";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // resetBt
            // 
            this.resetBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBt.Location = new System.Drawing.Point(388, 90);
            this.resetBt.Name = "resetBt";
            this.resetBt.Size = new System.Drawing.Size(123, 28);
            this.resetBt.TabIndex = 5;
            this.resetBt.Text = "Reset";
            this.resetBt.UseVisualStyleBackColor = true;
            this.resetBt.Click += new System.EventHandler(this.resetBt_Click);
            // 
            // updateBt
            // 
            this.updateBt.Enabled = false;
            this.updateBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBt.Location = new System.Drawing.Point(259, 172);
            this.updateBt.Name = "updateBt";
            this.updateBt.Size = new System.Drawing.Size(123, 28);
            this.updateBt.TabIndex = 6;
            this.updateBt.Text = "Cập nhật";
            this.updateBt.UseVisualStyleBackColor = true;
            this.updateBt.Click += new System.EventHandler(this.updateBt_Click);
            // 
            // deleteBt
            // 
            this.deleteBt.Enabled = false;
            this.deleteBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBt.Location = new System.Drawing.Point(388, 172);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.Size = new System.Drawing.Size(123, 28);
            this.deleteBt.TabIndex = 7;
            this.deleteBt.Text = "Xóa tài khoản";
            this.deleteBt.UseVisualStyleBackColor = true;
            this.deleteBt.Click += new System.EventHandler(this.deleteBt_Click);
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 441);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.deleteBt);
            this.Controls.Add(this.updateBt);
            this.Controls.Add(this.createBt);
            this.Controls.Add(this.resetBt);
            this.Controls.Add(this.searchBt);
            this.Controls.Add(this.roleCb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userNameTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginNameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_taiKhoan);
            this.Name = "FormTaiKhoan";
            this.Text = "FormTaiKhoan";
            this.Load += new System.EventHandler(this.FormTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_taiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginNameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userNameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox roleCb;
        private System.Windows.Forms.Button searchBt;
        private System.Windows.Forms.Button createBt;
        private System.Windows.Forms.Button backBt;
        private System.Windows.Forms.Button resetBt;
        private System.Windows.Forms.Button updateBt;
        private System.Windows.Forms.Button deleteBt;
    }
}
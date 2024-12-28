namespace MyApp
{
    partial class FormHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_hang = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tenHangTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.donGiaTb = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.updateBt = new System.Windows.Forms.Button();
            this.createBt = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.maHtb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGiaTb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý mặt hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_hang
            // 
            this.dgv_hang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hang.Location = new System.Drawing.Point(17, 213);
            this.dgv_hang.Name = "dgv_hang";
            this.dgv_hang.Size = new System.Drawing.Size(473, 278);
            this.dgv_hang.TabIndex = 1;
            this.dgv_hang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã mặt hàng";
            // 
            // tenHangTb
            // 
            this.tenHangTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenHangTb.Location = new System.Drawing.Point(116, 81);
            this.tenHangTb.Name = "tenHangTb";
            this.tenHangTb.Size = new System.Drawing.Size(270, 24);
            this.tenHangTb.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(392, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá";
            // 
            // donGiaTb
            // 
            this.donGiaTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donGiaTb.Location = new System.Drawing.Point(116, 113);
            this.donGiaTb.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.donGiaTb.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.donGiaTb.Name = "donGiaTb";
            this.donGiaTb.Size = new System.Drawing.Size(225, 24);
            this.donGiaTb.TabIndex = 5;
            this.donGiaTb.ThousandsSeparator = true;
            this.donGiaTb.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(347, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "VND";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(392, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // updateBt
            // 
            this.updateBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBt.Location = new System.Drawing.Point(330, 161);
            this.updateBt.Name = "updateBt";
            this.updateBt.Size = new System.Drawing.Size(160, 27);
            this.updateBt.TabIndex = 4;
            this.updateBt.Text = "Cập nhật sản phẩm";
            this.updateBt.UseVisualStyleBackColor = true;
            this.updateBt.Click += new System.EventHandler(this.updateBt_Click);
            // 
            // createBt
            // 
            this.createBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBt.Location = new System.Drawing.Point(167, 161);
            this.createBt.Name = "createBt";
            this.createBt.Size = new System.Drawing.Size(157, 27);
            this.createBt.TabIndex = 4;
            this.createBt.Text = "Thêm sản phẩm";
            this.createBt.UseVisualStyleBackColor = true;
            this.createBt.Click += new System.EventHandler(this.createBt_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Trở lại";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // maHtb
            // 
            this.maHtb.Enabled = false;
            this.maHtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maHtb.Location = new System.Drawing.Point(116, 51);
            this.maHtb.Name = "maHtb";
            this.maHtb.Size = new System.Drawing.Size(270, 24);
            this.maHtb.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên mặt hàng";
            // 
            // FormHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 503);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.donGiaTb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.createBt);
            this.Controls.Add(this.updateBt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maHtb);
            this.Controls.Add(this.tenHangTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_hang);
            this.Controls.Add(this.label1);
            this.Name = "FormHang";
            this.Text = "FormHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGiaTb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_hang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tenHangTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown donGiaTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button updateBt;
        private System.Windows.Forms.Button createBt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox maHtb;
        private System.Windows.Forms.Label label5;
    }
}
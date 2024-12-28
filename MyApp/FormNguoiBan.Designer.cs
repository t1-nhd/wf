using System.Drawing;
using System.Windows.Forms;

namespace MyApp
{
    partial class FormNguoiBan
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNB = new System.Windows.Forms.TextBox();
            this.txtTenNB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Người Bán";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(645, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bảng người bán";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Người Bán";
            // 
            // txtMaNB
            // 
            this.txtMaNB.Enabled = false;
            this.txtMaNB.Location = new System.Drawing.Point(115, 65);
            this.txtMaNB.Name = "txtMaNB";
            this.txtMaNB.Size = new System.Drawing.Size(125, 20);
            this.txtMaNB.TabIndex = 0;
            // 
            // txtTenNB
            // 
            this.txtTenNB.Location = new System.Drawing.Point(115, 113);
            this.txtTenNB.Name = "txtTenNB";
            this.txtTenNB.Size = new System.Drawing.Size(225, 20);
            this.txtTenNB.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Địa Chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(115, 161);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(375, 20);
            this.txtDiaChi.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(563, 65);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 28);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(563, 113);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(94, 28);
            this.btnCapNhat.TabIndex = 8;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(563, 161);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 28);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(645, 210);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Quay lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormNguoiBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 457);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenNB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaNB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormNguoiBan";
            this.Text = "FormNguoiBan";
            this.Load += new System.EventHandler(this.FormNguoiBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMaNB;
        private TextBox txtTenNB;
        private Label label4;
        private TextBox txtDiaChi;
        private Button btnThem;
        private Button btnCapNhat;
        private Button btnXoa;
        private DataGridView dataGridView1;
        private Label label3;
        private Button button1;
    }
}
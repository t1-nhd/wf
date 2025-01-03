﻿namespace MyApp
{
    partial class FormThemXuat
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
            this.backBt = new System.Windows.Forms.Button();
            this.saveXuatBt = new System.Windows.Forms.Button();
            this.cancelUpdateItemBt = new System.Windows.Forms.Button();
            this.updateItemBt = new System.Windows.Forms.Button();
            this.addItemBt = new System.Windows.Forms.Button();
            this.lastPriceLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.unitPriceLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.productCbBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maHDXlabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cusNameCbBox = new System.Windows.Forms.ComboBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVNewXuatCT = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNewXuatCT)).BeginInit();
            this.SuspendLayout();
            // 
            // backBt
            // 
            this.backBt.Location = new System.Drawing.Point(12, 11);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(75, 23);
            this.backBt.TabIndex = 39;
            this.backBt.Text = "Quay lại";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // saveXuatBt
            // 
            this.saveXuatBt.Enabled = false;
            this.saveXuatBt.Location = new System.Drawing.Point(466, 417);
            this.saveXuatBt.Name = "saveXuatBt";
            this.saveXuatBt.Size = new System.Drawing.Size(191, 41);
            this.saveXuatBt.TabIndex = 38;
            this.saveXuatBt.Text = "Lưu hóa đơn";
            this.saveXuatBt.UseVisualStyleBackColor = true;
            this.saveXuatBt.Click += new System.EventHandler(this.saveXuatBt_Click);
            // 
            // cancelUpdateItemBt
            // 
            this.cancelUpdateItemBt.Location = new System.Drawing.Point(466, 371);
            this.cancelUpdateItemBt.Name = "cancelUpdateItemBt";
            this.cancelUpdateItemBt.Size = new System.Drawing.Size(191, 23);
            this.cancelUpdateItemBt.TabIndex = 37;
            this.cancelUpdateItemBt.Text = "Hủy";
            this.cancelUpdateItemBt.UseVisualStyleBackColor = true;
            this.cancelUpdateItemBt.Visible = false;
            this.cancelUpdateItemBt.Click += new System.EventHandler(this.cancelUpdateItemBt_Click);
            // 
            // updateItemBt
            // 
            this.updateItemBt.Location = new System.Drawing.Point(466, 342);
            this.updateItemBt.Name = "updateItemBt";
            this.updateItemBt.Size = new System.Drawing.Size(191, 23);
            this.updateItemBt.TabIndex = 36;
            this.updateItemBt.Text = "Cập nhật chi tiết";
            this.updateItemBt.UseVisualStyleBackColor = true;
            this.updateItemBt.Visible = false;
            this.updateItemBt.Click += new System.EventHandler(this.updateItemBt_Click);
            // 
            // addItemBt
            // 
            this.addItemBt.Location = new System.Drawing.Point(466, 342);
            this.addItemBt.Name = "addItemBt";
            this.addItemBt.Size = new System.Drawing.Size(191, 23);
            this.addItemBt.TabIndex = 35;
            this.addItemBt.Text = "Thêm chi tiết";
            this.addItemBt.UseVisualStyleBackColor = true;
            this.addItemBt.Click += new System.EventHandler(this.addItemBt_Click);
            // 
            // lastPriceLabel
            // 
            this.lastPriceLabel.AutoSize = true;
            this.lastPriceLabel.Location = new System.Drawing.Point(533, 311);
            this.lastPriceLabel.Name = "lastPriceLabel";
            this.lastPriceLabel.Size = new System.Drawing.Size(30, 13);
            this.lastPriceLabel.TabIndex = 34;
            this.lastPriceLabel.Text = "VND";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(463, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Thành tiền:";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(466, 261);
            this.quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantity.Name = "quantity";
            this.quantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.quantity.Size = new System.Drawing.Size(191, 20);
            this.quantity.TabIndex = 32;
            this.quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantity.ValueChanged += new System.EventHandler(this.quantity_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(463, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Số lượng:";
            // 
            // unitPriceLabel
            // 
            this.unitPriceLabel.AutoSize = true;
            this.unitPriceLabel.Location = new System.Drawing.Point(533, 208);
            this.unitPriceLabel.Name = "unitPriceLabel";
            this.unitPriceLabel.Size = new System.Drawing.Size(30, 13);
            this.unitPriceLabel.TabIndex = 30;
            this.unitPriceLabel.Text = "VND";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(463, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Đơn giá:";
            // 
            // productCbBox
            // 
            this.productCbBox.FormattingEnabled = true;
            this.productCbBox.Location = new System.Drawing.Point(466, 173);
            this.productCbBox.Name = "productCbBox";
            this.productCbBox.Size = new System.Drawing.Size(191, 21);
            this.productCbBox.TabIndex = 28;
            this.productCbBox.SelectedIndexChanged += new System.EventHandler(this.productCbBox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(604, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Kho:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(569, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Kho:";
            // 
            // maHDXlabel
            // 
            this.maHDXlabel.AutoSize = true;
            this.maHDXlabel.Location = new System.Drawing.Point(463, 157);
            this.maHDXlabel.Name = "maHDXlabel";
            this.maHDXlabel.Size = new System.Drawing.Size(55, 13);
            this.maHDXlabel.TabIndex = 25;
            this.maHDXlabel.Text = "Mặt hàng:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(463, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Thêm các chi tiết";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cusNameCbBox
            // 
            this.cusNameCbBox.FormattingEnabled = true;
            this.cusNameCbBox.Location = new System.Drawing.Point(132, 86);
            this.cusNameCbBox.Name = "cusNameCbBox";
            this.cusNameCbBox.Size = new System.Drawing.Size(235, 21);
            this.cusNameCbBox.TabIndex = 23;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(463, 89);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(15, 13);
            this.dateLabel.TabIndex = 22;
            this.dateLabel.Text = "lb";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(569, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "HDX000001";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(495, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mã hóa đơn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ngày xuất:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Thông tin chung";
            // 
            // DGVNewXuatCT
            // 
            this.DGVNewXuatCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVNewXuatCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNewXuatCT.Location = new System.Drawing.Point(12, 122);
            this.DGVNewXuatCT.Name = "DGVNewXuatCT";
            this.DGVNewXuatCT.ReadOnly = true;
            this.DGVNewXuatCT.Size = new System.Drawing.Size(445, 336);
            this.DGVNewXuatCT.TabIndex = 16;
            this.DGVNewXuatCT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVNewXuatCT_CellClick);
            this.DGVNewXuatCT.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVNewXuatCT_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(645, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Hóa đơn xuất chi tiết";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormThemXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 468);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.saveXuatBt);
            this.Controls.Add(this.cancelUpdateItemBt);
            this.Controls.Add(this.updateItemBt);
            this.Controls.Add(this.addItemBt);
            this.Controls.Add(this.lastPriceLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.unitPriceLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.productCbBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maHDXlabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cusNameCbBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGVNewXuatCT);
            this.Controls.Add(this.label1);
            this.Name = "FormThemXuat";
            this.Text = "FormXuatChiTiet";
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNewXuatCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBt;
        private System.Windows.Forms.Button saveXuatBt;
        private System.Windows.Forms.Button cancelUpdateItemBt;
        private System.Windows.Forms.Button updateItemBt;
        private System.Windows.Forms.Button addItemBt;
        private System.Windows.Forms.Label lastPriceLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label unitPriceLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox productCbBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label maHDXlabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cusNameCbBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVNewXuatCT;
        private System.Windows.Forms.Label label1;
    }
}
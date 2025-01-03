﻿namespace MyApp
{
    partial class FormThemNhap
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
            this.saveXuatBt = new System.Windows.Forms.Button();
            this.cancelUpdateItemBt = new System.Windows.Forms.Button();
            this.updateItemBt = new System.Windows.Forms.Button();
            this.addItemBt = new System.Windows.Forms.Button();
            this.taxDecrease = new System.Windows.Forms.Label();
            this.lastPriceLb = new System.Windows.Forms.Label();
            this.totalAllPriceLb = new System.Windows.Forms.Label();
            this.totalPriceLb = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.taxLb = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.unitPriceLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.productCbBox = new System.Windows.Forms.ComboBox();
            this.maHDXlabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.empNameCbBox = new System.Windows.Forms.ComboBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVNewNhapCT = new System.Windows.Forms.DataGridView();
            this.backBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNewNhapCT)).BeginInit();
            this.SuspendLayout();
            // 
            // saveXuatBt
            // 
            this.saveXuatBt.Enabled = false;
            this.saveXuatBt.Location = new System.Drawing.Point(459, 521);
            this.saveXuatBt.Name = "saveXuatBt";
            this.saveXuatBt.Size = new System.Drawing.Size(194, 41);
            this.saveXuatBt.TabIndex = 66;
            this.saveXuatBt.Text = "Lưu hóa đơn";
            this.saveXuatBt.UseVisualStyleBackColor = true;
            this.saveXuatBt.Click += new System.EventHandler(this.saveXuatBt_Click);
            // 
            // cancelUpdateItemBt
            // 
            this.cancelUpdateItemBt.Location = new System.Drawing.Point(459, 476);
            this.cancelUpdateItemBt.Name = "cancelUpdateItemBt";
            this.cancelUpdateItemBt.Size = new System.Drawing.Size(194, 23);
            this.cancelUpdateItemBt.TabIndex = 63;
            this.cancelUpdateItemBt.Text = "Hủy";
            this.cancelUpdateItemBt.UseVisualStyleBackColor = true;
            this.cancelUpdateItemBt.Visible = false;
            this.cancelUpdateItemBt.Click += new System.EventHandler(this.cancelUpdateItemBt_Click);
            // 
            // updateItemBt
            // 
            this.updateItemBt.Location = new System.Drawing.Point(459, 447);
            this.updateItemBt.Name = "updateItemBt";
            this.updateItemBt.Size = new System.Drawing.Size(194, 23);
            this.updateItemBt.TabIndex = 64;
            this.updateItemBt.Text = "Cập nhật chi tiết";
            this.updateItemBt.UseVisualStyleBackColor = true;
            this.updateItemBt.Visible = false;
            this.updateItemBt.Click += new System.EventHandler(this.updateItemBt_Click);
            // 
            // addItemBt
            // 
            this.addItemBt.Location = new System.Drawing.Point(459, 447);
            this.addItemBt.Name = "addItemBt";
            this.addItemBt.Size = new System.Drawing.Size(194, 23);
            this.addItemBt.TabIndex = 65;
            this.addItemBt.Text = "Thêm chi tiết";
            this.addItemBt.UseVisualStyleBackColor = true;
            this.addItemBt.Click += new System.EventHandler(this.addItemBt_Click);
            // 
            // taxDecrease
            // 
            this.taxDecrease.Location = new System.Drawing.Point(553, 391);
            this.taxDecrease.Name = "taxDecrease";
            this.taxDecrease.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.taxDecrease.Size = new System.Drawing.Size(98, 13);
            this.taxDecrease.TabIndex = 58;
            this.taxDecrease.Text = "0VND";
            this.taxDecrease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastPriceLb
            // 
            this.lastPriceLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastPriceLb.Location = new System.Drawing.Point(507, 415);
            this.lastPriceLb.Name = "lastPriceLb";
            this.lastPriceLb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lastPriceLb.Size = new System.Drawing.Size(144, 13);
            this.lastPriceLb.TabIndex = 57;
            this.lastPriceLb.Text = "0VND";
            // 
            // totalAllPriceLb
            // 
            this.totalAllPriceLb.Location = new System.Drawing.Point(526, 368);
            this.totalAllPriceLb.Name = "totalAllPriceLb";
            this.totalAllPriceLb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalAllPriceLb.Size = new System.Drawing.Size(125, 13);
            this.totalAllPriceLb.TabIndex = 56;
            this.totalAllPriceLb.Text = "0VND";
            // 
            // totalPriceLb
            // 
            this.totalPriceLb.Location = new System.Drawing.Point(526, 309);
            this.totalPriceLb.Name = "totalPriceLb";
            this.totalPriceLb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalPriceLb.Size = new System.Drawing.Size(125, 13);
            this.totalPriceLb.TabIndex = 55;
            this.totalPriceLb.Text = "VND";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(459, 415);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 62;
            this.label12.Text = "TỔNG";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(459, 368);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 61;
            this.label14.Text = "Tổng tiền:";
            // 
            // taxLb
            // 
            this.taxLb.AutoSize = true;
            this.taxLb.Location = new System.Drawing.Point(459, 391);
            this.taxLb.Name = "taxLb";
            this.taxLb.Size = new System.Drawing.Size(65, 13);
            this.taxLb.TabIndex = 60;
            this.taxLb.Text = "Thuế GTGT";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(459, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 59;
            this.label11.Text = "Thành tiền:";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(459, 277);
            this.quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantity.Name = "quantity";
            this.quantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.quantity.Size = new System.Drawing.Size(191, 20);
            this.quantity.TabIndex = 54;
            this.quantity.ThousandsSeparator = true;
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
            this.label10.Location = new System.Drawing.Point(459, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Số lượng:";
            // 
            // unitPriceLabel
            // 
            this.unitPriceLabel.Location = new System.Drawing.Point(512, 232);
            this.unitPriceLabel.Name = "unitPriceLabel";
            this.unitPriceLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.unitPriceLabel.Size = new System.Drawing.Size(139, 13);
            this.unitPriceLabel.TabIndex = 51;
            this.unitPriceLabel.Text = "VND";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(459, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Đơn giá:";
            // 
            // productCbBox
            // 
            this.productCbBox.FormattingEnabled = true;
            this.productCbBox.Location = new System.Drawing.Point(459, 199);
            this.productCbBox.Name = "productCbBox";
            this.productCbBox.Size = new System.Drawing.Size(194, 21);
            this.productCbBox.TabIndex = 50;
            this.productCbBox.SelectedIndexChanged += new System.EventHandler(this.productCbBox_SelectedIndexChanged);
            // 
            // maHDXlabel
            // 
            this.maHDXlabel.AutoSize = true;
            this.maHDXlabel.Location = new System.Drawing.Point(459, 183);
            this.maHDXlabel.Name = "maHDXlabel";
            this.maHDXlabel.Size = new System.Drawing.Size(55, 13);
            this.maHDXlabel.TabIndex = 49;
            this.maHDXlabel.Text = "Mặt hàng:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(459, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 23);
            this.label6.TabIndex = 48;
            this.label6.Text = "Thêm các chi tiết";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // empNameCbBox
            // 
            this.empNameCbBox.FormattingEnabled = true;
            this.empNameCbBox.Location = new System.Drawing.Point(139, 102);
            this.empNameCbBox.Name = "empNameCbBox";
            this.empNameCbBox.Size = new System.Drawing.Size(235, 21);
            this.empNameCbBox.TabIndex = 47;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(470, 105);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(15, 13);
            this.dateLabel.TabIndex = 42;
            this.dateLabel.Text = "lb";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(576, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "HDN000001";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(502, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Mã hóa đơn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Ngày nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Nhân viên nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Thông tin chung";
            // 
            // DGVNewNhapCT
            // 
            this.DGVNewNhapCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNewNhapCT.Location = new System.Drawing.Point(11, 148);
            this.DGVNewNhapCT.Name = "DGVNewNhapCT";
            this.DGVNewNhapCT.ReadOnly = true;
            this.DGVNewNhapCT.Size = new System.Drawing.Size(442, 414);
            this.DGVNewNhapCT.TabIndex = 40;
            this.DGVNewNhapCT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVNewNhapCT_CellClick);
            this.DGVNewNhapCT.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVNewNhapCT_CellDoubleClick);
            // 
            // backBt
            // 
            this.backBt.Location = new System.Drawing.Point(11, 11);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(75, 23);
            this.backBt.TabIndex = 39;
            this.backBt.Text = "Quay lại";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "Hóa đơn nhập chi tiết";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormThemNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 572);
            this.Controls.Add(this.saveXuatBt);
            this.Controls.Add(this.cancelUpdateItemBt);
            this.Controls.Add(this.updateItemBt);
            this.Controls.Add(this.addItemBt);
            this.Controls.Add(this.taxDecrease);
            this.Controls.Add(this.lastPriceLb);
            this.Controls.Add(this.totalAllPriceLb);
            this.Controls.Add(this.totalPriceLb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.taxLb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.unitPriceLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.productCbBox);
            this.Controls.Add(this.maHDXlabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.empNameCbBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGVNewNhapCT);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.label1);
            this.Name = "FormThemNhap";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNewNhapCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveXuatBt;
        private System.Windows.Forms.Button cancelUpdateItemBt;
        private System.Windows.Forms.Button updateItemBt;
        private System.Windows.Forms.Button addItemBt;
        private System.Windows.Forms.Label taxDecrease;
        private System.Windows.Forms.Label lastPriceLb;
        private System.Windows.Forms.Label totalAllPriceLb;
        private System.Windows.Forms.Label totalPriceLb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label taxLb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label unitPriceLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox productCbBox;
        private System.Windows.Forms.Label maHDXlabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox empNameCbBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVNewNhapCT;
        private System.Windows.Forms.Button backBt;
        private System.Windows.Forms.Label label1;
    }
}
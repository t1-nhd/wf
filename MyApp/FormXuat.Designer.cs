namespace MyApp
{
    partial class FormXuat
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
            this.createXuatBt = new System.Windows.Forms.Button();
            this.dataGridXuat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // createXuatBt
            // 
            this.createXuatBt.Location = new System.Drawing.Point(590, 10);
            this.createXuatBt.Name = "createXuatBt";
            this.createXuatBt.Size = new System.Drawing.Size(75, 31);
            this.createXuatBt.TabIndex = 5;
            this.createXuatBt.Text = "Thêm";
            this.createXuatBt.UseVisualStyleBackColor = true;
            this.createXuatBt.Click += new System.EventHandler(this.createXuatBt_Click);
            // 
            // dataGridXuat
            // 
            this.dataGridXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridXuat.Location = new System.Drawing.Point(12, 100);
            this.dataGridXuat.Name = "dataGridXuat";
            this.dataGridXuat.ReadOnly = true;
            this.dataGridXuat.Size = new System.Drawing.Size(653, 408);
            this.dataGridXuat.TabIndex = 4;
            this.dataGridXuat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridXuat_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(653, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh sách xuất";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Quay lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.createXuatBt);
            this.Controls.Add(this.dataGridXuat);
            this.Controls.Add(this.label1);
            this.Name = "FormXuat";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridXuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createXuatBt;
        private System.Windows.Forms.DataGridView dataGridXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
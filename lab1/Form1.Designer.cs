namespace lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSothunhat = new TextBox();
            txtSothuhai = new TextBox();
            txtKetqua = new TextBox();
            btnTinh = new Button();
            btnClear = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 30);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 0;
            label1.Text = "TÍNH TỔNG 2 SỐ NGUYÊN";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 78);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Số thứ nhất";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 132);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Số thứ 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 260);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 3;
            label4.Text = "Kết quả";
            // 
            // txtSothunhat
            // 
            txtSothunhat.Location = new Point(186, 78);
            txtSothunhat.Name = "txtSothunhat";
            txtSothunhat.Size = new Size(125, 27);
            txtSothunhat.TabIndex = 4;
            txtSothunhat.TextChanged += txtSothunhat_TextChanged;
            // 
            // txtSothuhai
            // 
            txtSothuhai.Location = new Point(186, 125);
            txtSothuhai.Name = "txtSothuhai";
            txtSothuhai.Size = new Size(125, 27);
            txtSothuhai.TabIndex = 5;
            txtSothuhai.TextChanged += txtSothu2_TextChanged;
            // 
            // txtKetqua
            // 
            txtKetqua.Location = new Point(175, 257);
            txtKetqua.Name = "txtKetqua";
            txtKetqua.ReadOnly = true;
            txtKetqua.Size = new Size(125, 27);
            txtKetqua.TabIndex = 6;
            txtKetqua.TextChanged += txtKetqua_TextChanged;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(136, 193);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(94, 29);
            btnTinh.TabIndex = 7;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(54, 356);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 8;
            btnClear.Text = "Xóa";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(245, 356);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnClear);
            Controls.Add(btnTinh);
            Controls.Add(txtKetqua);
            Controls.Add(txtSothuhai);
            Controls.Add(txtSothunhat);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSothunhat;
        private TextBox txtSothuhai;
        private TextBox txtKetqua;
        private Button btnTinh;
        private Button btnClear;
        private Button btnThoat;
    }
}
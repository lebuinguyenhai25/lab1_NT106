namespace lab1_cau2
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
            btnTim = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtSothunhat = new TextBox();
            txtSothuhai = new TextBox();
            txtSothuba = new TextBox();
            txtSolonnhat = new TextBox();
            txtSonhonhat = new TextBox();
            SuspendLayout();
            // 
            // btnTim
            // 
            btnTim.Location = new Point(147, 208);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 29);
            btnTim.TabIndex = 0;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(342, 208);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(543, 208);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 89);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 3;
            label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 86);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 4;
            label2.Text = "Số thứ hai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(543, 86);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 5;
            label3.Text = "số thứ 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(125, 328);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 6;
            label4.Text = "Số lớn nhất";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(416, 328);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 7;
            label5.Text = "Số nhỏ nhất";
            // 
            // txtSothunhat
            // 
            txtSothunhat.Location = new Point(116, 86);
            txtSothunhat.Name = "txtSothunhat";
            txtSothunhat.Size = new Size(125, 27);
            txtSothunhat.TabIndex = 8;
            txtSothunhat.TextChanged += txtSothunhat_TextChanged;
            // 
            // txtSothuhai
            // 
            txtSothuhai.Location = new Point(360, 83);
            txtSothuhai.Name = "txtSothuhai";
            txtSothuhai.Size = new Size(125, 27);
            txtSothuhai.TabIndex = 9;
            txtSothuhai.TextChanged += txtSothuhai_TextChanged;
            // 
            // txtSothuba
            // 
            txtSothuba.Location = new Point(615, 82);
            txtSothuba.Name = "txtSothuba";
            txtSothuba.Size = new Size(125, 27);
            txtSothuba.TabIndex = 10;
            txtSothuba.TextChanged += txtSothuba_TextChanged;
            // 
            // txtSolonnhat
            // 
            txtSolonnhat.Location = new Point(217, 325);
            txtSolonnhat.Name = "txtSolonnhat";
            txtSolonnhat.ReadOnly = true;
            txtSolonnhat.Size = new Size(125, 27);
            txtSolonnhat.TabIndex = 11;
            txtSolonnhat.TextChanged += txtSolonnhat_TextChanged;
            // 
            // txtSonhonhat
            // 
            txtSonhonhat.Location = new Point(512, 325);
            txtSonhonhat.Name = "txtSonhonhat";
            txtSonhonhat.ReadOnly = true;
            txtSonhonhat.Size = new Size(125, 27);
            txtSonhonhat.TabIndex = 12;
            txtSonhonhat.TextChanged += txtSonhonhat_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 458);
            Controls.Add(txtSonhonhat);
            Controls.Add(txtSolonnhat);
            Controls.Add(txtSothuba);
            Controls.Add(txtSothuhai);
            Controls.Add(txtSothunhat);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnTim);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTim;
        private Button btnXoa;
        private Button btnThoat;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtSothunhat;
        private TextBox txtSothuhai;
        private TextBox txtSothuba;
        private TextBox txtSolonnhat;
        private TextBox txtSonhonhat;
    }
}
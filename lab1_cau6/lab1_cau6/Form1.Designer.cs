namespace lab1_cau6
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            btnTinh = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 56);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(466, 56);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập B";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(582, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bảng cửu chương", "Tính toán" });
            comboBox1.Location = new Point(318, 140);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 334);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 5;
            label3.Text = "Kết quả";
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(140, 231);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(94, 29);
            btnTinh.TabIndex = 6;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(348, 231);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(541, 231);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(202, 293);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(365, 148);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 493);
            Controls.Add(richTextBox1);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnTinh);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label3;
        private Button btnTinh;
        private Button btnXoa;
        private Button btnThoat;
        private RichTextBox richTextBox1;
    }
}
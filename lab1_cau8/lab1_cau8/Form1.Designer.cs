namespace lab1_cau8
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
            btnXuat = new Button();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textDTB = new TextBox();
            textMaxMin = new TextBox();
            textSoMonDau = new TextBox();
            textXepLoai = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 55);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập dữ liệu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 159);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Thông Tin";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(582, 55);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(116, 62);
            btnXuat.TabIndex = 2;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(341, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(150, 156);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(424, 110);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 301);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 5;
            label3.Text = "Điểm Trung Bình";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 383);
            label4.Name = "label4";
            label4.Size = new Size(170, 20);
            label4.TabIndex = 6;
            label4.Text = "Môn cao nhất, thấp nhất";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(355, 301);
            label5.Name = "label5";
            label5.Size = new Size(166, 20);
            label5.TabIndex = 7;
            label5.Text = "Số môn đậu, không đậu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(547, 379);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 8;
            label6.Text = "Xếp loại";
            // 
            // textDTB
            // 
            textDTB.Location = new Point(150, 294);
            textDTB.Name = "textDTB";
            textDTB.ReadOnly = true;
            textDTB.Size = new Size(114, 27);
            textDTB.TabIndex = 9;
            // 
            // textMaxMin
            // 
            textMaxMin.Location = new Point(209, 376);
            textMaxMin.Name = "textMaxMin";
            textMaxMin.ReadOnly = true;
            textMaxMin.Size = new Size(282, 27);
            textMaxMin.TabIndex = 10;
            // 
            // textSoMonDau
            // 
            textSoMonDau.Location = new Point(556, 298);
            textSoMonDau.Name = "textSoMonDau";
            textSoMonDau.ReadOnly = true;
            textSoMonDau.Size = new Size(201, 27);
            textSoMonDau.TabIndex = 11;
            // 
            // textXepLoai
            // 
            textXepLoai.Location = new Point(649, 377);
            textXepLoai.Name = "textXepLoai";
            textXepLoai.ReadOnly = true;
            textXepLoai.Size = new Size(99, 27);
            textXepLoai.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textXepLoai);
            Controls.Add(textSoMonDau);
            Controls.Add(textMaxMin);
            Controls.Add(textDTB);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(btnXuat);
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
        private Button btnXuat;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textDTB;
        private TextBox textMaxMin;
        private TextBox textSoMonDau;
        private TextBox textXepLoai;
    }
}
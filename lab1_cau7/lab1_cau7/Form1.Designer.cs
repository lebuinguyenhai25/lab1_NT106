namespace lab1_cau7
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
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            btnTinh = new Button();
            btnKetQua = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(321, 102);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(378, 34);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 102);
            label1.Name = "label1";
            label1.Size = new Size(259, 28);
            label1.TabIndex = 5;
            label1.Text = "Chọn ngày tháng năm sinh";
            // 
            // btnTinh
            // 
            btnTinh.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnTinh.Location = new Point(271, 180);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(94, 49);
            btnTinh.TabIndex = 6;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnKetQua
            // 
            btnKetQua.AutoSize = true;
            btnKetQua.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnKetQua.Location = new Point(144, 323);
            btnKetQua.Name = "btnKetQua";
            btnKetQua.Size = new Size(93, 31);
            btnKetQua.TabIndex = 7;
            btnKetQua.Text = "Kết quả";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(296, 297);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(280, 89);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(btnKetQua);
            Controls.Add(btnTinh);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Button btnTinh;
        private Label btnKetQua;
        private RichTextBox richTextBox1;
    }
}
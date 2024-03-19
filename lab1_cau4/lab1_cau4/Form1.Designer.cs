namespace lab1_cau4
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
            txtSo = new TextBox();
            txtKetqua = new TextBox();
            btnDoc = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 107);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập số cần đọc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 285);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Kết quả";
            // 
            // txtSo
            // 
            txtSo.Location = new Point(271, 107);
            txtSo.Name = "txtSo";
            txtSo.Size = new Size(125, 27);
            txtSo.TabIndex = 2;
            txtSo.TextChanged += txtSo_TextChanged;
            // 
            // txtKetqua
            // 
            txtKetqua.Location = new Point(183, 282);
            txtKetqua.Name = "txtKetqua";
            txtKetqua.ReadOnly = true;
            txtKetqua.Size = new Size(300, 27);
            txtKetqua.TabIndex = 3;
            // 
            // btnDoc
            // 
            btnDoc.Location = new Point(598, 107);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(94, 29);
            btnDoc.TabIndex = 4;
            btnDoc.Text = "Đọc";
            btnDoc.UseVisualStyleBackColor = true;
            btnDoc.Click += btnDoc_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(598, 192);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(598, 276);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnDoc);
            Controls.Add(txtKetqua);
            Controls.Add(txtSo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSo;
        private TextBox txtKetqua;
        private Button btnDoc;
        private Button btnXoa;
        private Button btnThoat;
    }
}
namespace lab1_cau9
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            btnThem = new Button();
            btnTim = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            label2 = new Label();
            textKetqua = new TextBox();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(405, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(271, 240);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách món";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 55);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập món ăn";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(276, 95);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(46, 282);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(136, 41);
            btnTim.TabIndex = 5;
            btnTim.Text = "Tìm món ăn";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(313, 282);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 41);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(520, 282);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 41);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 368);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 8;
            label2.Text = "Món ăn hôm nay là";
            // 
            // textKetqua
            // 
            textKetqua.Location = new Point(295, 368);
            textKetqua.Name = "textKetqua";
            textKetqua.ReadOnly = true;
            textKetqua.Size = new Size(212, 27);
            textKetqua.TabIndex = 9;
            textKetqua.TextChanged += textKetqua_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 450);
            Controls.Add(textKetqua);
            Controls.Add(label2);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnTim);
            Controls.Add(btnThem);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private Button btnThem;
        private Button btnTim;
        private Button btnXoa;
        private Button btnThoat;
        private Label label2;
        private TextBox textKetqua;
    }
}
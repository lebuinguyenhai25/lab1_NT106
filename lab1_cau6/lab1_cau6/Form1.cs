using System;
using static System.Math;
namespace lab1_cau6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, b;
        Boolean isBangCuuChuong = false;
        Boolean isTinhToan = false;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") == true) return;
            if (!int.TryParse(textBox1.Text, out a))
            {
                MessageBox.Show("Nhập giá trị là số nguyên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Equals("") == true) return;
            if (!int.TryParse(textBox2.Text, out b))
            {
                MessageBox.Show("Nhập số nguyên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem.ToString();
            switch (selected)
            {
                case "Bảng cửu chương":
                    isBangCuuChuong = true;
                    break;
                case "Tính toán":
                    isTinhToan = true;
                    break;
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (isBangCuuChuong)
            {
                if (a > b) // Ensure valid range for multiplication table
                {
                    richTextBox1.Text = "Giá trị a phải nhỏ hơn hoặc bằng b để in bảng cửu chương.\n";
                    return;
                }

                int n = b - a;

                string result = "";

                for (int j = 1; j <= 10; j++)
                {
                    result += $"{n} x {j} = {n * j}\t";
                    result += "\n";

                }

                richTextBox1.Text = result;
            }
            if (isTinhToan)
            {
                int n = a - b;
                long s = 1;
                for (int i = 1; i <= n; i++)
                {
                    s *= i;
                }
                double result = 0;
                for (int i = 1; i <= b; i++)
                {
                    result += Math.Pow(a, i);
                }
                richTextBox1.Text = $"Kết quả:\n" +
                         $" - (a - b)! = {s}\n" +
                         $" - a^1 + a^2 + ... + a^b = {result}";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.richTextBox1.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

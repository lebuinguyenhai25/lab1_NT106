using System.Text.RegularExpressions;

namespace lab1_cau8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnXuat_Click(object sender, EventArgs e)
        {

            string input = textBox1.Text;
            string[] parts = input.Split(',');
            if (parts.Length < 2)
            {
                MessageBox.Show("Lỗi: Dữ liệu nhập không hợp lệ. Vui lòng nhập theo định dạng 'Họ và tên, Điểm 1, Điểm 2, ...'.");
                return;
            }

            string hoTen = parts[0];
            double[] diem = new double[parts.Length - 1];
            if (!Regex.IsMatch(hoTen, @"^[a-zA-Z ]+$"))
            {
                MessageBox.Show("Lỗi: Họ và tên không hợp lệ. Vui lòng nhập tên chính xác.");
                return;
            }

            for (int i = 1; i < parts.Length; i++)
            {
                diem[i - 1] = double.Parse(parts[i]);
            }
            string Xuat = " ";
            Xuat += $" Họ và Tên: {hoTen}\n";
            for (int i = 1; i <= diem.Length; i++)
            {
                Xuat += $"Môn {i}: {diem[i - 1]}  ";
            }
            richTextBox1.Text = Xuat;
            double s = 0;
            for (int i = 0; i < diem.Length; i++)
            {
                s += diem[i];
            }
            double dtb = s / diem.Length;
            textDTB.Text = dtb.ToString();
            double max, min;
            max = diem[0];
            min = diem[0];
            for (int i = 0; i < diem.Length; i++)
            {
                if (diem[i] > max)
                {
                    max = diem[i];
                }
            }
            for (int i = 0; i < diem.Length; i++)
            {
                if (diem[i] < min)
                {
                    min = diem[i];
                }
            }
            textMaxMin.Text = $"Điểm lớn nhất: {max}, Điểm nhỏ nhất: {min}";
            int monDau = 0, monRot = 0;
            for (int i = 0; i < diem.Length; i++)
            {
                if (diem[i] < 5)
                {
                    monRot++;
                }
                else monDau++;
            }
            textSoMonDau.Text = $"Số môn đậu: {monDau}, Số môn rớt: {monRot}";
            if (dtb >= 8)
            {
                textXepLoai.Text = "Giỏi";
            }
            if (dtb < 8 && dtb >= 6.5)
            {
                textXepLoai.Text = "Khá";
            }
            if (dtb < 6 && dtb >= 5)
            {
                textXepLoai.Text = "Trung Binh";
            }
            if (dtb < 5 && dtb >= 3.5)
            {
                textXepLoai.Text = "Yếu";
            }
            if(dtb<3.5)
            {
                textXepLoai.Text = "Kém";
            }
        }
    }
}
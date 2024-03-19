using System;
using System.Windows.Forms;
namespace lab1_cau7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dob = dateTimePicker1.Value;

        }

        private string getCungHoangDao(DateTime dob)
        {
            // Mảng 12 cung hoàng đạo
            string[] Cung = { "Ma Kết", "Bảo Bình", "Song Ngư", "Bạch Dương", "Kim Ngưu", "Song Tử", "Cự Giải", "Sư Tử", "Xử Nữ", "Thiên Bình", "Bọ Cạp", "Nhân Mã" };

            // Tính tháng sinh
            int month = dob.Month;

            // Tính ngày sinh
            int day = dob.Day;

            // Xác định cung hoàng đạo dựa vào tháng và ngày sinh
            int n = (month - 1) * 2 + (day >= 21 ? 1 : 0);

            return Cung[n];
        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            DateTime dob = dateTimePicker1.Value;
            string CungHoangDao = getCungHoangDao(dob);
            richTextBox1.Text = $"Cung hoàng đạo của bạn là: {CungHoangDao}";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
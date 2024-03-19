namespace lab1_cau3
{
    public partial class Form1 : Form
    {
        int a;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtSo_TextChanged(object sender, EventArgs e)
        {
            if (txtSo.Text.Equals("") == true) return;
            if (!int.TryParse(txtSo.Text, out a))
            {
                MessageBox.Show("Nhập số nguyên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            string[] soChu = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            int so = Convert.ToInt32(txtSo.Text);
            if (so < 0 || so > 9)
            {
                MessageBox.Show("Số nhập vào phải từ 0 đến 9", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtKetqua.Text = soChu[so];
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtSo.Clear();
            this.txtKetqua.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
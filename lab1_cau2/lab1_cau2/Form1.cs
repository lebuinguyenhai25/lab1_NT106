namespace lab1_cau2
{
    public partial class Form1 : Form
    {
        int a, b, c, min, max;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtSothunhat_TextChanged(object sender, EventArgs e)
        {
            if (txtSothunhat.Text.Equals("") == true) return;
            if (!int.TryParse(txtSothunhat.Text, out a))
            {
                MessageBox.Show("Nhập số nguyên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSothuhai_TextChanged(object sender, EventArgs e)
        {
            if (txtSothuhai.Text.Equals("") == true) return;
            if (!int.TryParse(txtSothuhai.Text, out b))
            {
                MessageBox.Show("Nhập số nguyên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSothuba_TextChanged(object sender, EventArgs e)
        {
            if (txtSothuba.Text.Equals("") == true) return;
            if (!int.TryParse(txtSothuba.Text, out c))
            {
                MessageBox.Show("Nhập số nguyên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(txtSothunhat.Text);
            b = Convert.ToInt32(txtSothuhai.Text);
            c = Convert.ToInt32(txtSothuba.Text);
            max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            this.txtSolonnhat.Text = max.ToString();
            this.txtSonhonhat.Text = min.ToString();

        }

        private void txtSolonnhat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSonhonhat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtSothunhat.Clear();
            this.txtSothuhai.Clear();
            this.txtSothuba.Clear();
            this.txtSolonnhat.Clear();
            this.txtSonhonhat.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
namespace lab1
{
    public partial class Form1 : Form
    {
        int a, b;
        long kq;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void txtSothunhat_TextChanged(object sender, EventArgs e)
        {
            if (txtSothunhat.Text.Equals("") == true) return;
            if(!int.TryParse(txtSothunhat.Text, out a))
            {
                MessageBox.Show("Nhập giá trị là số nguyên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtSothu2_TextChanged(object sender, EventArgs e)
        {
            if (txtSothuhai.Text.Equals("") == true) return;
            if(!int.TryParse(txtSothuhai.Text, out b)) 
            {
                MessageBox.Show("Nhập giá trị là số nguyên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(txtSothunhat.Text);
            b = Convert.ToInt32(txtSothuhai.Text);
            kq = a + b;
            this.txtKetqua.Text = kq.ToString();
        }

        private void txtKetqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtKetqua.Clear();
            this.txtSothunhat.Clear();
            this.txtSothuhai.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
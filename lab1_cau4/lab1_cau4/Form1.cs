namespace lab1_cau4
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

        private void txtSo_TextChanged(object sender, EventArgs e)
        {
            if (txtSo.Text.Equals("") == true) return;
            if (!long.TryParse(txtSo.Text, out long a))
            {
                MessageBox.Show("Nhập số nguyên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
        }

        private string DocDonVi(long so)
        {
            string[] hangDonVi = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            return hangDonVi[so];
        }

        private string DocHangChuc(long so, bool full)
        {
            string[] hangChuc = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
            if (so == 0) return full ? "lẻ" : "";
            return hangChuc[so];
        }

        private string DocBlock(long so, bool full)
        {
            string kq = "";
            long tram = so / 100;
            so = so % 100;
            if (full || tram > 0) kq += DocDonVi(tram) + " trăm ";
            kq += DocHangChuc(so / 10, tram > 0);
            if (so % 10 > 0) kq += " " + DocDonVi(so % 10);
            return kq;
        }

        private string DocSo(long so)
        {
            if (so == 0) return "không";
            string[] hang = { "", " nghìn ", " triệu ", " tỷ " };
            string kq = "";
            int i = 0;
            while (so > 0)
            {
                long block = so % 1000;
                if (block > 0)
                {
                    string blockText = DocBlock(block, so > 999);
                    kq = blockText + hang[i] + kq;
                }
                so /= 1000;
                i++;
            }
            return kq.Trim();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            if (long.TryParse(txtSo.Text, out long so))
            {
                txtKetqua.Text = DocSo(so);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtKetqua.Clear();
            this.txtSo.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


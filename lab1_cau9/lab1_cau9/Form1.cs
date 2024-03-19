namespace lab1_cau9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string FoodItem;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FoodItem = textBox1.Text;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FoodItem))
            {
                MessageBox.Show("Please enter a food item!");
                return;
            }

            // Create a new Label to display the food item
            Label foodLabel = new Label();
            foodLabel.Text = FoodItem;
            groupBox1.Controls.Add(foodLabel);
            foodLabel.Location = new Point(10, groupBox1.Controls.Count * 20);
            groupBox1.Controls.Add(foodLabel);
            textBox1.Text = "";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (groupBox1.Controls.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập món ăn trước tiên");
                return;
            }
            List<string> FoodItem = new List<string>();
            foreach (Control control in groupBox1.Controls)
            {
                if (control is Label label)
                {
                    string foodName = label.Text;
                    FoodItem.Add(foodName);
                }
            }
            int n = new Random().Next(FoodItem.Count);
            string monAn = FoodItem[n];
            textKetqua.Text = monAn;
        }

        private void textKetqua_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.textKetqua.Clear();
            this.textBox1.Clear();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
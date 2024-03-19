﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_cau5
{
    public partial class Form1 : Form
    {
        int Gia;
        private bool daChonPhim = false;
        List<Button> DanhSachChon = new List<Button>();
        int Thanhtien = 0;
        private string phepToan;
        public Form1()
        {

            InitializeComponent();
            txtThanhTien.Enabled = false;
            // Tạo MenuStrip
            MenuStrip menuStrip1 = new MenuStrip();
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Size = new Size(384, 44);
            this.Controls.Add(menuStrip1);

            // Tạo mục con
            ToolStripMenuItem toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem1.Text = "Danh sách phim";
            menuStrip1.Items.Add(toolStripMenuItem1);

            ToolStripMenuItem luaChon1;
            ToolStripMenuItem luaChon2;
            ToolStripMenuItem luaChon3;

            // Tạo các đối tượng
            luaChon1 = new ToolStripMenuItem();
            luaChon1.Text = "Đào Phở và Piano";
            toolStripMenuItem1.DropDownItems.Add(luaChon1);

            luaChon2 = new ToolStripMenuItem();
            luaChon2.Text = "Mai";
            toolStripMenuItem1.DropDownItems.Add(luaChon2);

            luaChon3 = new ToolStripMenuItem();
            luaChon3.Text = "Dune";
            toolStripMenuItem1.DropDownItems.Add(luaChon3);
            luaChon1.Click += (sender, e) => { daChonPhim = true; Gia = 45000; MessageBox.Show($"Gia: {Gia}"); };
            luaChon2.Click += (sender, e) => { daChonPhim = true; Gia = 100000; MessageBox.Show($"Gia: {Gia}"); };
            luaChon3.Click += (sender, e) => { daChonPhim = true; Gia = 70000; MessageBox.Show($"Gia: {Gia}"); };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Tag = 1;

            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Có người chọn rồi");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Tag = 2;

            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Có người chọn rồi");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Tag = 3;

            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Có người chọn rồi");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Tag = 4;

            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Có người chọn rồi");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                btn.Tag = 5;

                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Có người chọn rồi");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                btn.Tag = 6;

                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Có người chọn rồi");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                btn.Tag = 7;

                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Có người chọn rồi");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                btn.Tag = 8;

                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Có người chọn rồi");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                btn.Tag = 9;

                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Có người chọn rồi");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                btn.Tag = 10;

                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Có người chọn rồi");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                btn.Tag = 11;
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Có người chọn rồi");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                btn.Tag = 12;
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Có người chọn rồi");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                btn.Tag = 13;
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Có người chọn rồi");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                btn.Tag = 14;
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Có người chọn rồi");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                btn.Tag = 15;
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Có người chọn rồi");
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (!daChonPhim)
            {
                MessageBox.Show("Vui lòng chọn phim trước", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (Button b in DanhSachChon)
            {
                int a = (int)b.Tag;
                if (a == 2 || a == 3 || a == 4 || a == 12 || a == 13 || a == 14 || a == 6 || a == 10)
                {
                    b.BackColor = Color.Yellow;
                    Thanhtien = Thanhtien + Gia;
                }
                if (a == 1 || a == 5 || a == 11 || a == 15)
                {
                    b.BackColor = Color.Yellow;
                    Thanhtien = Thanhtien + Gia / 4;
                }
                else
                {
                    b.BackColor = Color.Yellow;
                    Thanhtien = Thanhtien + Gia * 2;
                }
            }
            this.txtThanhTien.Text = Thanhtien.ToString();
            Thanhtien = 0;
            DanhSachChon = new List<Button>();
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (Button b in DanhSachChon)
            {
                b.BackColor = Color.White;
            }
            DanhSachChon = new List<Button>();
            txtThanhTien.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.No)
                return;
            else this.Close();
        }
    }
}
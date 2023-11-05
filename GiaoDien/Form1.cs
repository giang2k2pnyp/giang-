using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lienket;

namespace GiaoDien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thêmThôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Thêm th = new Thêm();
            this.Hide();
            th.Show();*/
            //SinhVienBLL.Instance.Them(textBox1, textBox2, textBox3, textBox4, dataGridView1);
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinhVienBLL.Instance.Hienthi(dataGridView1);
        }

        private void xóaSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            //SinhVienBLL.Instance.Xoa(textBox1, textBox2, textBox3, textBox4, dataGridView1);
        }

        private void sửaThôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            //SinhVienBLL.Instance.Sua(textBox1, textBox2, textBox3, textBox4, dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SinhVienBLL.Instance.Them(textBox1, textBox2, textBox3, textBox4, dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SinhVienBLL.Instance.Sua(textBox1, textBox2, textBox3, textBox4, dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SinhVienBLL.Instance.Xoa(textBox1, textBox2, textBox3, textBox4, dataGridView1);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            SinhVienBLL.Instance.SelectionChange(textBox1, textBox2, textBox3, textBox4, dataGridView1);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ban co chac chan muon thoat", "Canh bao", MessageBoxButtons.YesNo)== DialogResult.Yes)
            this.Close();
        }
    }
}

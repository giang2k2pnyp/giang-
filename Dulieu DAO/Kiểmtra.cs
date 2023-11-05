using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dulieu_DAO
{
    public class Kiểmtra
    {
        public void Kt(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4)
        {
            /*int n;
            DateTime time;
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty || textBox4.Text == string.Empty)
            {
                MessageBox.Show("Error", "Vui lòng nhập đủ dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                if ((!int.TryParse(textBox1.Text, out n) || !int.TryParse(textBox2.Text, out n) || !DateTime.TryParse(textBox3.Text, out time) || !int.TryParse(textBox4.Text, out n)))
                {
                    MessageBox.Show("Error", "Bạn nhập sai kiểu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Error","Dữ liệu nhập vào bị trùng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            */
            int n1, n2, n4;
            //string time;
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(textBox1.Text, out n1) || !int.TryParse(textBox2.Text, out n2) || !int.TryParse(textBox4.Text, out n4))
            {
                MessageBox.Show("Bạn đã nhập sai kiểu dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Dữ liệu nhập vào bị trùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void xoa(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }
    }
}

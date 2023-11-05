using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dulieu_DAO;

namespace Lienket
{
    public class SinhVienBLL
    {
        private static SinhVienBLL instance;

        public static SinhVienBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new SinhVienBLL();
                return instance;
            }
        }

        public SinhVienBLL()
        {

        }
        public void Hienthi(DataGridView data)
        {
           SinhVienDAO.Instance.Hienthi(data);
        }

        public void Them(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4, DataGridView dataGridView) 
        {
            SinhVienDAO.Instance.Them(textBox1, textBox2, textBox3, textBox4, dataGridView);
        }

        public void Xoa(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4, DataGridView dataGridView)
        {
            SinhVienDAO.Instance.Xoa(textBox1, textBox2, textBox3, textBox4, dataGridView);
        }

        public void Sua(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4, DataGridView dataGridView)
        {
            SinhVienDAO.Instance.Sua(textBox1, textBox2, textBox3, textBox4, dataGridView);
        }

        public void SelectionChange(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4, DataGridView dataGridView)
        {
            SinhVienDAO.Instance.SelectionChange(textBox1, textBox2, textBox3, textBox4, dataGridView);
        }
    }
}

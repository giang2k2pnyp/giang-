using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model_DTO;

namespace Dulieu_DAO
{
    public class SinhVienDAO : Kiểmtra
    {
        private static SinhVienDAO instance;

        public static SinhVienDAO Instance 
        {
            get
            {
                if (instance == null)
                    instance = new SinhVienDAO();
                return instance;
            }
        }

        

        public SinhVienDAO()
        {

        }

        private string newMasv;
        
        public string NewMasv { get => newMasv; set => newMasv = value; }

        public void Hienthi(DataGridView dataGridView)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=giang\\sqlexpress;Initial Catalog=\"kiemtra dotnet\";Integrated Security=True");
                    con.Open();
                    SqlDataAdapter adam = new SqlDataAdapter("Select * from SinhVien", con);
                    DataTable tb = new DataTable();
                    adam.Fill(tb);
                    dataGridView.DataSource = tb;
            }
            catch (Exception)
            {
                MessageBox.Show("Da co loi xay ra hichic!!!");
            }
        }
        
        public void Them(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4, DataGridView dataGridView) 
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=giang\\sqlexpress;Initial Catalog=\"kiemtra dotnet\";Integrated Security=True");
                    con.Open();
                    SqlCommand cmt = new SqlCommand();
                    cmt.Connection = con;
                    cmt.CommandText = string.Format("Insert into SinhVien values('{0}','{1}','{2}','{3}')", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                    cmt.ExecuteNonQuery();
                    MessageBox.Show("Them du lieu thanh cong");
                    Hienthi(dataGridView);
                    xoa(textBox1, textBox2, textBox3, textBox4);
            }
            catch (Exception)
            {
                Kt(textBox1, textBox2, textBox3, textBox4);
            }
        }

        public void Xoa(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4, DataGridView dataGridView)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=giang\\sqlexpress;Initial Catalog=\"kiemtra dotnet\";Integrated Security=True");
                    con.Open();
                    SqlCommand cmt = new SqlCommand();
                    cmt.Connection = con;
                    cmt.CommandText = string.Format("Delete from SinhVien where Masv ='{0}'", textBox1.Text);
                    cmt.ExecuteNonQuery();
                    MessageBox.Show("Xoa du lieu thanh cong");
                    Hienthi(dataGridView);
                    xoa(textBox1, textBox2, textBox3, textBox4);
            }
            catch (Exception)
            {
                //MessageBox.Show("xoa ok");
                Kt(textBox1, textBox2, textBox3, textBox4);
            }
        }
        public void Sua(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4, DataGridView dataGridView)
        {
            //try
            //{
                SqlConnection con = new SqlConnection("Data Source=giang\\sqlexpress;Initial Catalog=\"kiemtra dotnet\";Integrated Security=True");
                {
                    con.Open();
                    SqlCommand cmt = new SqlCommand();
                    cmt.Connection = con;
                    int test = Convert.ToInt32(newMasv);
                    cmt.CommandText = string.Format("Update SinhVien set Masv = '{0}', Tensv = '{1}', Ngaysinh = '{2}', Hokhau = '{3}' where Masv = {4}", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, newMasv);
                    cmt.ExecuteNonQuery();
                    MessageBox.Show("Cap nhat du lieu thanh cong");
                    Hienthi(dataGridView);
                    xoa(textBox1, textBox2, textBox3, textBox4);
                }
            //}
            //catch (Exception)
            //{
                //Kt(textBox1, textBox2, textBox3, textBox4);
            //}
        }

        public void BatloinewMasv(DataGridView dataGridView)
        {
            try
            {
                this.NewMasv = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch (Exception)
            {
            }
        }
        
        public void SelectionChange(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4, DataGridView dataGridView)
        {
            try
            {
                textBox1.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                textBox4.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                BatloinewMasv(dataGridView);
            }
            catch (Exception)
            {
            }
        }
    }
}

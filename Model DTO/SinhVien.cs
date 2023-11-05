using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_DTO
{
    public class SinhVien
    {
        private string masv;
        private string tensv;
        private string ngaysinh;
        private string hokhau;

        public string Masv { get => masv; set => masv = value; }
        public string Tensv { get => tensv; set => tensv = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Hokhau { get => hokhau; set => hokhau = value; }

        public SinhVien(string Masv, string Tensv, string Ngaysinh, string Hokhau) 
        { 
            this.masv = Masv;
            this.tensv = Tensv;
            this.ngaysinh = Ngaysinh;
            this.hokhau = Hokhau;
        }

        public SinhVien()
        {
        }
    }
}

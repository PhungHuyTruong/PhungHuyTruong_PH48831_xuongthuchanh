using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhungHuyTruong_PH48831_xuongthuchanh
{
    internal class SinhVien
    {
        string maSinhVien;
        string ten;
        int namSinh;
        double diem;
        public SinhVien()
        {
                
        }

        public SinhVien(string maSinhVien, string ten, int namSinh, double diem)
        {
            this.maSinhVien = maSinhVien;
            this.ten = ten;
            this.namSinh = namSinh;
            this.diem = diem;
        }

        public string MaSinhVien { get => maSinhVien; set => maSinhVien = value; }
        public string Ten { get => ten; set => ten = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public double Diem { get => diem; set => diem = value; }

        public void InThongTin()
        {
            Console.WriteLine($"Ma sinh vien:{maSinhVien}, Ten: {ten}, Nam sinh: {namSinh}, Diem:{diem}");
        }
    }
}

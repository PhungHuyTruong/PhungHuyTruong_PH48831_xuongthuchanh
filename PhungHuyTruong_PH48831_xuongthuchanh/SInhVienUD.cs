using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhungHuyTruong_PH48831_xuongthuchanh
{
    internal class SInhVienUD : SinhVien
    {
        int kiHoc = 2024;
        public int KiHoc { get => kiHoc; set => kiHoc = value; }
        public SInhVienUD()
        {

        }
        public void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine("Ki hoc la: " + kiHoc);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhungHuyTruong_PH48831_xuongthuchanh
{
    internal class SinhVienService
    {
        List<SinhVien> list = new List<SinhVien>();
        public SinhVienService()
        {
            list = new List<SinhVien>();
        }
        public void NhapDS()
        {
            Console.WriteLine("Ban muon nhap bao nhieu; ");
            int count = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < count; i++)
            {
                SinhVien sv = new SinhVien();
                Console.WriteLine("Nhap vao ma sinh vien: ");
                sv.MaSinhVien = Console.ReadLine();
                Console.WriteLine("Nhap vao ten: ");
                sv.Ten = Console.ReadLine();
                Console.WriteLine("Nhap vao nam sinh: ");
                sv.NamSinh = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhap vao diem: ");
                sv.Diem = Convert.ToDouble(Console.ReadLine());
                list.Add(sv);
            }
            Console.WriteLine("Ban co muon nhap tiep khong. Neu co go phim 'y',con lai la khong");
            string chon = Console.ReadLine();
            if(chon == "y") NhapDS();
        }
        public void XuatDS()
        {
            if(list.Count == 0)
            {
                Console.WriteLine("Ban chua nhap danh sach, hay nhap danh sach");
                NhapDS();
                XuatDS();
            }
            Console.WriteLine("Danh sach la: ");
            foreach(var item in list)
            {
                item.InThongTin();
            }
        }
        public void SVveviphappybee()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Ban chua nhap danh sach, hay nhap danh sach");
                NhapDS();
                XuatDS();
            }
            Console.WriteLine("Danh sach la: ");
            foreach (var item in list)
            {
                if(item.Diem>=8) item.InThongTin();
            }
        }

    }
}

namespace PhungHuyTruong_PH48831_xuongthuchanh
{
    internal class Program
    {
        public static string Menu()
        {
            Console.WriteLine("1.Nhap danh sach");
            Console.WriteLine("2.Xuat danh sach");
            Console.WriteLine("3.Danh sach sinh vien duoc tang ve vip HB");
            Console.WriteLine("4.Xoa sinh vien khong duoc tham gia");
            Console.WriteLine("5.Ke thua");
            Console.WriteLine("0.Thoat");
            Console.WriteLine("Hay chon tu 0-5: ");
            string chon = Console.ReadLine();
            return chon;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            SinhVienService svs = new SinhVienService();
            while (true)
            {
                switch (Menu())
                {
                    case "1":
                        svs.NhapDS();
                        break;
                    case "2":
                        svs.XuatDS();
                        break;
                    case "3":
                        svs.SVveviphappybee();
                        break;
                    case "4":
                        Console.WriteLine("Chua co gi");
                        break;
                    case "5":
                        SInhVienUD svud = new SInhVienUD();
                        svud.MaSinhVien = "ph48831";
                        svud.Ten = "Phung Huy Truong";
                        svud.NamSinh = 2005;
                        svud.Diem = 10;
                        svud.InThongTin();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default: Console.WriteLine("Ban da nhap sai xin nhap lai tu 0-5");
                        break;
                }
            }
        }
    }
}
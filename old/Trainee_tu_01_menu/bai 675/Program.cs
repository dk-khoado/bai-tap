using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_675
{
    struct LUANVAN
    {
        public string maLuanvan;
        public string tenLuanvan;
        public string hoTensinhVien;
        public string hoTengiaoVien;
        public Int16 nam;
    }
    class Program
    {
        static int n = 3;
        static LUANVAN[] LuanVan = new LUANVAN[n];       
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            Console.Title= "Quản Lý Luận Văn Của Sinh Viên";
            NhapDuLieu();
            HienThi();
            HienThiLuanGanNhat();
            Console.ReadKey();
        }
        static void NhapDuLieu()
        {
            Console.Clear();
            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.Write("Nhâp Mã Luận Văn:");
                    LuanVan[i].maLuanvan = Console.ReadLine();
                    if(LuanVan[i].maLuanvan.Length >10)
                        Console.WriteLine("Tối đa 10 ký tự");
                } while (LuanVan[i].maLuanvan.Length >10);
                do
                {
                    Console.Write("Nhập Tên Luận Văn: ");
                    LuanVan[i].tenLuanvan = Console.ReadLine();
                    if (LuanVan[i].tenLuanvan.Length > 100)
                        Console.WriteLine("Tối đa 100 ký tự");
                } while (LuanVan[i].tenLuanvan.Length >100);
                do
                {
                    Console.Write("Nhâp Tên Sinh Viên: ");
                    LuanVan[i].hoTensinhVien = Console.ReadLine();
                    if (LuanVan[i].hoTensinhVien.Length > 30)
                        Console.WriteLine("Tối đa 30 ký tự");
                } while (LuanVan[i].hoTensinhVien.Length > 30);
                do
                {
                    Console.Write("Nhâp Tên Giáo Viên: ");
                    LuanVan[i].hoTengiaoVien = Console.ReadLine();
                    if (LuanVan[i].hoTengiaoVien.Length > 30)
                        Console.WriteLine("Tối đa 30 ký tự");
                } while (LuanVan[i].hoTengiaoVien.Length > 30);
                Console.Write("Nhập Năm: ");
                LuanVan[i].nam = Int16.Parse(Console.ReadLine());
            }
        }
        static void HienThi()
        {
            Console.Clear();
            Console.WriteLine("|Mã Luận Văn |Tên Luận Văn \t\t\t\t\t\t\t\t\t\t\t\t   |Họ Tên Thí Sinh               |Họ Tên Giáo Viên              |Năm |");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("|{0,-11} |{1,-100} |{2,-30}|{3,-30}|{4,-4}|",LuanVan[i].maLuanvan, LuanVan[i].tenLuanvan, LuanVan[i].hoTensinhVien, LuanVan[i].hoTengiaoVien, LuanVan[i].nam);
            }
        }
        static void HienThiLuanGanNhat()
        {
            int max = LuanVan[0].nam;
            int postion=0;
            for (int i = 0; i < n; i++)
            {
                if(max < LuanVan[i].nam)
                {
                    max = LuanVan[i].nam;
                    postion = i;
                }
            }
            Console.WriteLine("Luận Văn Gần Nhất......");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("|Mã Luận Văn |Tên Luận Văn \t\t\t\t\t\t\t\t\t\t\t\t   |Họ Tên Thí Sinh               |Họ Tên Giáo Viên              |Năm |");
            Console.WriteLine("|{0,-11} |{1,-100} |{2,-30}|{3,-30}|{4,-4}|",LuanVan[postion].maLuanvan, LuanVan[postion].tenLuanvan, LuanVan[postion].hoTensinhVien, LuanVan[postion].hoTengiaoVien, LuanVan[postion].nam);
        }
    }
}

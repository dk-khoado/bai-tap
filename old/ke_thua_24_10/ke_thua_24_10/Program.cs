using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ke_thua_24_10
{
    public class Student
    {
        public static string name = "khoa";
        public static int tuoi = 19;
        public static string lop = "12a4";
        int diem = 0;
        public int Diem//thuộc tính
        {
            get
            {
                return diem;
            }
            set
            {
                diem = value;
            }
        }
        public virtual string hocLuc()
        {
            return "Học Lực: ";
        }
    }
    public class HocSinh1 : Student
    {
        static string hocluc;
        public void ThongTin()
        {
            int diem = Diem;
            Console.Write("Nhap ten hoc sinh: ");
            name = Console.ReadLine();
            Console.Write("nhap tuoi: ");
            tuoi = int.Parse(Console.ReadLine());
            Console.Write("nhap lop: ");
            lop = Console.ReadLine();
            Console.Write("Nhap hoc luc: ");
            hocluc = Console.ReadLine();
            Console.Write("nhap diem: ");
            Diem = int.Parse(Console.ReadLine());
        }
        public void HienThiThongTin()
        {
            Console.WriteLine("Ten: " + name);
            Console.WriteLine("tuoi: " + tuoi);
            Console.WriteLine("lop: " + lop);
            Console.WriteLine("Diem: " + Diem);
            Console.WriteLine(hocLuc());
        }
        public override string hocLuc()
        {
            return base.hocLuc() + hocluc;
        }
    }
    class ChaoMung
    {
        public ChaoMung()
        {
            Console.WriteLine("Chào mừng bạn đến vơi chương trình");
        }
        ~ChaoMung()
        {
            Console.WriteLine("đã xóa cần trát sần");
            Console.ReadKey();
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {            
            Console.OutputEncoding = Encoding.UTF8;
            ChaoMung chao = new ChaoMung();
            HocSinh1 HS1 = new HocSinh1();
            HS1.ThongTin();
            HS1.HienThiThongTin();                        
        }
    }
}

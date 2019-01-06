using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UCLN
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a, b;
            Console.Write("Nhap so A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so B: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("UCLN cua {0} va {1} la {2}",a,b,UCLN(a,b));
            Console.ReadKey();
        }
        static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a == 0 || b == 0)
                return a + b;
            else
            {
                while (a != b)
                {
                    if (a > b)
                    {
                        a = a - b;
                    }
                    if (a < b)
                    {
                        b = b - a;
                    }
                }
                return a;
            }
        }
    }
}

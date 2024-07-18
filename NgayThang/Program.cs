using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgayThang
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x, y;
            int daysInMonth; 

            Console.WriteLine(" Nhap nam : "); 
            x = int.Parse(Console.ReadLine());
            Console.WriteLine(" Nhap vao thang (1-12) : "); 
            y = int.Parse(Console.ReadLine());

            if (y<1 || y>12)
            {
                Console.WriteLine(" Khong hop le ! "); 
            }
            else
            {
                daysInMonth = DateTime.DaysInMonth(x, y);

                Console.WriteLine($" So ngay trong thang {y} / {x} la : {daysInMonth}"); 
            }

            Console.ReadLine();

        }
    }
}

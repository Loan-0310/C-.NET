using System;

namespace PTB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chuong trinh giai phuong trinh bac 2");

            double a, b, c, delta, x1, x2;
            Console.Write("Nhap a: ");
            a = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Phuong trinh khong phai la phuong trinh bac 2 (a phai khac 0)");
                Console.Read();
                return; 
            }
           
            Console.Write("Nhap b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap c: ");
            c = Convert.ToDouble(Console.ReadLine());

            delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else if (delta == 0)
            {
                Console.WriteLine("Phuong trinh co nghiem kep");
                x1 = -b / (2 * a);
                Console.WriteLine("x1 = x2 = " + x1);
            }
            else
            {
                Console.WriteLine("Phuong trinh co 2 nghiem");
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }

            Console.Read();
        }
    }
}

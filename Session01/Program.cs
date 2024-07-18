using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bai 1"); 
            Console.WriteLine();
            Console.WriteLine("Hello World");
            Console.WriteLine("My name is Lia");
            Console.WriteLine("I'm from HaNoi city");
            Console.WriteLine("Welcome VietNam");
            Console.WriteLine();


            Console.WriteLine("Bai 2");
            Console.WriteLine();
            int id = 1;
            string name = " Hoang Huyen Anh ";
            String gender = " Nu ";
            byte age = 20;
            const float luong = 50000000;

            Console.WriteLine(" ID     : " +id); 
            Console.WriteLine(" Name   : " +name); 
            Console.WriteLine(" Gender : " +gender); 
            Console.WriteLine(" Age    : " +age); 
            Console.WriteLine(" Luong  : " +luong);
            Console.WriteLine();


            Console.WriteLine("Bai 3");
            Console.WriteLine();
            String id1, name1; 
            double mark1, mark2, mark3, diemTB;
            DateTime birthday;

            Console.WriteLine("Nhap ID : "); 
            id1 = Console.ReadLine();
            Console.WriteLine("Nhap ten : ");
            name1 = Console.ReadLine();
            Console.WriteLine("Nhap ngay thang nam sinh : "); 
            birthday = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(" Mark 1 = "); 
            mark1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Mark 2 = "); 
            mark2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Mark 3 = "); 
            mark3 = Convert.ToDouble(Console.ReadLine());

            diemTB = (mark1 + mark2 + mark3) / 3;

            Console.WriteLine(" Chao ban hoc sinh " + name1);
            Console.WriteLine("Diem trung binh cua ban la : " + diemTB);

            Console.ReadLine();




        }
    }
}

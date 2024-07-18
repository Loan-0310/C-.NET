using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Nhap thông tin : ");

            String id, name, address;
            DateTime birthday;
            Double salary, bonus, totalSalary;

            Console.WriteLine(" Nhap ID : "); 
            id = Console.ReadLine();
            Console.WriteLine(" Nhap Ho Và Ten : ");
            name = Console.ReadLine();
            Console.WriteLine(" Nhap Đia Chi : ");
            address = Console.ReadLine();
            Console.WriteLine(" Nhap ngay thang nam sinh : ");
            birthday = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(" Nhap Luong : ");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Nhap He So : "); 
            bonus = Convert.ToDouble(Console.ReadLine());

            totalSalary = salary + bonus;

            Console.WriteLine(" ID Employee : " + id);
            Console.WriteLine(" Name : " +name); 
            Console.WriteLine(" Address : " +address); 
            Console.WriteLine(" Birthday: " +birthday); 
            Console.WriteLine(" Salary : " +salary); 
            Console.WriteLine(" Bonus : " +bonus);
            Console.WriteLine(" Total Salary : " + totalSalary);
            Console.Read(); 
        }
    }
}

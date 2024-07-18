using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testResetEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            String id, name, address;
            DateTime birthday;
            Double salary, bonus, totalSalary;

            Console.WriteLine(" Thông Tin Nhân Viên ");
            Console.WriteLine(" ID : ");
            id = Console.ReadLine();
            Console.WriteLine(" Name : ");
            name = Console.ReadLine();
            Console.WriteLine(" Address : ");
            address = Console.ReadLine();
            Console.WriteLine(" Birthday : ");
            birthday = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(" Salary : ");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Bonus : ");
            bonus = Convert.ToDouble(Console.ReadLine());
            totalSalary = salary + bonus;

            Console.WriteLine(" Thông Tin Nhận Được Như Sau : ");
            Console.WriteLine($" ID : {id} ");
            Console.WriteLine($" Name : {name}  ");  
            Console.WriteLine($" Address : {address}  ");  
            Console.WriteLine($" Birthday : {birthday}  ");  
            Console.WriteLine($" Salary :  {salary:C} ");  
            Console.WriteLine($" Bonus : {bonus:C}  ");  
            Console.WriteLine($" Total Salary : {totalSalary:C}  ");  

            Console.ReadLine();
        }
    }
}

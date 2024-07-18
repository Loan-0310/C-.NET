using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenAm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine(" Nhap ky tu : ");

            ch = (char)Console.Read();

            switch (ch)
            {

                case 'u':
                case 'e':
                case 'o':
                case 'a':
                case 'i':
                    Console.WriteLine($" {ch} Là Nguyên Âm");
                    break;
                default:
                    Console.WriteLine($" {ch} Là Phụ Âm");
                    break;

            }
            Console.ReadLine();
        }
    }
}

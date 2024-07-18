using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { " Thang ", " Long ", " Hoa ", " Dao " };
            Console.Write(" Danh sach sinh vien : "); 
            foreach ( var n in names )
            {
                Console.Write(n);       
            }
            Console.Read();
        }
    }
}

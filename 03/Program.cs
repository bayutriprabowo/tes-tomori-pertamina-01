using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.Write("Masukan jumlah bilangan fibonacci = ");
            int jumlah = Convert.ToInt32(Console.ReadLine());
            Console.Write(0 + " ");

            int x = 0, y = 1, z = 1;

            for (int i = 0; i < jumlah; i++)
            {
                Console.Write(z + " ");
                z = x + y;
                x = y;
                y = z;
            }
            Console.Read();

        }
    }
}
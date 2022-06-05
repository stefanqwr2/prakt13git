using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            while (true)
            {
                Console.WriteLine("1-Ввод А, 2-Ввод В, 3-Сложение, 4-Вычитание, 5-Умножение, 6-Деление");
                int c = int.Parse(Console.ReadLine());


            if(c==3)
            {
                Console.WriteLine(a+b);
            }







                if (c == 4)
                {
                    Console.WriteLine(a - b);
                }


            if(c == 6)
            {
                Console.WriteLine(a/b);
            }













            if(c == 5)
            {
                Console.WriteLine(a * b);
            }































            if(c == 1)
            {
                a = int.Parse(Console.ReadLine());
            }











            if(c == 2)
            {
                b = int.Parse(Console.ReadLine());
            }









                Console.ReadKey();

            }
          


        }
    }
}

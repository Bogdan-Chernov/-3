using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetClass;

namespace Пр3
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassSTO func = new ClassSTO();
            func.ggg();
            Console.WriteLine("1 - Сложение");
            Console.WriteLine("2 - Вычитание");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(" ");
            
            if (g <= 1)

            {
                Console.WriteLine($"Результат сложения: {func.addition()}");
                Console.ReadLine();
            }

            else if (g >= 2)
            {
                Console.WriteLine($"Результат вычитание: {func.Subtraction()}");
                Console.ReadLine();
            }
          
            }
        }
    }


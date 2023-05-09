using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepenDvoiki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            int basicNumber = 2;
            int degree = 0;
            int result = 1;
            int minNumberValue = 2;
            int maxNumberValue = 512;
            Random random = new Random();
            int finalNumber = random.Next(minNumberValue, maxNumberValue + 1);

            while (result <= finalNumber) 
            {
                degree++;
                result *= basicNumber;
            }  

            Console.WriteLine($"Случайное число: {finalNumber}");
            Console.WriteLine($"Нужная степень числа {basicNumber} - {degree}");
            Console.WriteLine($"Число {basicNumber} в найденной степени - {result}");
            Console.ReadLine();
        }
    }
}

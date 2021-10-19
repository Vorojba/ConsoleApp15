using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            double x ;//присваивание переменной
            Console.Write("Введите x =");
            x = Convert.ToDouble(Console.ReadLine());//конвертирование
            if (x < -2)//условие выполняется
                Console.WriteLine("y =" + 2 * Math.Log10(x + 2));//вывод на экран
            if ((-2 <= x) && (x < 5))//условие выполняется
                Console.WriteLine("y =" +Math.Sqrt(x + 2 * Math.Sqrt(x + 3)));//вывод на экран
            if (x >= 5)//условие выполняется
                Console.WriteLine("y =" +(3 * Math.Pow(x, 2) - 5 * x - 3));//вывод на экран
            Console.ReadKey();






        }
    }
}

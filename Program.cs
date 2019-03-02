using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snova_Mnogotochie
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Во введенной строке заменить первый символ "точка" (.) многоточием (...).

            Начальные данные: строка текста.
            Вывод результата: строка с заменой.

            Полезные ссылки: Метод Substring(),     Метод IndexOf()*/

            string line = Console.ReadLine();
            if (line.Contains("."))
                Console.WriteLine(line.Substring(0, line.IndexOf('.')) + ".." + line.Substring(line.IndexOf('.')));
            else
                Console.WriteLine(line);
        }
    }
}

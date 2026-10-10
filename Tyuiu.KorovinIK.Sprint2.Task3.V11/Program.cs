using System.Security.Cryptography;
using Tyuiu.KorovinIK.Sprint2.Task3.V11.Lib;
namespace Tyuiu.KorovinIK.Sprint2.Task3.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Коровин И. К. | ИСНТб-26-1";

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* Спринт #2                                                               c *");

            Console.WriteLine("* Тема: Вложенные операторы if - else                        *");

            Console.WriteLine("* Задание #3                                                        *");

            Console.WriteLine("* Вариант #11                                                            *");

            Console.WriteLine("* Выполнил: Коровин Илья Константинович | ИСТНб-26-1                       *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                  *");

            Console.WriteLine("Написать программу, которая вычисляет требуемое значение функции Y с использованием вложенных оператор if-else, где пользователь вводит значение переменной X с клавиатуры.   *");

            Console.WriteLine("*                                                                          *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");

            Console.WriteLine("*****************************************************************************");



            Console.WriteLine("Введите значение пременой X  ");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);

            




            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Значение функции" + res);



            Console.ReadLine();
        }
    }
}

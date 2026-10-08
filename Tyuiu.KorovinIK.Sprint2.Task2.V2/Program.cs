using Tyuiu.KorovinIK.Sprint2.Task2.V2.Lib;
namespace Tyuiu.KorovinIK.Sprint2.Task2.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Коровин И. К. | ИСНТб-26-1";

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* Спринт #2                                                               c *");

            Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                         *");

            Console.WriteLine("* Задание #2                                                        *");

            Console.WriteLine("* Вариант #2                                                            *");

            Console.WriteLine("* Выполнил: Коровин Илья Константинович | ИСТНб-26-1                       *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                  *");

            Console.WriteLine("Написать программу на, которая запрашивает целые значения с клавиатуры и вычисляет находится ли точка с координатами X,Y в заштрихованной области.\r\n\r\n  *");

            Console.WriteLine("*                                                                          *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");

            Console.WriteLine("*****************************************************************************");



            Console.WriteLine("Введите значение пременой X  ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение пременой Y  ");
            int y = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            bool res =ds.CheckDotInShadedArea(x, y);




            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");

            Console.WriteLine("*****************************************************************************");

            if (res)
            {
                Console.WriteLine("Точка находиться в заштриховонной области");
                
            }
            else
            {
                Console.WriteLine("Точка не находиться в заштриховонной области");
            }




            Console.ReadLine();
        }
    }
}


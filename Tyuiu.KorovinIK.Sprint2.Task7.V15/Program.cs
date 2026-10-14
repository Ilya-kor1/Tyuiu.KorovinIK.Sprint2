using Tyuiu.KorovinIK.Sprint2.Task7.V15.Lib;
namespace Tyuiu.KorovinIK.Sprint2.Task7.V15
{
    class Program 
    {
        static void Main(string[] args)
        {
            
            Console.Title = "Спринт #2 | Выполнил: Коровин И. К. | ИСТНб-26-1";

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* Спринт #2                                                               c *");

            Console.WriteLine("* Тема:Получение результата из switch                 *");

            Console.WriteLine("* Задание #7                                                        *");

            Console.WriteLine("* Вариант #15                                                          *");

            Console.WriteLine("* Выполнил: Коровин Илья Константинович | ИСТНб-26-1                       *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                  *");

            Console.WriteLine("Написать программу на C#, которая запрашивает исходные данные (вещественные значения) и вычисляет, находится ли точка с координатами X,Y в заштрихованной области.   *");

            Console.WriteLine("*                                                                          *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");

            Console.WriteLine("*****************************************************************************");

            

            Console.Write("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение переменной Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();

            bool res = ds.CheckDotInShadedArea(x, y);






            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");

            Console.WriteLine("*****************************************************************************");

            if (res)
            {
                Console.WriteLine("Точка находиться в заштриховоной области ");
            }
            else
            {
                Console.WriteLine("Точка не находиться в заштриховоной области ");
            }


            Console.ReadKey();
        }
    }
}

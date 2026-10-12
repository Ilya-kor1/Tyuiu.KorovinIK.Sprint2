using Tyuiu.KorovinIK.Sprint2.Task5.V15.Lib;
namespace Tyuiu.KorovinIK.Sprint2.Task5.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Коровин И. К. | ИСНТб-26-1";

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* Спринт #2                                                               c *");

            Console.WriteLine("* Тема:Опертаор switch                 *");

            Console.WriteLine("* Задание #5                                                        *");

            Console.WriteLine("* Вариант #15                                                            *");

            Console.WriteLine("* Выполнил: Коровин Илья Константинович | ИСТНб-26-1                       *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                  *");

            Console.WriteLine("Дано целое число k (1 <= k <= 365). Определить, каким днем недели (понедельником, вторником, …, субботой или воскресеньем) является k-й день не високосного года, в котором 1 января понедельник.   *");

            Console.WriteLine("*                                                                          *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");

            Console.WriteLine("*****************************************************************************");



            Console.Write("Введите значение переменной k: ");
            int k = Convert.ToInt32(Console.ReadLine());

            string res = ds.FindDayName(k);

            if (k < 1 || k > 365)
            {
                res = "Введено не верное значение ";
            }
            else
            {
                res = "Этот день недели - " + ds.FindDayName(k);
            }






            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine(res);



            Console.ReadLine();
        }
    }
}

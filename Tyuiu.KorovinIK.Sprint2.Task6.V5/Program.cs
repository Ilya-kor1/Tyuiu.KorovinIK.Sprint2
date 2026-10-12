using Tyuiu.KorovinIK.Sprint2.Task6.V5.Lib;
namespace Tyuiu.KorovinIK.Sprint2.Task6.V5 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Коровин И. К. | ИСНТб-26-1";

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* Спринт #2                                                               c *");

            Console.WriteLine("* Тема:Получение результата из switch                 *");

            Console.WriteLine("* Задание #6                                                        *");

            Console.WriteLine("* Вариант #5                                                           *");

            Console.WriteLine("* Выполнил: Коровин Илья Константинович | ИСТНб-26-1                       *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                  *");

            Console.WriteLine("Игральным картам условно присвоены следующие порядковые номера в зависимости от их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14. Порядковые номера остальных карт соответствуют их названиям («шестерка», «девятка» и т. п.). По заданному номеру карты k (6 <=k <= 14) определить достоинство соответствующей карты.   *");

            Console.WriteLine("*                                                                          *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");

            Console.WriteLine("*****************************************************************************");



            Console.Write("Введите значение переменной k: ");
            int k = Convert.ToInt32(Console.ReadLine());

            string res;

            if (k < 6 || k > 14)
            {
                res = "Нету карты с таким номером ";
            }
            else
            {
                res = "Номер карты - " + ds.FindCardValue(k);
            }






            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine(res);



            Console.ReadLine();
        }
    }
}

using Tyuiu.TomilovAD.Sprint2.Task6.V7.Lib;

namespace Tyuiu.TomilovAD.Sprint2.Task6.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил Томилов А. Д. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Томилов А. Д. | ИСТНб-25-1                                    *");
            Console.WriteLine("***************************************************************************");

            int k;
            int d;

            Console.WriteLine("Введите год:");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите сколько месяцев прошло:");
            d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.FindMonthName(k, d));
            Console.ReadLine();
        }
    }
}
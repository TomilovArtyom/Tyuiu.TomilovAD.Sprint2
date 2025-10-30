using Tyuiu.TomilovAD.Sprint2.Task1.V16.Lib;

namespace Tyuiu.TomilovAD.Sprint1.Task3.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил Томилов А. Д. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #                                                                *");
            Console.WriteLine("* Задание #                                                               *");
            Console.WriteLine("* Вариант #                                                               *");
            Console.WriteLine("* Выполнил: Томилов А. Д. | ИСТНб-25-1                                    *");
            Console.WriteLine("***************************************************************************");

            int a;
            int b;
            int c;
            int d;

            Console.WriteLine("Введите значение A:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение B:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение C:");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение D:");
            d = Convert.ToInt32(Console.ReadLine());

            bool[] res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadLine();
        }
    }
}
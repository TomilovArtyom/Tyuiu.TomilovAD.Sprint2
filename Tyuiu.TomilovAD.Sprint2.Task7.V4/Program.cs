using Tyuiu.TomilovAD.Sprint2.Task7.V4.Lib;

namespace Tyuiu.TomilovAD.Sprint2.Task7.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил Томилов А. Д. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Томилов А. Д. | ИСТНб-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ;                                                                *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные и         *");
            Console.WriteLine("* вычисляет, находится ли точка с координатами X,Y                        *");
            Console.WriteLine("* в заштрихованной области.                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            double x, y;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.CheckDotInShadedArea(x, y));
            Console.ReadLine();
        }
    }
}
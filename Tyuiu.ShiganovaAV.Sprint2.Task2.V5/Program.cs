using Tyuiu.ShiganovaAV.Sprint2.Task2.V5.Lib;
namespace Tyuiu.ShiganovaAV.Sprint2.Task2.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 |Выполнила: Шиганова А.В.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                               *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #5                                                             *");
            Console.WriteLine("* Выполнила: Шиганова Анастасия Владимировна |ПИНб-25-1|                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x=" + x);
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y=" + y);

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
           if (res)
            { Console.WriteLine("Находится в области"); }
           else
                { Console.WriteLine("Не находится в области"); }
                Console.ReadKey();
        }
    }
}


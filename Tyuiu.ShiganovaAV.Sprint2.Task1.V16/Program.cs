using Tyuiu.ShiganovaAV.Sprint2.Task1.V16.Lib;
namespace Tyuiu.ShiganovaAV.Sprint2.Task1.V16
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
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнила: Шиганова Анастасия Владимировна |ПИНб-25-1|                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int a = 145;
            Console.WriteLine("a=" + a);
            int b = 716;
            Console.WriteLine("b=" + b);
            int c = 144;
            Console.WriteLine("c=" + c);
            int d = 137;
            Console.WriteLine("d=" + d);
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b,c,d);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}


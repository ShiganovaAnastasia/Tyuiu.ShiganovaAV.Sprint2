using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShiganovaAV.Sprint2.Task1.V16.Lib
{
    public class DataService : ISprint2Task1V16
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
             res[0] = (a > c) & (b != d);
            res[1] = (a == c + 1) | (d < a);
            res[2] = (b > a) && (c >= d);
            res[3] = (a <= d) ^ (c == b);
             res[4] = (b != c) && !(a < d);
             res[5] = (d >= a) | (c == a);
             return res;
        }
    }
}

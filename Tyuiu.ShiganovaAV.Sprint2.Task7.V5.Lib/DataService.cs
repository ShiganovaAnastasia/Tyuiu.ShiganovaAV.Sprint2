using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShiganovaAV.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (x < -1 || x > 1)
                return false;

            double a = x * x;

            double b = Math.Exp(-Math.Abs(x));

            return y >= a && y <= b;

        }
    }
}

using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShiganovaAV.Sprint2.Task3.V3.Lib
{
    public class DataService : ISprint2Task3V3
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 1)
            {
                double baseValue = (x + 1) / (x - 1);
                y = x * Math.Pow(baseValue, x);
            }
            else if (x == 1)
            {
                y = Math.Pow(x, 4) - Math.Cos(Math.Pow(x, 5)) + 3;
            }
            else if (x == 0)
            {
                double numerator = Math.Pow(x, 4) - Math.Cos(Math.Pow(x, 5)) + 3;
                double denominator = Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12;
                y = numerator / denominator;
            }
            else if (x > -7 && x < 0)
            {
                double innerExpression = 1 + Math.Sqrt(x + 3) / Math.Pow(x, 2);
                y = Math.Pow(innerExpression, x);
            }
            else if (x < -7)
            {
                y = Math.Pow(x, 2) + 10 * x - (1 / x);
            }
            else if (x == -7)
            {
                y = Math.Pow(x, 2) + 10 * x - (1 / x);
            }

            return Math.Round(y, 3);

        }
    }
}

using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShiganovaAV.Sprint2.Task2.V5.Lib
{
    public class DataService : ISprint2Task2V5
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((y == 3 || y == 4 || y == 5) && (x >= 2 && x <= 4))
                return true;
            if ((y == 3 || y == 4 || y == 5) && (x >= 10 && x <= 12))
                return true;
            if (y == 5 && x == 13)
                return true;
            if ((y >= 6 && y <= 8) && (x >= 3 && x <= 7))
                return true;
            if ((y >= 6 && y <= 8) && x == 13)
                return true;
            if ((y == 9 || y == 10) && (x == 5 || x == 7))
                return true;
            if (y == 11 && (x >= 2 && x <= 7))
                return true;
            if (y == 12 && (x >= 5 && x <= 7))
                return true;

            return false;
        }
    }
}

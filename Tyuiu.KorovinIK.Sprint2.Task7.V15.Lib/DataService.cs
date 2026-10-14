using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KorovinIK.Sprint2.Task7.V15.Lib
{
    public class DataService : ISprint2Task7V15
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            double r2 = x * x + y * y;

            return (r2 >= 1) && (r2 <= 4) && (y >= 0);
        }
    }
}

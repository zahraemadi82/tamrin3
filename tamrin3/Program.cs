
    using System;
namespace project
{
    class test
    {
        public static void main()
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double Result = num(x);
            Console.WriteLine(Result);
            double num(double x)
            {
                double Res = Math.Pow(x, 2) - 2 * x + 4;
                return Res;
            }
        }
    }
}
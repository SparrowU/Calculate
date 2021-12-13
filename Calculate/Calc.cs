using System;

namespace Calculate
{
    public class Calc
    {
        public int sum(int a, int b)
        {
            int c = a + b;
            return c;
        }
        public int pow(int a)
        {
            a = a * a;
            return a;
        }
        public double square_root(double b)
        {
            return Math.Sqrt(b);
        }
    }
}

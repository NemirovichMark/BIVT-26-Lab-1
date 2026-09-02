using System.ComponentModel;

namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            if ((a > 0 && b > 0) || (a == 0 && b == 0) || (a < 0 && b < 0))
            {
                answer = true;
            }

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;
            if (d - Math.Truncate(d) != 0)
            {
                answer = true;
            }

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;
            if (b != 0)
            {
                if (a % b == 0)
                {
                    answer = true;
                }

            }
            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;
            double a = Math.Abs(d), b = Math.Abs(f), c = Math.Abs(g);
            if (a >= b && a >= c)
            {
                answer = d;
            }
            if (b >= a && b >= c)
            {
                answer = f;
            }
            if (c >= a && c >= b)
            {
                answer = g;
            }
            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            if (x <= -1)
            {
                answer = 0;
            }
            else if (x > 0)
            {
                answer = 1;
            }
            else
            {
                answer = x + 1;
            }

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            if (Math.Sqrt(squareS) >= 2 * Math.Sqrt(circleS / Math.PI))
            {
                answer = true;
            }

            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            if (Math.Abs(d) < Math.Abs(f))
            {
                if (d > 0)
                {
                    answer = -1;
                }
            }
            else
            {
                if (f > 0)
                {
                    answer = 1;
                }
            }

            return answer;
        }
        public bool Task8(int A, int B, int C)
        {
            bool answer = false;
            int a = A / 2, b = B / 2, c = C / 2, s = a + b + c;
            if (s % 3 == 0)
            {
                if (s / 3 >= 1)
                {
                    answer = true;
                }
            }
            if ((s + 1) % 3 == 0)
            {
                if ((s + 1) / 3 >= 1)
                {
                    answer = true;
                }
            }
                return answer;
        }
    }
}

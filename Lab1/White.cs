namespace Lab1
{
    public class White
    {
        public bool Task1(double d)
        {
            bool answer = false;
            
            if (d > 0.0) {
                answer = true;
            }

            return answer;
        }
        public bool Task2(int n)
        {
            bool answer = false;

            if (n % 2 == 0)
            {
                answer = true;
            }

            return answer;
        }
        public int Task3(int a, int b)
        {
            int answer = 0;

            answer = Math.Max(a, b);

            return answer;
        }
        public double Task4(double d, double f)
        {
            double answer = 0;

            if (Math.Min(Math.Abs(d), Math.Abs(f)) == Math.Abs(d))
            {
                answer = d;
            } else
            {
                answer = f;
            }

                return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            if (Math.Abs(x) > 1)
            {
                answer = 1;
            } else
            {
                answer = x;
            }

                return answer;
        }
        public bool Task6(double x, double y, double r)
        {
            bool answer = false;

            if (Math.Abs(x * x + y * y - r * r) <= Math.Pow(10, -4))
            {
                answer = true;
            }

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = false;

            double s = Math.Pow(n, 2);

            if (s - n > 2 * n && n % 2 == 0)
            {
                answer = true;
            }

            return answer;
        }
        public bool Task8(double L, int T, int M)
        {
            bool answer = false;

            if (L <= 30 && T + M >= 5 && M % 2 == 0)
            {
                answer = true;
            }

            return answer;
        }
    }
}
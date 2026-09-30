namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            answer = Math.Abs(d) >= 1;

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            if((d + f) / 2 > 0)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            answer = (a + b) > (Math.Abs(a) + Math.Abs(b)) / 2;

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            answer = a;
            if (b > answer) answer = b;
            if (c > answer) answer = c;

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            if (Math.Abs(x) > 1)
            {
                answer = 0;
            }
            else 
            {
                answer = x * x - 1;
            }

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            if (y >= 0 && y <= 1 - Math.Abs(x))
            {
                answer = true;
            }

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            if (n < 0)
            {
                answer = false;
            }
            else
            {
                if (n % 2 == 0)
                {
                    answer = false;
                }
            }

            return answer;

        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;   
            int sleep = 180 + ((X + 1) / 2) * Y;
            answer = (X >= 7) && (sleep <= 540) && (sleep >= 420);
            return answer;
        }
    }
}

namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            double d1 = Math.Abs(d);
            if (d1 >= 1)
                answer = true;
            else
                answer = false;

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            double s = d + f;
            double c = (s / 2.0);
            if (c > 0)
                answer = true;
            else
                answer = false;

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            double s = a + b;
            double c = ((Math.Abs(a) + Math.Abs(b)) / 2.0);
            if (s > c)
                answer = true;
            else
            {
                answer = false;
            }

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            double m = a;
            if (b > m)
                m = b;
            if (c > m)
                m = c;
            answer = (int)m;

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            if (Math.Abs(x) > 1)
                answer = 0;
            else
                answer = x * x - 1;

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            if (y >= 0)
            {
                if (x < 0)
                {
                    if (y <= 1 + x)

                        answer = true;
                    else
                        answer = false;
                }
                else
                {
                    if (y <= 1 - x)
                        answer = true;
                    else
                        answer = false;
                }
            }
            else
                answer = false;

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            if (n < 0)
                answer = false;
            else
               if (n % 2 == 0)
                answer = false;

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            if (X >= 7)
            {
                int t = (X + 1) / 2;
                int s = t * Y;

                if (s >= 240 && s <= 360)
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }
            else
            {
                answer = false;
            }


            return answer;
        }
    }
}

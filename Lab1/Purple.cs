namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            if (Math.Sign(a) == Math.Sign(b) && Math.Sign(b) == Math.Sign(c))
            {
                answer = true;
            }

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;
            a = Math.Abs(a);
            b = Math.Abs(b);
            int mi = Math.Min(a, b);
            int ma = Math.Max(a, b);
            if ((mi != 0 && ma % mi == 0) || mi % ma == 0)
            {
                answer = true;
            }

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;
            int mi = Math.Min(a, b);
            int ma = Math.Max(a, b);
            if (Math.Pow(mi, 2) == ma || Math.Pow(mi, 3) == ma)
            {
                answer = true;
            }

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = f * f - 4 * d * g;

            

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            if (x <= -1)
            {
                answer = 1;
            }
            else
            {
                if (x <= 1)
                {
                    answer = -x;
                }
                else
                {
                    answer = -1;
                }
            }

            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            if (Math.Sqrt(squareS * 2) <= 2 * Math.Sqrt(circleS / Math.PI))
            {
                answer = true;
            }

            return answer;
        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;

            if (s)
            {
                if (t)
                {
                    answer = 6;
                }
                else
                {
                    if (f)
                    {
                        answer = 10;
                    }
                    else
                    {
                        answer = 2;
                    }
                }
            }
            else
            {
                if (t)
                {
                    answer = 3;
                }
                else
                {
                    if (f)
                    {
                        answer = 5;
                    }
                    else
                    {
                        answer = 1;
                    }
                }
            }

            return answer;
        }
        public bool Task8(int year, int pupils, int salary)
        {
            bool answer = false;
            const int bank = 10000;

            if (!DateTime.IsLeapYear(year) && (pupils + 6) / 7 * salary + 5 * pupils <= bank)
            {
                answer = true;
            }

            return answer;
        }
    }
}
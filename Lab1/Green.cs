namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            double mdl = Math.Abs(d);
            if (mdl >= 1)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }

            // end

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            double srd = (d + f) / 2.0;
            if (srd > 0)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
                // end
            
                return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            double am = Math.Abs(a);
            double bm = Math.Abs(b);
            double sm = a + b;
            double mod = (am + bm) / 2.0;
            if (sm > mod)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }

            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            int ans = Math.Max(a, Math.Max(b, c));
            if (ans > answer)
            {
                answer = ans;
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            double x1 = Math.Abs(x);
            if (x1 > 1)
            {
                answer = 0;
            }
            else
            {
                answer = x * x - 1;
            }
                // end

                return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            if (y >= 0)
            {
                if ((x < 0) && (y <= x + 1))
                {
                    answer = true;
                }
                if ((x >= 0) && (y <= 1 - x))
                {
                    answer = true;
                }
            }
                // end

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
                if (n%2==0)
                {
                    answer = false;
                }
            }

                // end

                return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;
            double t = (X + 1) / 2;
            double ost = 14 - 7;
            if (X >= ost)
            {
                double ol = t*Y;

                if ((ol >= 240) && (ol <= 360))
                {
                    answer = (true);
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
                // end

                return answer;
        }
    }
}

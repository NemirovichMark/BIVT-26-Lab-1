namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;
            double ab = Math.Abs(d);
            answer = (ab >= 1);

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            double su;
            su = d + f;
            double sr;
            sr = su / 2;
            answer = (sr > 0);

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            double summ = a + b;
            double sr = (Math.Abs(a) + Math.Abs(b)) / 2;

            answer = (summ > sr);

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            if (a > b && a > c)
            { answer = a; }

            else if (b > a && b > c)
            { answer = b; }

            else
            { answer = c; }

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            if (Math.Abs(x) > 1)
                { answer = 0; }
            else
            { answer = x * x - 1; }

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;
            double yy = 0;

            if (x < 0)
            { yy = 1 + x; }
            else
            { yy = 1 - x; }

            if (y >= 0 && y <= yy)
                answer = true;

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            if (n < 0)
            { answer = false; }
            else
            { if (n % 2 == 0) 
                answer = false;
            }

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            bool wake = false;
            bool rip = false;


            if (14 - X <= 7)
            { wake = true; }

            if ((4 * 60 - (X + 1) / 2 * Y <= 0) && (4 * 60 - (X + 1) / 2 * Y >= -2 * 60))
            { rip = true; }

            if (wake == true && rip == true)
            { answer = true; }

            return answer;
        }
    }
}

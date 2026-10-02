namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            double a = Math.Abs(d);
            if (a >= 1)
                answer = true;
            else
                answer = false;

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            double summ = (d + f) / 2.0;

            if (summ > 0)
                answer = true;
            else
                answer = false;

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            double summ1 = a + b;

            double sredn = ((Math.Abs(a) + Math.Abs(b)) / 2.0);
            if (summ1 > sredn)
                answer = true;
            else
                answer = false;

                return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            if (a > b && a > c)
                answer = a;
            else if (b > a && b > c)
                answer = b;
            else
                answer = c;

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            if (Math.Abs(x) > 1)
                answer = 0;

            else
                answer = (x * x) - 1;

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
                    {
                        answer = true;
                    }
                }
                else
                {
                    if (y <= 1 - x)
                    {
                        answer = true;
                    }
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
            {
                if (n % 2 == 0)

                    answer = false;
            }
            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            int current = 14 * 60;
            int wanted = 7 * 60;
            for (int day = 1; day <= X; day++)
            {
                current -= 60;

                if (day % 2 != 0)
                {
                    current -= Y;
                }
                if (current <= wanted)
                {
                    answer = true;
                    break;
                }
             }

                    return answer;
        }
    }
}

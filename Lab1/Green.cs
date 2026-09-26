namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            double AbsoluteValue = Math.Abs(d);
            if (AbsoluteValue >= 1)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            double sr_arif = (d + f) / 2.0;
            if (sr_arif > 0)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            int summa = a + b;
            double sr_znach = (Math.Abs(a) + Math.Abs(b)) / 2.0;
            if (summa > sr_znach)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            answer = a;
            if (b > answer)
            {
                answer = b;
            }
            if (c > answer)
            {
                answer = c;
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x) > 1)
            {
                answer = 0;
            }
            if (Math.Abs(x) <= 1)
            {
                answer = x * x - 1;
            }
            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            if (y >= 0)
            {
                if (x < 0 && y <= 1 + x)
                {
                    answer = true;
                }
                if (x >= 0 && y <= 1 - x)
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

            // code here
            if (n < 0)
            {
                answer = false;
            }
            else if (n % 2 == 0)
            {
                answer = false;
            }
            // end

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here
            int get_up = 840;
            int new_get_up = 420;
            int sleep = 600;
            int day;
            for (day = 1; day <= X; day++)
            {
                if (get_up > new_get_up)
                {
                    get_up -= 60;
                    sleep -= 60;
                }
                if (day % 2 != 0)
                {
                    sleep += Y;
                }
            }
            if (sleep >= 420 && sleep <= 540 && get_up == 420)
            {
                answer = true;
            }
            // end

            return answer;
        }
    }
}

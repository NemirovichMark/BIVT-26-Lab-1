namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            answer = Math.Abs(d) >= 1;
            // end

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            answer = (d + f) / 2 > 0;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            answer = a + b > (Math.Abs(a) + Math.Abs(b)) / 2.0;
            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            answer = a;
            if (b > answer) answer = b;
            if (c > answer) answer = c;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x) > 1)
                answer = 0;
            else
                answer = x * x - 1;
            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            double line;
            if (x < 0)
                line = 1 + x;
            else
            {
                line = 1 - x;
            }
            answer = y >= 0 && y <= line;
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
            else
            {
                if (n % 2 == 0)
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

            // code here
            int bed = 4 * 60;
            int wake = 14 * 60;
            int goal = 7 * 60;
            for (int day = 1; day <= X; day++)
            {
                if (wake > goal)
                {
                    wake -= 60;
                }
                if (day % 2 == 1)
                {
                    bed -= Y;
                }
            }
            int sleep = wake - bed;
            answer = wake == goal && sleep >= 7 * 60 && sleep <= 9 * 60;
            // end

            return answer;
        }
    }
}
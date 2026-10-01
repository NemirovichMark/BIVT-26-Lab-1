\using System.Collections.Concurrent;
using System.IO.Compression;

namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            if (Math.Abs(d) >= 1)
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
            double sum = (d + f) / 2;
            if (sum > 0)
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
            double average = (Math.Abs(a) + Math.Abs(b)) / 2.0;
            int sum = a + b;

            if (sum > average)
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
            answer = Math.Max(Math.Max(a, b), c);

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here

            double modx = Math.Abs(x);

            if (modx > 1)
            {
                answer = 0;
            }
            else
            {
                answer = Math.Pow(modx, 2) - 1;
            }
            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            double border;

            if (x < 0)
            {
                border = 1 + x;
            }
            else
            {
                border = 1 - x;
            }

            if (y >= 0 && y <= border)
            {
                answer = true;
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

            int wake = 14 * 60;
            int sleep = 4 * 60;

            for (int day = 1; day <= X; day++)
            {
                if (wake > 7 * 60)
                {
                    wake = wake - 60;
                }
                if (day % 2 == 1)
                {
                    sleep = sleep - Y;
                }
            }

            int sleepTime = wake - sleep;

            if (wake == 7 * 60 && sleepTime >= 7 * 60 && sleepTime <= 9 * 60)
            {
                answer = true;
            }
            // end

            return answer;
        }
    }
}
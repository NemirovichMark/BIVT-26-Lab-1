using System.Collections.Concurrent;
using System.IO.Compression;

namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            double result = Math.Exp(d);
            if (Math.Abs(result) >= 1)
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
            double abs_a = Math.Abs(a);
            double abs_b = Math.Abs(b);

            double res = (abs_a + abs_b) / 2.0;
            double sum = (abs_a + abs_b);

            if (sum > res)
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

            // code here
            
            // end

            return answer;
        }
    }
}
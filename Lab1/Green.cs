using System.Security.Cryptography;

namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            if (Math.Abs(d) >= 1) { answer = true; }
            // end

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            if ((d + f) >= 0) { answer = true; }
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            int num1 = a + b;
            int num2 = Math.Abs(a) + Math.Abs(b) / 2;
            if (num1 > num2) { answer = true; }
            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            int first = Math.Max(a, b);
            int second = Math.Max(c, b);
            answer = Math.Max(first, second);
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double a = x * x;
            if (Math.Abs(x) <= 1) { answer = a - 1; }
            else { answer = 0; }
            // end

                return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            double a;
            if (x < 0)
            {
                a = x + 1;
            }
            else
            {
                a = 1 - x;
            }
            if (y <= a && y >= 0)
            {
                answer = true;
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
            if (n<0 ) { answer = false; }
            else
            {
                if (n%2==0) { answer = false; }
            }
            // end

                return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here
            int a = (X + 1) / 2;
            int b = a * Y;
            if (X >= 7 && b >= 240 && b <= 360)
            {
                answer = true;
            }
            // end

                return answer;
        }
    }
}

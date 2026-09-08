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
            if (x == -1 && y == 0) { answer = true; }
            if (x == 1 && y == 0) { answer = true; }
            if (x == 0 && y == 1) { answer = true; }
            double y1 = 0;
            if (x >= 0) { y1 = 1 - x; }
            else {  y1 = 1 + x; }

            // add if()

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
            int h1 = 960;
            int h2 = 1560;
            bool c = false;
            bool a = true;
            h1 -= Y;

            while (X != 0) {
                if (c == true) { h1 -= Y; }
                if (c == false) { c = true; }
                else { c = false; }
                if (660 > (h2 - h1) && (h2-h1) > 540) { a = false; }
                if (a == true) { h2 -= 60; }
                X -= 1;
            }
            if (660 > (h2 - h1) && (h2 - h1) > 540 && h2 == 420) { answer = true; }
            else { answer = false; }

            // arrays?

                // end

                return answer;
        }
    }
}

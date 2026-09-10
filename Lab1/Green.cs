namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            if (d >= 1 || d <= -1)
                answer = true;
            // end

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            double sr_ar = (d + f) / 2;
            if (sr_ar > 0)
                answer = true;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            int a_copy = a, b_copy = b;
            if (a < 0) a = a - (2 * a);
            if (b < 0) b = b - (2 * b);
            double average = (a + b) / 2;
            if (a_copy + b_copy > average)
                answer = true;
            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            if (a >= b && a >= c)
                answer = a;
            else if (b >= a && b >= c)
                answer = b;
            else
                answer = c;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double module = x;
            if (module < 0)
                module = module - (2 * module);
            if (module > 1)
                answer = 0;
            else
                answer = module * module - 1;
            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            if (y <= 1 - x && y <= 1 + x && y >= 0)
                answer = true;

            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
            if (n < 0)
                answer = false;
            else if (n % 2 == 0)
                answer = false;
            // end

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here
            int statement = X * 60 + (X + 1) / 2 * Y;
            if (statement >= 420)
                answer = true;
            // end

            return answer;
        }
    }
}

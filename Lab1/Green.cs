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
            if (a >= b && a >= c)
            {
                answer = a;
            }
            else if (b >= c && b >= a)
            {
                answer = b;
            }
            else
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

            // code here
            double upper;
            if (x < 0)
            {
                upper = 1 + x;
            }
            else
            {
                upper = 1 - x;
            }
            answer = y >= 0 && y <= upper;
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
            answer = false;
            if（x >= 7)
            {
            int teaCount = (X + 2) / 2;
            int sleepMinues = 180 + teadCount * Y;
            answer = sleepMinutes >= 420 && sleepMinutes <= 540;
            // end

            return answer;
        }
    }
}

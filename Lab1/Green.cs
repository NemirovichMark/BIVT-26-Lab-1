namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            if (Math.Abs(d) >= 1)
                answer = true;
            else
                answer = false;
            // end

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            double avg = (d + f) / 2;

            if (avg > 0)
                answer = true;
            else
                answer = false;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            double avg = (Math.Abs(a) + Math.Abs(b)) / 2.0;

            if (a + b > avg)
                answer = true;
            else
                answer = false;
            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            answer = a;

            if (b > answer)
                answer = b;

            if (c > answer)
                answer = c;
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
            if (y >= 0 && y <= 1 - Math.Abs(x))
                answer = true;
            else
                answer = false;
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
        public bool Task8(int x, int y)
        {
            bool answer = false;

            // code here
            if (x >= 7)
            {
                int teaCount = (x + 1) / 2;
                int sleepShift = teaCount * y;

                if (sleepShift >= 240 && sleepShift <= 360)
                    answer = true;
            }
            // end

            return answer;
        }
    }
}
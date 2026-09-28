namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            if (d >= 1 || d <= -1)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            // end

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            double result = (d + f) / 2;
            if (result > 0)
            {
                answer = true;
            }
            else
            {
                return answer;
            }
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
        int sum = a + b;
        double average = sum / 2.0;
        if (sum > average)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }
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
            else if (b >= a && b >= c)
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
            if (Math.Abs(x) <= 1)
            {
                double y = x * x -1;
                answer = y;
            }
            else
            {
                answer = 0;
            }
            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            string ans1 = "inside";
            string ans2 = "outside";
            if ((y == 0 && x >= 1 && x <= 1) || (y > 0 && y <= 1 + x && y <= 1 - x))
            {
                answer = true;
            }
            else
            {
                answer = false;
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
            double getUp = 14.0;
            double goDown = 28.0;
            int x2 = X;
            while (x2 > 0)
            {
                if (getUp > 7.0)
                {
                    getUp -= 1.0;
                }

                if (x2 % 2 == X % 2)
                {
                    goDown -= (double)Y / 60.0;
                }

                x2--;
            }
            double sleepDuration = getUp - goDown;
            
            return sleepDuration >= -17.0 && sleepDuration <= -15.0;
            // end

            return answer;
        }
    }
}
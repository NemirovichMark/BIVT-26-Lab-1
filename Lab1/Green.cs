namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;
            if ((Math.Abs(d))>=1)
            {
                answer = true;
            }
            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;
            double sr = (d + f) / 2;
            if (sr > 0)
            {
                answer = true;
            }
            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;
            int sum1 = a + b;
            double sum2 = (Math.Abs(a) + Math.Abs(b))/2;
            if (sum1 > sum2)
            {
                answer = true;
            }
            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;
            answer = Math.Max(Math.Max(a, b), c);
            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;
            if ((Math.Abs(x)) > 1) 
            {
                answer = 0;
            }
            if ((Math.Abs(x)) <= 1)
            {
                answer = (Math.Pow(x, 2)) - 1;
            }
            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;
            double y1 = 1 - x;
            double y2 = 1 + x;
            if (y <= y1 && y <= y2 && y >= 0) 
            {
                answer = true;
            }
            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;
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
            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;
            if (X >= 7)
            {
                if (((240 - (Y * (X + 1) / 2)) <= 0) && ((240 - (Y * (X + 1) / 2)) >= -120))
                {
                    answer= true;
                }
            }
           
            return answer;
        }
    }
}

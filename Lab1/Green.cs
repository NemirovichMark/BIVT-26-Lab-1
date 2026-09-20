namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            if (Math.Abs(d)>=1)
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
            if ((d/2+f/2)>0)
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
            if ((a+b)>(Math.Abs(a)/2+Math.Abs(b)/2))
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
            answer = Math.Max(a, Math.Max(b, c));
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x)<=1)
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
            if((x>=-1)&&(x<=1))
            {
                if (x<0)
                {
                    if ((y>=0) && (y<=1+x))
                    {
                        answer = true;
                    }

                }
                else
                {
                   if((y>=0) && (y<=1-x))
                            {
                        answer = true;
                    }
                }
            }
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
            if (n<0)
            {
                answer = false;
            }
            else
            {
                if (n%2==0)
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
            int a = (X + 1) / 2;
            int b = 4 * 60 - a * Y;
            int c = 14 - Math.Min(X, 7);

            int d = (7 * 60 - ((b % 1440 + 1440) % 1440) + 1440) % 1440;

            answer = c == 7 && d >= 420 && d <= 540;
            // end

            return answer;
        }
    }
}

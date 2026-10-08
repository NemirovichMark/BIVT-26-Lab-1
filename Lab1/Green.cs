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
            if ((d + f) / 2 > 0)
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
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if ((a + b) > (((Math.Abs(a) + Math.Abs(b))) / 2))
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
            int s = Math.Max(a,b);
            s=Math.Max(s,c);
            answer = s;
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
                answer = Math.Pow(x,2)-1;
            }
            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            if (x >= -1 && x <= 1 && y >= 0 && y <= 1 - Math.Abs(x))
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

            //code here
            int tea = (X + 1) / 2;

            int wake = 14 * 60 - Math.Min(X, 7) * 60;
            int sleep = 4 * 60 - tea * Y;

            int sleepTime = wake - sleep;

            if (sleepTime < 0)
                sleepTime += 24 * 60;

            if (wake == 7 * 60 && sleepTime >= 7 * 60 && sleepTime <= 9 * 60)
                answer = true;
            
            // end

            return answer;
        }
    }
}
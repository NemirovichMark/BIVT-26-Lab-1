namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            double D = Math.Abs(d);
            if (D >= 1)
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
            if (((d + f) / 2) > 0)
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
            int sum = a + b;
            int A = Math.Abs(a);
            int B = Math.Abs(b);
            if (sum > ((A + B) / 2))
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
            int max = Math.Max(a, Math.Max(b, c));
            answer = max;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double D = Math.Abs(x);
            if (D > 1)
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
            if (y >= 0)
            {
                if (x < 0)
                {
                    if (y <= 1 + x) answer = true;
                }
                else
                {
                    if (y <= 1 - x) answer = true;
                }
            }
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
            if (n < 0 || n % 2 == 0)
            {
                answer = false;
            }
            else
            {
                answer = true;
            }
            // end

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here
            if (X < 7)
            {
                answer = false;
            }
            int teas = (X + 1) / 2;
            int minutes = teas * Y;
            int t = 240 - minutes;
            if (t >= -120 && t <= 0)
            {
                answer = true;
            }
            // end

            return answer;
        }
    }
}
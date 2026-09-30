namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if (a > 0 && b > 0)
            {
                answer = true;
            }
            else if (a < 0 && b < 0)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            int j = (int)d;
            if (Math.Abs(d - j) >= 0.0001)
                answer = true;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (b != 0 && a % b == 0)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            if (Math.Abs(d) >= Math.Abs(f) && Math.Abs(d) >= Math.Abs(g))
            {
                return d;
            }
            else if (Math.Abs(f) >= Math.Abs(g))
            {
                return f;
            }
            else
            {
                return g;
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1)
            {
                answer = 0;
            }
            if (x > -1 && x <= 0)
            {
                answer = x + 1;
            }
            if (x > 0)
            {
                answer = 1;
            }
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            if (circleS <= Math.PI * squareS / 4)
            {
                answer = true;
            }
            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here
            if (Math.Abs(d) < Math.Abs(f))
                if (d > 0)
                    answer = -1;
                else
                    return answer;
            else if (f > 0)
                answer = 1;
            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here

            int f = a / 2;
            int s = b / 2;
            int t = c / 2;

            int total = f + s + t;

            if (total % 3 == 0)
            {
                int c1 = total / 3;

                if (c1 >= 1 &&
                    c1 <= a &&
                    c1 <= b &&
                    c1 <= c)
                {
                    answer = true;
                }
            }

            if ((total + 1) % 3 == 0)
            {
                int c2 = (total + 1) / 3;

                if (c2 >= 1 &&
                    c2 <= a &&
                    c2 <= b &&
                    c2 <= c)
                {
                    answer = true;
                }
            }

            // end

            return answer;
        }
    }
}
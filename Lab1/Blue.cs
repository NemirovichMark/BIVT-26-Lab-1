namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;
            // code here
            answer = (a > 0 && b > 0) || (a < 0 && b < 0);
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            answer = d != Math.Truncate(d);
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            answer = b != 0 && a % b == 0;
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            if (Math.Abs(d) >= Math.Abs(f) && Math.Abs(d) >= Math.Abs(g))
            {
                answer = d;
            }
            else if (Math.Abs(f) >= Math.Abs(g))
            {
                answer = f;
            }
            else
            {
                answer = g;
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
            else if (x <= 0)
            {
                answer = x + 1;
            }
            else
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
            answer = 4 * circleS <= Math.PI * squareS;
            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here
            if (Math.Abs(d) < Math.Abs(f))
            {
                if (d > 0)
                {
                    answer = -1;
                }
            }
            else
            {
                if (f > 0)
                {
                    answer = 1;
                }
            }
            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int total = a / 2 + b / 2 + c / 2;
            int minCapacity = Math.Min(a, Math.Min(b, c));
            if (total % 3 == 0)
            {
                int each = total / 3;

                if (each >= 1 && each <= minCapacity)
                {
                    answer = true;
                }
            }
            else if (total % 3 == 2)
            {
                int each = (total + 1) / 3;

                if (each >= 1 && each <= minCapacity)
                {
                    answer = true;
                }
            }
            // end

            return answer;
        }
    }
}

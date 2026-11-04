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
            else
            {
                answer = false;
            }

            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            if (d % 1 != 0)
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
            if (b == 0)
            {
                answer = false;
            }
            else if (a % b == 0)
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
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            answer = d;

            if (Math.Abs(f) > Math.Abs(answer))
            {
                answer = f;
            }

            if (Math.Abs(g) > Math.Abs(answer))
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
            double r = Math.Sqrt(circleS / Math.PI);
            double side = Math.Sqrt(squareS);

            if (2 * r <= side)
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
            int sum = a / 2 + b / 2 + c / 2;

            if (sum % 3 == 2)
            {
                sum = sum + 1;
            }

            int part = sum / 3;

            if (sum % 3 == 0 && part >= 1 &&
                part <= a && part <= b && part <= c)
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
    }
}
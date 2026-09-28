namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if ((a > 0 && b > 0) || (a < 0 && b < 0)) 
                answer = true;
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            if (d < 0)
            {
                d = d * -1;
                if (d - (int)d > 0)
                    answer = true;
                else
                    answer = false;
            }
            else
                if (d - (int)d > 0)
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
            if (b != 0 && a % b == 0)
                answer = true;
            else
                answer = false;
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            if (Math.Abs(d) == Math.Max(Math.Max(Math.Abs(d), Math.Abs(f)), Math.Max(Math.Abs(d), Math.Abs(g))))
                answer = d;
            else if (Math.Abs(f) == Math.Max(Math.Max(Math.Abs(d), Math.Abs(f)), Math.Max(Math.Abs(d), Math.Abs(g))))
                answer = f;
            else if (Math.Abs(g) == Math.Max(Math.Max(Math.Abs(d), Math.Abs(f)), Math.Max(Math.Abs(d), Math.Abs(g))))
                answer = g;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1)
                answer = 0;
            else if (x > -1 && x <= 0)
                answer = x + 1;
            else if (x > 0)
                answer = 1;
            {
                
            }
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double r1 = Math.Sqrt(circleS / Math.PI);
            double r2 = Math.Sqrt(squareS);
            if (2 * r1 <= r2)
                answer = true;

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
                    answer = -1;
                else
                    return answer;
            }
            else
            {
                if (f > 0)
                    answer = 1;
                else
                    return answer;
            }

            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int a1 = a / 2;
            int b1 = b / 2;
            int c1 = c / 2;
            int s = a1 + b1 + c1;
            int s1 = s / 3;
            int s2 = (s + 1) / 3;

            if (s % 3 == 0 && s1 >= 1 && a >= s1 && b >= s1 && c >= s1)
            {
                answer = true;
            }
            else if (s % 3 == 2 && s2 >= 1 && a >= s2 && b >= s2 && c >= s2)
            {
                s = s + 1;
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

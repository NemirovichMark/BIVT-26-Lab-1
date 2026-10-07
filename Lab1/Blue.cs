namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if (a == 0 || b == 0)
                answer = false;
            else
                answer = (a > 0 && b > 0) || (a < 0 && b < 0);
            // end

            return answer;
        }

        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            double frac = Math.Abs(d - Math.Truncate(d));
            answer = frac > 0.0001;
            // end

            return answer;
        }

        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (b == 0)
                answer = false;
            else
                answer = (a % b == 0);
            // end

            return answer;
        }

        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            double ad = Math.Abs(d);
            double af = Math.Abs(f);
            double ag = Math.Abs(g);

            answer = d;
            double maxAbs = ad;

            if (af > maxAbs)
            {
                maxAbs = af;
                answer = f;
            }
            if (ag > maxAbs)
            {
                maxAbs = ag;
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
                answer = 0;
            else if (x <= 0)
                answer = x + 1;
            else
                answer = 1;
            // end

            return answer;
        }

        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double r = Math.Sqrt(circleS / Math.PI);
            double a = Math.Sqrt(squareS);
            answer = (2 * r) <= a;
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
                    answer = 0;
            }
            else
            {
                if (f > 0)
                    answer = 1;
                else
                    answer = 0;
            }
            // end

            return answer;
        }

        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int goldA = a / 2;
            int goldB = b / 2;
            int goldC = c / 2;
            int total = goldA + goldB + goldC;

            if (total % 3 == 0)
            {
                int each = total / 3;
                answer = (each >= 1) && (each <= a) && (each <= b) && (each <= c);
            }
            else if ((total + 1) % 3 == 0)
            {
                int each = (total + 1) / 3;
                answer = (each >= 1) && (each <= a) && (each <= b) && (each <= c);
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

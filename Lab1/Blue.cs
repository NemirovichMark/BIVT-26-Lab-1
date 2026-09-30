namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if ((a != 0 && b != 0) && ((a > 0 && b > 0) || (a < 0 && b < 0)))
                answer = true;
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            int d1 = (int)d;
            double d2 = d1;
            if (Math.Abs(d - d2) >= 0.0001)
                    answer = true;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (b!= 0 && a % b == 0)
                answer = true;
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            double m = Math.Max(Math.Abs(d), Math.Abs(f));
            m = Math.Max(m, Math.Abs(g));
            if (Math.Abs(f) == m)
                answer = f;
            else if (Math.Abs(g) == m)
                answer = g;
            else
                answer = d;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double y = 0;
            if (x <= -1)
                y = 0;
            else if (x <= 0 && x > -1)
                y = x + 1;
            else if (x > 0)
                y = 1;
            answer = y;
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double Rcir = Math.Sqrt(circleS / Math.PI);
            double rvpis = Math.Sqrt(squareS)/2;
            if (Rcir <= rvpis)
                answer = true;
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
                    answer = answer;
            else
                if (f > 0)
                    answer = 1;
            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            a = a / 2;
            b /= 2;
            c /= 2;
            int s = a + b + c;
            if ((s % 3 == 0 && s>=3) || (s + 1) % 3 == 0)
                answer = true;
            // end

            return answer;
        }
    }
}

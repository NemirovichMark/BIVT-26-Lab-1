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
            if (Math.Abs(d - Math.Round(d)) >= 0.0001)
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
            if (b != 0)
            {
                if (a % b == 0)
                {
                    answer = true;
                }
            }
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            if (Math.Abs(d) > Math.Abs(f) && Math.Abs(d) > Math.Abs(g))
            { answer = d; }
            if (Math.Abs(f) > Math.Abs(d) && Math.Abs(f) > Math.Abs(g))
            { answer = f; }
            if (Math.Abs(g) > Math.Abs(f) && Math.Abs(g) > Math.Abs(d))
            { answer = g; }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1) { answer = 0; }
            if (x > -1 && x <= 0) { answer = x + 1; }
            if (x > 0) { answer = 1; }
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            var diam_sq = Math.Sqrt(squareS);
            var rad_cir = Math.Sqrt(circleS / Math.PI);
            var diam_cir = rad_cir * 2;
            if (diam_sq >= diam_cir) { answer = true; }
            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here
            if (Math.Abs(d) < Math.Abs(f))
            {
                if (d > 0) { answer = -1; }
                else { return answer; }
            }
            else
            {
                if (f > 0) { answer = 1; }
                else { return answer; }
            }
            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int first = a / 2;
            int second = b / 2;
            int third = c / 2;

            int total = first + second + third;

            if (total % 3 == 0)
            {
                int equal = total / 3;
                if (equal >= 1 && equal <= Math.Min(a, Math.Min(b, c)))
                { answer = true; }
            }

            total++;

            if (total % 3 == 0)
            {
                int equal = total / 3;
                if (equal >= 1 && equal <= Math.Min(a, Math.Min(b, c)))
                { answer = true; }
            }
            // end

            return answer;
        }
    }
}

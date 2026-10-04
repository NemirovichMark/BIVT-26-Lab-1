namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if ((a < 0 && b < 0) || (a > 0 && b > 0))
            { answer = true; }
            else { answer = false; }
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            if (d % 1.0 != 0)
            { answer = true; }
            else { answer = false; }
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            double c = (double)a / b;
            if (c % 1 == 0) { answer = true; }
            else { answer = false; }
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            if (Math.Max(Math.Max(Math.Abs(d), Math.Abs(f)), Math.Abs(g)) == Math.Abs(d))
            { answer = d; }
            else if (Math.Max(Math.Max(Math.Abs(d), Math.Abs(f)), Math.Abs(g)) == Math.Abs(f))
            { answer = f; }
            else { answer = g; }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x > -1 && x <= 0) { answer = x + 1; }
            else if (x <= -1) { answer = 0; }
            else { answer = 1; }
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            if ((circleS / Math.PI) <= (squareS / 4)) { answer = true; }
            else { answer = false; }
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
                { answer = -1; }
            }
            else { if (f > 0) { answer = 1; } }
            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int a0 = a / 2;
            int b0 = b / 2;
            int c0 = c / 2;
            int m = Math.Min(Math.Min(a, b), c);
            int su = a0 + b0 + c0;
            if (su % 3 == 0)
            {
                if ((su / 3) >= 1 && (su / 3) <= m)
                { answer = true; }
            }
            else if (su % 3 == 2)
            {
                if (((su + 1) / 3) >= 1 && ((su + 1) / 3) <= m)
                { answer = true; }
            }
            else { answer = false; }
            // end

            return answer;
        }
    }
}
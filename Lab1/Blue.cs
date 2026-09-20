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
            double fraction = Math.Abs(d - Math.Truncate(d));
            if (fraction >= 0.0001)
                answer = true;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (b != 0 && a % b == 0)
                answer = true;
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            double absd = Math.Abs(d);
            double absf = Math.Abs(f);
            double absg = Math.Abs(g);
            if (absd > absf && absf >= absg)
                answer = d;
            else if (absf > absd && absd >= absg)
                answer = f;
            else
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
            else
                answer = 1;
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            if (circleS <= (Math.PI / 4) * squareS)
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
            }
            else
            {
                if (f > 0)
                    answer = 1;
            }
            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int s = (a / 2 + b / 2 + c / 2);
            if (s % 3 == 0 && s / 3 >= 1 && s / 3 <= a && s / 3 <= b && s / 3 <= c)
            {
                answer = true;
            }
            else if ((s + 1) % 3 == 0 && (s + 1) / 3 >= 1 && s / 3 <= a && s / 3 <= b && s / 3 <= c)
            {
                answer = true;
            }
            // end

            return answer;
        }
    }
}
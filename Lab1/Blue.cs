namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if ((a > 0 && b > 0) || (a < 0 && b < 0))
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
            double fraction = Math.Abs(d - Math.Truncate(d));
            if (fraction >= 0.0001)
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
            double absd = Math.Abs(d);
            double absf = Math.Abs(f);
            double absg = Math.Abs(g);
            if (absd >= absf && absd >= absg)
            {
                answer = d;
            }
            else if (absf >= absd && absf >= absg)
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
            else if (x > -1 && x <= 0)
            {
                answer = x + 1;
            }
            else if (x>0)
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
            if (circleS <= (Math.PI / 4) * squareS)
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
            int goldA = a / 2;
            int goldB = b / 2;
            int goldC = c / 2;
            
            bool option1 = (goldA == goldB && goldB == goldC);
            bool option2 = (goldA == goldB && goldA == (goldC + 1));
            
            if ((option1 || option2) && goldA >= 1 && goldB >= 1 && goldC >= 1)
            {
                answer = true;
            }
            // end

            return answer;
        }
    }
}

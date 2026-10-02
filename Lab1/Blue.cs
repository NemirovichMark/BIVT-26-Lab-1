namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if (a * b > 0)
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
            double T = 0.0001;
            // code here
            int d1 = (int) d;
            if (Math.Abs(d - d1) > T)
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
            if (b == 0)
            {
                return false;
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
            double d1 = Math.Abs(d);
            double f1 = Math.Abs(f);
            double g1 = Math.Abs(g);
            if (f1 > g1 && f1 > d1)
            {
                answer = f;
            }

            if (g1 > d1 && g1 > f1)
            {
                answer = g;
            }

            if (d1 > g1 && d1 > f1)
            {
                answer = d;
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x<= -1)
            {
                answer = 0;
            }
            else if (-1 < x && x <= 0)
            {
                answer = x+1;
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
            double c = 2*Math.Sqrt(circleS / Math.PI);
            double s = Math.Sqrt(squareS);
            if (s >= c)
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
            int ca = a / 2;
            int cb = b / 2;
            int cc = c / 2;
            int allc = ca + cb + cc;
            if (allc < 2)
            {
                answer = false;
            }
            else if (allc / 3 > a || allc / 3 > c || allc / 3 > b)
            {
                answer = false;
            }
            else if (allc % 3 == 0)
            {
                answer = true;
            }
            else if ((allc + 1) % 3 == 0)
            {
                answer = true;
            }
            // end

            return answer;
        }
    }
}
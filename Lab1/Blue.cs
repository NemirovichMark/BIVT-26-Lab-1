namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            if ((a == 0 && b == 0) || (a > 0 && b > 0) || (a < 0 && b < 0))
            {
                answer = true;
            }

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            if (d % 1 == 0)
            {
                answer = false;
            }
            else
            {
                answer = true;
            }

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            if (b == 0)
            {
                answer = false;
            }

            else if (a % b == 0)
            {
                answer = true;
            }

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            if (Math.Abs(d) > Math.Abs(f) && Math.Abs(d) > Math.Abs(g))
            {
                answer = d;
            }
            else if (Math.Abs(f) > Math.Abs(d) && Math.Abs(f) > Math.Abs(g))
            {
                answer = f;
            }
            else
            {
                answer = g;
            }

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            if (x <= -1)
            {
                answer = 0;
            }
            else if (x > -1 && x <= 0)
            {
                answer = x + 1;
            }
            else if (x > 0)
            {
                answer = 1;
            }

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            double r = Math.Sqrt((circleS / Math.PI));
            double d = r * 2;
            double a = Math.Sqrt(squareS);
            if (a >= d)
            {
                answer = true;
            }
                
            

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            
            // end

            return answer;
        }
    }
}

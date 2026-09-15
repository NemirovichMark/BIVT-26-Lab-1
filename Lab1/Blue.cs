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
            if ((b != 0) && (a % b == 0))
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
            if ((Math.Abs(d) > Math.Abs(f)) && (Math.Abs(d) > Math.Abs(g)))
            {
                answer = d;
            }
            else
            { 
                if ((Math.Abs(f) > Math.Abs(d)) && (Math.Abs(f) > Math.Abs(g)))
                {
                    answer = f;
                }
                else
                {
                    answer = g;
                }
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
            else
            {
                if ((x > -1) && (x < 0))
                {
                    answer = x + 1;
                }
                else
                {
                    answer = 1;
                }
            }
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double pi = Math.PI;
            if (Math.Sqrt(circleS / pi) <= (Math.Sqrt(squareS) / 2))
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
            int meshok = a / 2 + b / 2 + c / 2;
            if (meshok % 3 == 0)
            {
                int rovno = meshok / 3;
                if (rovno >= 1)
                {
                    answer = true;
                }
            }
            else
                {
                int meshok2 = meshok + 1;
                if (meshok2 % 3 == 0)
                {
                    int rovno2 = meshok2 / 3;
                    if (rovno2 >= 1)
                    {
                        answer = true;
                    }
                }
            }
            // end

            return answer;
        }
    }
}

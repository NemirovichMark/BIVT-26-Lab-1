namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;
            if ((a > 0 && b > 0) || (a < 0 && b < 0) )
            {
                answer = true;
            }
            
            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;
            if (Math.Abs(d - Math.Truncate(d)) >= 0.0001)
            {
                answer = true;
            }
            
            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;
            
            if (b != 0 && a % b == 0)
            {
                answer = true;
            }

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            
            double d1= Math.Abs(d);
            double f1 = Math.Abs(f);
            double g1 = Math.Abs(g);
            if (d1 >= f1 && d1 >= g1)
            {
                answer = d;
            }

            else if (f1 >= g1 && f1 >= d1)
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
            double y = 0;
                
            if (x <= -1)
            {
                y = 0;
            }
            else if (x <= 0 && x > -1)
            {
                y = x + 1;
                    
            }
            else if (x > 0)
            {
                y = 1;
            }
            answer = y;

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;
            double r = Math.Sqrt(circleS /Math.PI);
            if (2 * r <= Math.Sqrt(squareS))
            {
                answer = true;
            }
            return answer;
        }
        public double Task7(double d, double f)
        {
            int answer = 0;
            if (Math.Abs(d) < Math.Abs(f))
            {
                if (d > 0)
                {
                    answer = -1;
                    return answer;
                }
                else
                    {
                    return answer;
                    }
            }
            else
            {
                if (f > 0)
                {
                    answer = 1;
                    return answer;
                }
                else
                {
                    return answer;
                }
            }
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;
            a /= 2;
            b /= 2;
            c /= 2;
            if (a+b+c >=3 && (a + b + c) % 3 == 0)
            {
                answer = true;
            }
            c++;
            if (a + b + c >= 3 && (a + b + c) % 3 == 0)
            {
                answer = true;
            }
            return answer;
        }
    }
}

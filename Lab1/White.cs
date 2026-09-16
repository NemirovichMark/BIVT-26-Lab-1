namespace Lab1
{
    public class White
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            if (d > 0)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public bool Task2(int n)
        {
            bool answer = false;

            // code here
            if(n%2==0)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public int Task3(int a, int b)
        {
            int answer = 0;

            // code here
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
   
            }

                // end

                return answer;
        }
        public double Task4(double d, double f)
        {
            double answer = 0;

            // code here
            
            if (Math.Abs (d) <= Math.Abs (f))
            {
                
                return d;
            }
            else
            {
                
                return f;
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x)>1)
            {
                return 1;
            }
            else 
            {
                return x;
            }
                // end

                return answer;
        }
        public bool Task6(double x, double y, double r)
        {
            bool answer = false;

            // code here
            if (Math.Abs((x * x) + (y * y) - (r * r)) <= 0.0001)
            {
                return true;
            }
            else
            {
                return false;
            }
                // end

                return answer;
        }

        public bool Task7(int n)
        {


            // code here
            int s = n * n;
            bool answer = false;
            if(s - n>2*n)
            {
                if(n%2==0)
                {
                    answer = true;
                }
            }
            return answer;

                // end
        }
        public bool Task8(double L, int T, int M)
        {
            bool answer = false;
            {
                bool timevalid = (L / 10) <= 3.0;
                bool landmarks = (T + M)>=5;
                bool Mount = (M % 2 == 0);
                return timevalid && landmarks && Mount;
            }

            // code here

            // end

            return answer;
        }
    }
}

namespace Lab1
{
    public class White
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            answer = d>0;
 
            // end

            return answer;
        }
        public bool Task2(int n)
        {
            bool answer = false;

            // code here
            if (n % 2 == 0)
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
                answer = a;
            }
            else (a < b);
            {
                answer = b;
            }
    

            // end

            return answer;
        }
        public double Task4(double d, double f)
        {
            double answer = 0;

            // code here
            answer = (Math.Ads(d) < Math.Ads(f)) ? d : f;

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            answer =  (Mach.Ads(x) > 1) ? 1 : x;
            
                
            

            // end

            return answer;
        }
        public bool Task6(double x, double y, double r)
        {
            bool answer = false;

            // code here
            answer = Math.Ads(x * x * y * y - r * r) <= 1e-4;

            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = false;

            // code here
            int s = n * n;
            if (s - n > 2 * n)
            {
                if (n % 2 == 0)
                {
                    answer = true;
                }
            }

            // end

            return answer;
        }
        public bool Task8(double L, int T, int M)
        {
            bool answer = false;

            // code here
            if (L / 10 <= 3 && T + M >= 5 && M % 2 == 0)
            {
                answer = true;
            }

            // end

            return answer;
        }
    }
}

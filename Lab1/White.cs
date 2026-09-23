namespace Lab1
{
    public class White
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            if (d > 0)
            answer= true;
            // end

            return answer;
        }
        public bool Task2(int n)
        {
            bool answer = false;

            // code here
            if (n % 2 == 0)
                answer = true;

            // end

            return answer;
        }
        public int Task3(int a, int b)
        {
            int answer = 0;

            // code here
            if (a > b)
                answer = a;
            else
                answer = b;
            // end

            return answer;
        }
        public double Task4(double d, double f)
        {
            double answer = 0;

            // code here
            if (Math.Abs(d) <Math.Abs(f))
                answer = d;
            else
                answer = f;

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x) > 1)
                answer = 1;
            else
                answer = x;
            // end

            return answer;
        }
        public bool Task6(double x, double y, double r)
        {
            bool answer = false;

            // code here
            double a;
            a = (Math.Pow(x, 2) + Math.Pow(y, 2) - Math.Pow(r, 2));
            if (Math.Abs(a) <= Math.Pow(10, -4))
                answer = true;
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = false;

            // code here
            int s =n*n;
            if (s - n > 2 * n)
                if (n % 2 == 0)
                    answer = true;
                else
                    return answer;
            // end
         
            return answer;
        }
        public bool Task8(double L, int T, int M)
        {
            bool answer = false;

            // code here
            if (M%2==0)
                if ((M+T>=5) && L<=30)
                    answer=true;
            // end

            return answer;
        }
    }
}
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
            else
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
            
            if (Math.Abs(d) <= Math.Abs(f)) { answer = d; }
            else { answer = f; }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x) <= 1) { answer = x; }
            else { answer = 1; }
            // end

            return answer;
        }
        public bool Task6(double x, double y, double r)
        {
            bool answer = false;

            // code here

            if (Math.Abs(Math.Pow(x, 2) + Math.Pow(y, 2) - Math.Pow(r, 2)) <= Math.Pow(10, -4)) { answer = true; }
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = false;

            // code here
            int s = (int)Math.Pow(n, 2);
            if (s - n > n * 2)
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

            int orientiri = T + M;
            if ((L <= 30) && (orientiri >= 5) && (M % 2 == 0)) {
                answer = true;
            }
            // end

            return answer;
        }
    }
}
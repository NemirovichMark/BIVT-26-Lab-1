namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            // code here
            return (((a > 0) && (b > 0)) || ((a < 0) && (b < 0)));
            // end
        }
        public bool Task2(double d)
        {
            // code here
            return d % 1 != 0;
            // end
        }
        public bool Task3(int a, int b)
        {
            // code here
            return ((b != 0) && (a % b == 0));
            // end
        }
        public double Task4(double d, double f, double g)
        {
            List<double> nums = new List<double> { Math.Abs(d), Math.Abs(f), Math.Abs(g) };
            // code here
            if (Math.Abs(d) == nums.Max()) 
            {
                return d;
            }
            if (Math.Abs(f) == nums.Max())
            {
                return f;
            }
            return g;
            // end
        }
        public double Task5(double x)
        {

            // code here
            static double y(double x)
            {
                if (x <= -1) return 0;
                if (x <= 0) return x + 1;
                return 1;

            }
            // end

            return y(x);
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            return (2 * Math.Sqrt(circleS / Math.PI) <= Math.Sqrt(squareS));
            // end
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
            int bank = a / 2 + b / 2 + c / 2;
            int minCap = Math.Min(a, Math.Min(b, c));

            if (bank % 3 == 0)
            {
                int shr = bank / 3;
                return shr >= 1 && shr <= minCap;
            }

            if (bank % 3 == 2)
            {
                int shr = (bank + 1) / 3;
                return shr >= 1 && shr <= minCap;
            }
            
            if (bank % 3 == 2)
            {
                int shr = (bank + 1) / 3;
                return shr >= 1 && shr <= minCap;
            }
            
            // end

            return false;
        }
    }
}

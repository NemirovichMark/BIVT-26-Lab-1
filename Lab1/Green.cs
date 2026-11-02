namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            //code here
            double a = Math.Abs(d);
            answer = a>= 1;
            if (a >= 1)
            {
                answer = true;
            }

            //end


            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            if (((d + f) / 2) > 0)
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
            if ((a + b) > ((Math.Abs(a) + Math.Abs(b)) / 2))
            {
                answer = true;
            }


            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
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
            if (c > answer)
            {
                answer = c;
            }


            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x) > 1)
            {
                answer = 0;
            }
            else
            {
                answer=x*x+-1;
            }


            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            if (x < 0)
            {
                if (y >= 0 && y <= 1 + x)
                {
                    answer = true;
                }
            }
            else
            {
                if (y >= 0 && y <= 1 - x)
                {
                    answer = true;
                }
            }
                // end

                return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
            if (n < 0)
            {
                answer = false;
            }
            else
            {
                if (n % 2 == 0)
                {
                    answer = false;
                }
            }
            // end

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here
            int tea = ((X + 1) / 2)*Y;
            if (X >= 7)
            {
                if ((600 - 420 + tea) >= 420 && (600 - 420 + tea) <= 540)
                {
                    answer = true;
                }
            }
			// end

			return answer;
        }
    }
}

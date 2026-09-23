namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            if (a == 0 || b == 0 || c == 0)
            {
                answer = false;
            }
            else if ( (a > 0 && b > 0 && c > 0) || (a < 0 &&  b < 0 && c < 0) )
            {
                answer = true;
            }

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            if ((b != 0 && a % b == 0) || (a != 0 && b % a == 0))
            {
                answer = true;
            }

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            if ( (Math.Pow(a, 2) == b) || (Math.Pow(a, 3) == b) || (Math.Pow(b,2) == a) || (Math.Pow(b, 2) == a))
            {
                answer = true;
            }

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            answer = Math.Pow(f, 2) - 4 * d * g;

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            if (x <= -1)
            {
                answer = 1;
            }
            else if (-1 < x && x <= 1)
            {
                answer = -x;
            }
            else
            {
                answer = -1;
            }

            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            double diag = Math.Sqrt(squareS) * Math.Sqrt(2);
            double diam = Math.Sqrt(circleS / Math.PI) * 2;
            if (diam >= diag)
            {  
                answer = true; 
            }
            return answer;
        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;
            
            if (s) 
            {
                if (t)
                {
                    answer = 6;
                }
                else 
                {
                    if (f)
                    {
                        answer = 10;
                    }
                    else
                    {
                        answer = 2;
                    }
                }
            }
            else
            {
                if (t)
                {
                    answer = 3;
                }
                else
                {
                    if (f)
                    {
                        answer = 5;
                    }
                    else
                    {
                        answer = 1;
                    }
                }
            }

            return answer;
        }
        public bool Task8(int year, int pupils, int salary)
        {
            bool answer = false;
            const int bank = 10000;
            int b = bank;
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                answer = false;
            }
            else
            {
                double a = pupils / 7.0;
                double auror = Math.Ceiling(a);
                b -= (int)auror * salary + pupils * 5;
                if (b >= 0)
                {
                    answer = true;
                }
            }

            return answer;
        }
    }
}

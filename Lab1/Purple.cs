namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            if (a > 0 && b > 0 && c > 0)
            {
                answer = true;
            }
            else if (a < 0 && b < 0 && c < 0)
            {
                answer = true;
            }
            else if (a == 0 && b == 0 && c == 0)
            {
                answer = true;
            }

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            if (b != 0 && a % b == 0)
            {
                 
                answer = true;
            }
            else if (a != 0 && b % a == 0)
            {
                answer = true;
            }

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            if ((a == b * b) || (a == b * b * b))
            {
                answer = true;
            }
            else if ((b == a * a) || (b == a * a * a))
            {
                answer = true;
            }

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            answer = (f * f) - (4 * d * g);

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            if ((x >= -1) && (x <= 1))
            {
                answer = -x;
            }
            else
            {
                answer = x > 1 ? -1 : 1;
                
            }

            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            double d = (Math.Sqrt(circleS / Math.PI))*2;
            double diag = Math.Sqrt(squareS)*Math.Sqrt(2);
            if (d >= diag)
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
                        answer=10;
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

            if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
            {
                answer=false;
            }
            else
            {
                int aurora = pupils % 7 == 0 ? pupils / 7 : (pupils / 7) + 1;
                int merch = pupils * 5;
                int zp_aurora = aurora*salary;
                if (zp_aurora + merch > bank)
                {
                    answer=false;
                }
                else
                {
                    answer=true;
                }
            }

            return answer;
        }
    }
}

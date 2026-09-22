namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            if ((Math.Sign(a) == Math.Sign(b)) && (Math.Sign(b) == Math.Sign(c)))
            {
                answer = true;
            }

            return answer;
        }

        public bool Task2(int a, int b)
        {
            bool answer = false;



            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            if ((Math.Pow(a, 2) == b) || (Math.Pow(b, 2) == a) || (Math.Pow(a, 3) == b) || (Math.Pow(b, 3) == a))
            {
                answer = true;
            }

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            answer = Math.Pow(f, 2) - (4 * d * g);

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            if (x <= -1)
            {
                answer = 1;
            }
            if (-1 < x && x <= 1)
            {
                answer = -1 * x;
            }
            if (x > 1)
            {
                answer = -1;
            }

            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            answer = squareS * 1.57 <= circleS;

            return answer;
        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;

            if (s == true)
            {
                if (t == true)
                {
                    answer = 6;
                }
                else
                {
                    if (f == true)
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
                if (t == true)
                {
                    answer = 3;
                }
                else
                {
                    if (f == true)
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
            int aurora;
            if (pupils % 7 == 0)
            {
                aurora = pupils / 7;
            }
            else
            {
                aurora = pupils / 7+1;
            }
            
            int auroraS = aurora*salary;
            
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                answer = false;
            }
            else
            {
                if ((bank >= auroraS + 5 * pupils) && (pupils <= 7*aurora))
                {
                    answer = true;
                }
            }
            

            return answer;
        }
    }
}

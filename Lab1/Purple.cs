namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;
            if (Math.Sign(a) == Math.Sign(b) && Math.Sign(b) == Math.Sign(c))
                {
                    answer = true;
                }
            else
            {
                answer = false;
            }
            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;
            if (a == 0 ^ b == 0)
            {
                answer = true;
            }

            if (a == 0 && b == 0)
            {
                answer = false;
            }
            if (a != 0 && b != 0)
            {
                if ((b / a == b / Convert.ToDouble(a)) || (a / b == a / Convert.ToDouble(b)))
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }
            return answer;
            

        }
        public bool Task3(int a, int b)
        {
            bool answer = false;
            answer = (a * a == b) || (a * a * a == b) || (b * b == a) || (b * b * b == a);
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
                    return answer;
                }

                if (-1 < x && x <= 1)
                {
                    answer = x*-1;
                    return answer;
                }

                if (x > 1)
                {
                    answer = -1 ;
                    return answer;
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
            string check00 = Convert.ToString(year)[^2..];
            if (check00 == "00")
            {
                if (Convert.ToDouble(year) % 400 != 0)
                {
                    answer = Math.Ceiling(Convert.ToDouble(pupils) / 7) * salary + (pupils * 5) <= bank;
                }
            }
            else
            {
                if ((Convert.ToDouble(year) % 4 != 0))
                {
                    answer = Math.Ceiling(Convert.ToDouble(pupils) / 7) * salary + (pupils * 5) <= bank;
                }
            }
            return answer;
        }
    }
}

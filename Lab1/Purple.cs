namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            if (a > 0 && b > 0 && c > 0 || a < 0 && b < 0 && c < 0)
            {
                answer = true;
            }
            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            if (a != 0)
            {
                if (b % a == 0)
                {
                    answer = true;
                }
            } if (b != 0)
            {
                if (a % b == 0)
                {
                    answer = true;
                }
            }
            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;
            if (Math.Pow(a, 2) == b || Math.Pow(b, 2) == a)
            {
                answer = true;
            }
            if (Math.Pow(a, 3) == b || Math.Pow(b, 3) == a)
            {
                answer = true;
            }

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;
            // dx^2 + fx + g
            answer = Math.Pow(f, 2) - 4 * d * g;

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;
            if (x <= -1)
            {
                answer = 1;
            } else if (x > -1 && x <= 1)
            {
                answer = -x;
            } else
            {
                answer = -1;
            }

            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;
            double side = Math.Sqrt(squareS);
            double diag = Math.Sqrt(Math.Pow(side, 2) + Math.Pow(side, 2));
            double radius = Math.Sqrt(circleS / Math.PI);
            if (diag <= radius * 2)
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
                } else
                {
                    if (f)
                    {
                        answer = 10;
                    } else
                    {
                        answer = 2;
                    }
                }
            } else
            {
                if (t)
                {
                    answer = 3;
                } else
                {
                    if (f)
                    {
                        answer = 5;
                    } else
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

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                answer = false;
            } else
            {
                double aurors = Math.Ceiling(Convert.ToDouble(pupils) / 7);
                double salary_aurors = aurors * salary;
                int pupils_salary = pupils * 5;
                if (salary_aurors + pupils_salary <= 10_000)
                {
                    answer = true;
                }
            }

            return answer;
        }
    }
}
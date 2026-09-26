namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            double modul = Math.Abs(d);
            if (modul >= 1)
                answer = true;
            else
                answer = false;

            // end

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            double summ = d + f;
            double srednee = (summ / 2.0);
            if (srednee > 0)
                answer = true;
            else
                answer = false;

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            double summ = a + b;

            double sredn = ((Math.Abs(a) + Math.Abs(b)) / 2.0);
            if (summ > sredn)
                answer = true;
            else
            {
                answer = false;
            }


            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            double max2 = a;
            if (b > max2)
                max2 = b;
            if (c > max2)
                max2 = c;
            answer = (int)max2;

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            if (Math.Abs(x) > 1)
                answer = 0;
            else
                answer = x * x - 1;

            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            if (y >= 0)
            {
                if (x < 0)
                {
                    if (y <= 1 + x)

                        answer = true;
                    else
                        answer = false;
                }
                else
                {
                    if (y <= 1 - x)
                        answer = true;
                    else
                        answer = false;
                }
            }
            else
                answer = false;
                    
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            if (n < 0)
                answer = false;
            else
                if (n % 2 == 0)
                    answer = false;



            
            // end

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            if (X >= 7)
            {
                int Tea = (X + 1) / 2;
                int vsego = Tea * Y;

                if (vsego >= 240 && vsego <= 360)
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }
            else
            {
                answer = false;
            }

            // end

            return answer;
        }
    }
}

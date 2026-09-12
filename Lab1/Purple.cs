using System.Net.NetworkInformation;

namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            // code here
            if ( a > 0 && b > 0 && c > 0)
            {
                answer = true;
            }
            if ( a < 0 && b < 0 && c < 0)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            // code here
            if (b != 0)
            {
                if (a % b == 0)
                {
                    answer = true;
                }
            }
            if ( a != 0 )
            {
                if (b % a == 0)
                {
                    answer = true;
                }
            }
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (a == Math.Pow(b,2) || a == Math.Pow(b,3) || b == Math.Pow(a,2) || b == Math.Pow(a,3))
            {
                answer = true;
            }
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            answer = Math.Pow(f,2) - 4*d*g;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1)
            {
                answer = 1;
            }
            if (x > 1)
            {
                answer = -1;
            }
            if (x > -1 && x <= 1)
            {
                answer = -x;
            }
            // end

            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            // code here
            var d_v_Kvadrate = circleS * 4 / Math.PI;
            var d_kvadratika = Math.Pow(squareS, 0.5) * Math.Pow(2, 0.5);
            if (d_kvadratika <= Math.Pow(d_v_Kvadrate, 0.5))
            {
                answer= true;
            }
            // end
            return answer;
        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;

            // code here
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
            // end

            return answer;
        }
        public bool Task8(int year, int pupils, int salary)
        {
            bool answer = false;
            const int bank = 10000;

            // code here
            if (year % 4 != 0 || (year % 100 == 0 && year % 400 != 0))
            {
                if (pupils % 7 == 0)
                {
                    var autors = pupils / 7;
                    var itog = autors*salary + pupils*5;
                    if (bank >= itog)
                    {
                        answer = true;
                    }
                }
                else
                {
                    var autors = (pupils / 7) + 1;
                    var itog = autors*salary + pupils*5;
                    if (bank >= itog)
                    {
                        answer = true;
                    }

                }
            }
            // end

            return answer;
        }
    }
}

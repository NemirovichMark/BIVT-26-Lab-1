using System;

namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            // code here
            if (a*b>0 && a*c>0)
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
            if (a*b == 0 || a % b == 0 || b % a == 0)
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
            if (Math.Pow(a, 2) == b || Math.Pow(a, 3) == b || Math.Pow(b, 2) == a || Math.Pow(b, 3) == a) 
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
            answer = Math.Pow(f, 2) - 4 * d * g;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x<=-1)
            {
                answer = 1;
            }else if (x>1)
            {
                answer = -1;
            }
            else
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
            if (Math.Sqrt(2*squareS)<=2*Math.Sqrt(circleS/Math.PI)) 
            {
                answer = true;
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
                else if (f)
                {
                    answer = -1;
                }
                else
                {
                    answer = 2;
                }
            }
            else if (t)
            {
                answer = 3;
            }
            else if (f)
            {
                answer = 5;
            }
            else
            {
                answer = 1;
            }
                // end

                return answer;
        }
        public bool Task8(int year, int pupils, int salary)
        {
            bool answer = false;
            const int bank = 10000;

            // code here
            int avr = pupils / 7;
            if (pupils % 7 != 0)
            {
                avr+=1;
            }
            int spendings = avr * salary;
            spendings+= pupils*5;
            bool yearcheck=(year%400==0)||(year % 4 == 0 && year % 100 != 0);
            if (!yearcheck)
            {
                answer = spendings < bank;
            }
            // end

            return answer;
        }
    }
}
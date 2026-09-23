using System.ComponentModel.Design;

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
            else if (a == 0 && b == 0 && c == 0)
            {
                answer = true;
            }
            else if (a < 0 && b < 0 && c < 0)

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

            if (b * b == a || a * a == b)
            {
                answer = true;
            }
            else if (b * b * b == a || a * a * a == b)
            {
                answer = true;
            }

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            double D = (f * f) - (4 * d * g);

            answer = D;

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            if (x <= -1)
            {
                answer = 1;
            }
            else if (x > -1 && x <= 1)
            {
                answer = -x;
            }
            else if (x > 1)
            {
                answer = -1;
            }

            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            double s = Math.Sqrt(squareS);
            double d = Math.Sqrt((circleS * 4) / (Math.PI));

            double diagonale = Math.Sqrt(s * s + s * s);

            if (diagonale <= d)
            {
                answer = true;
            }
            
            
            

            return answer;
        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;

            if (s == true && t == true)
            {
                answer = 6;
            }
            else if (s == true && t == false && f == true)
            {
                answer = 10;
                
            }
            else if (s == true && t == false && f == false)
            {
                answer = 2;
            }

            else if (s == false && t == true)
            {
                answer = 3;
            }
            else if (s == false && t == false && f == true)
            {
                answer = 5;
            }
            else if (s == false && t == false && f == false)
            {
                answer = 1;
            }
                
            return answer;
        }
        public bool Task8(int year, int pupils, int salary)
        {
            bool answer = false;
            const int bank = 10000;
            int aurora = (pupils + 6) / 7;
            int auroraS = aurora * salary;
            int merch = pupils * 5;
            int total = merch + auroraS;

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                answer = false;
            }
            else if (bank >= total)
            {
                answer = true;
            }

            return answer;
        }
    }
}
using Microsoft.VisualBasic;
using System.IO.Pipes;

namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if (a * b > 0)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            if (Math.Abs(d % 1)>0)
            {
                answer = true;
                Console.WriteLine(d % 1);
            }
            return answer;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
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
            return answer;
            // end
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;
            double answer2 = 0;
            double dd = Math.Abs(d);
            double ff = Math.Abs(f);
            double gg = Math.Abs(g);
            // code here
            if (answer < dd)
            {
                answer = dd;
                answer2 = d;
            }
            if (answer < ff)
            {
                answer = ff;
                answer2 = f;
            }
            if (answer < gg)
            {
                answer = gg;
                answer2 = g;
            }
            return answer2;
            // end
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1)
            {
                answer = 0;
            }
            else if(-1<=x && x <= 0)
            {
                answer = x + 1;
            }
            else
            {
                answer = 1;
            }
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double circleSide = 2*Math.Sqrt(circleS / 3.14);
            double squareSide = Math.Sqrt(squareS);
            Console.WriteLine(circleSide.ToString() + squareSide.ToString());
            if (squareSide >= circleSide)
            {
                answer = true;
            }
            return answer;
            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here
            if (Math.Abs(d) < Math.Abs(f))
            {
                if (d > 0)
                {
                    answer = -1;
                }
            }
            else
            {
                if (f > 0)
                {
                    answer = 1;
                }
            }
            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;


            // code here
            int mingold = 100;
            if (mingold > a)
            {
                mingold = a;
            }
            if (mingold > b)
            {
                mingold = b;
            }
            if(mingold > c)
            {
                mingold = c;
            }
            int gold = a / 2 + b / 2 + c / 2;
            if (mingold != 0)
            {
                if (gold % 3 == 0 && gold / 3 <= mingold)
                {
                    answer = true;
                }
                if (gold % 3 == 2 && gold / 3 + 1 <= mingold)
                {

                    answer = true;
                }
            }
            Console.WriteLine("gold " + gold + " mingold " + mingold);
            // end
            return answer;
        }
    }
}
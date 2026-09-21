using System;

namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if ((a > 0) & (b > 0)) answer = true;
            if ((a < 0) & (b < 0)) answer = true;
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            if (Math.Abs(d - Math.Truncate(d)) > 0.0001) answer = true;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (a % b == 0 & b != 0) answer = true;
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            double d_a = System.Math.Abs(d);
            double f_a = System.Math.Abs(f);
            double g_a = System.Math.Abs(g);

            if (d_a >= f_a & d_a >= g_a) answer = d;else if (f_a >= d_a & f_a >= g_a) answer = f; else answer = g;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (-1 < x & x <= 0) answer = (x + 1); else answer = 1;
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            if (Math.Sqrt(circleS / Math.PI) * 2 == Math.Sqrt(squareS)) answer = true;
            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here
            if (Math.Abs(d) < Math.Abs(f)) { if (d > 0) answer = -1; } else { if (f > 0) answer = 1; }; 
            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int S = a / 2 + b / 2 + c / 2;
            int minCap = Math.Min(a, Math.Min(b, c));
         

            if (minCap >= 1)
            {
                if (S % 3 == 0)
                {
                    int x = S / 3;
                    if (x >= 1 && x <= minCap)
                        answer = true;
                }
                else if (S % 3 == 2)
                {
                    int x = (S + 1) / 3;
                    if (x >= 1 && x <= minCap)
                        answer = true;
                }
            }
            // end

            return answer;
        }
 
    }
}

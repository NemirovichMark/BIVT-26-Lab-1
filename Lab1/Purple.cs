using static System.Math;

namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            // code here
            if ((a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c < 0)) answer = true;
            // end

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            // code here
            if (a != 0){
                if (b % a == 0) answer = true;
            }
            if (b != 0){
                if (a % b == 0) answer = true;
            }
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (a == Pow(b, 2) || a == Pow(b, 3)) answer = true;
            if (b == Pow(a, 2) || b == Pow(a, 3)) answer = true;
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            answer = f * f - 4 * d * g;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1) answer = 1;
            else if (x <= 1) answer = -x;
            else answer = -1;
            // end

            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            // code here
            if (Sqrt(squareS) * Sqrt(2) / 2 <= Sqrt(circleS / PI)) answer = true;
            // end

            return answer;
        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;

            // code here
            if (s) {
                if (t) {
                    answer = 6;
                }
                else {
                    if (f){
                        answer = 10;
                    }
                    else {
                        answer = 2;
                    }
                }
            }
            else {
                if (t){
                    answer = 3;
                }
                else {
                    if (f){
                        answer = 5;
                    }
                    else {
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
            bool l = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            if (!l){
                int a = (pupils + 6) / 7;
                int total = a * salary + pupils * 5;

                if (total <= bank) {
                    answer = true;
                }
            }
            // end

            return answer;
        }
    }
}

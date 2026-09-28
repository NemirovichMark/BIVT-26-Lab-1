namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            // code here
            if (a > 0 && b > 0 && c > 0)
                answer = true;

            if (a < 0 && b < 0 && c < 0)
                answer = true;

            // end

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            // code here
            if (b != 0 && a % b == 0)
                answer = true;

            if (a != 0 && b % a == 0)
                answer = true;

            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (a * a == b || b * b == a)
                answer = true;

            if (a * a * a == b || b * b * b == a)
                answer = true;

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
            if (x <= -1)
                answer = 1;
            else if (x <= 1)
                answer = -x;
            else
                answer = -1;

            // end

            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            // code here
            if (Math.Pow(squareS, 0.5) * Math.Pow(2, 0.5) <= Math.Pow(circleS / Math.PI, 0.5) * 2)
                answer = true;

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
                    answer = 6;
                else if (f)
                    answer = 10;
                else
                    answer = 2;
            }
                else
            {
                if (t)
                    answer = 3;
                else if (f)
                    answer = 5;
                else
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
            int a = pupils / 7;

            if (pupils % 7 != 0)
                a = a + 1;

            int money = a * salary + pupils * 5;

            bool leap = false;

            if (year % 400 == 0)
                leap = true;
            else if (year % 100 == 0)
                leap = false;
            else if (year % 4 == 0)
                leap = true;

            if (money <= bank && leap == false)
                answer = true;
            
            // end

            return answer;
        }
    }
}

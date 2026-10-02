namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            answer = Math.Abs(d) >= 1;
            // end

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            answer = (d + f) / 2 > 0;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            answer = (a + b) > Math.Abs(a + b)/2;
            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            if (a > b && a > c)
                answer = a;
            else if (b > a && b > c)
                answer = b;
            else
                answer = c;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x) > 1)
                answer = 0;
            else if (Math.Abs(x) <= 1)
                answer = x * x - 1;
            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            double newv = 0;
            if (x < 0)
                newv = x + 1;
            else
                newv = 1 - x;

            if (y >= 0 && y <= newv)
                answer = true;
            else
                answer = false;

            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
            if (n < 0)
                answer = false;
            else
            {
                if (n % 2 == 0)
                    answer = false;
            }

            // end

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here
            if (X<7)
                answer = false; // тк ей нужно минимум 7 дней для сдвига времени проснутия с 14 до 7
            else
            { int cups = (X + 1) / 2; // через день
                int shift = cups * Y; //сдвиг временеи засыпания
                if (shift >= 240 && shift <= 360) // от 7 до 9 часов в минутах -180(прибавление изза чая)
                    answer = true;
            }
            // end

            return answer;
        }
    }
}

namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;
            Console.WriteLine($"{a}, {b}, {c}");

            // code here
            if ((a > 0 && b > 0 && c > 0) || (a == 0 && b == 0 && c == 0) || (a < 0 && b < 0 && c < 0))

                answer = true;

            // end

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            // code here

            if ((a == 0) && (b == 0))
                answer = false;
            if ((b != 0) && (a % b == 0))
                answer = true;
            if ((a != 0) && (b % a == 0))
                answer = true;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (Math.Pow(a, 2) == b || (Math.Pow(a, 3) == b))
                answer = true;
            if (Math.Pow(b, 2) == a || (Math.Pow(b, 3) == a))
                answer = true;
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            double dis = Math.Pow(f, 2) - (4 * d * g);
            answer = dis;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1)
                answer = 1;
            if ((x <= 1) && (x > -1))
                answer = -x;
            if (x > 1)
                answer = -1;
            // end

            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            // code here
            double dcr = 2 * Math.Sqrt(circleS / Math.PI);
            double dsq = Math.Sqrt(2 * squareS);
            if (dcr > dsq)
                answer = true;
            // end

            return answer;
        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;

            // code here
            if (s == true)
                if (t == true)
                    answer = 6;
                else
                    if (f == true)
                        answer = 10;
                    else
                        answer = 2;
            else
                if (t == true)
                    answer = 3;
                else
                    if (f == true)
                        answer = 5;
                    else
                        answer = 1;


            // end

            return answer;
        }
        public bool Task8(int year, int pupils, int salary)
        {
            bool answer = false;
            const int bank = 10000;

            // code here
            bool leap = false;
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                leap = true;

            int avrs = (int)Math.Ceiling((double)pupils / 7);

            if ((bank - (pupils * 5) - (avrs * salary) >= 0) && (leap == false))
                answer = true;

            // end

            return answer;
        }
    }
}

namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            if (Math.Abs(d) >= 1)
            {
                answer = true;
            }

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            if ((d + f) / 2 > 0)
            {
                answer = true;
            }

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            if (a + b > (Math.Abs(a) + Math.Abs(b)) * 0.5)
            {
                answer = true;
            }

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            answer = new[] {a, b, c}.Max();
            // там на пару коммитов назад я решил это через вложенные матх.макс'ы, я решил загуглить решение попрактичней
            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            if (Math.Abs(x) > 1)
            {
                answer = 0;
            }
            else
            {
                answer = x * x - 1;
            }
            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            if (y >= 0 && y <= 1 - Math.Abs(x))
            {
                answer = true;
            }

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            if (n < 0)
            {
                answer = false;
            }
            else
            {
                if (n % 2 == 0)
                {
                    answer = false;
                }
            }

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            if (X < 7)
            {
                return false;
            }
            else
            {
                float t = ((X + 1) * Y / 2) / 60.0f;
                if (6 >= t && t >= 4)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
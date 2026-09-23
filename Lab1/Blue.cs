
namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;
           
            if ((a != 0 && b != 0) && (Math.Abs(a) == a) && (Math.Abs(b) == b)) answer = true;
            else if ((Math.Abs(a) != a) && (Math.Abs(b) != b)) answer = true;
           
            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            if (Math.Abs(d - (int) d) >= 0.0001) answer = true;

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            if ((b != 0) && (a % b == 0)) answer = true;

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = d;

            if (Math.Abs(f) > Math.Abs(answer)) answer = f;
            if (Math.Abs(g) > Math.Abs(answer)) answer = g;

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            if (x <= -1) answer = 0;
            else if ((x <= -1) || (x <= 0)) answer = x + 1;
            else answer = 1;

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;
            if ((2 * Math.Sqrt(circleS / Math.PI)) <= Math.Sqrt(squareS)) answer = true;

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            if (Math.Abs(d) < Math.Abs(f) && d > 0) answer = -1;
            else if (Math.Abs(d) >= Math.Abs(f) && f > 0) answer = 1;

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            int sum = a/2 + b/2 + c/2;
            if (sum % 3 == 0 && sum / 3 >= 1 && sum / 3 <= a && sum / 3 <= b && sum / 3 <= c) answer = true;
            else if ((sum + 1) % 3 == 0 && (sum + 1) / 3 >= 1 && (sum + 1) / 3 <= a && (sum + 1) / 3 <= b && (sum + 1) / 3 <= c) answer = true;
            return answer;
        }
    }
}

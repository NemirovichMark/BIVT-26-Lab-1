namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = (a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c < 0);

            // code here

            // end

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = (a != 0 && b % a == 0) || (b != 0 && a % b == 0);

            // code here

            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = (a * a == b) || (b * b == a) || (a * a * a == b) || (b * b * b == a);

            // code here

            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = f*f-4*d*g;


            return answer;
        }
        public double Task5(double x)
        {
            //double answer = 0;
            if (x <= -1) return 1;
            if (x <= 1) return -x;

            // code here

            // end

            return -1;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;
            double side = Math.Sqrt(squareS);
            double radius = Math.Sqrt(circleS / Math.PI);


            // code here

            // end
            answer = side * Math.Sqrt(2) / 2 <= radius;
            return answer;
        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public bool Task8(int year, int pupils, int salary)
        {
            bool answer = false;
            const int bank = 10000;

            // code here
            
            // end

            return answer;
        }
    }
}

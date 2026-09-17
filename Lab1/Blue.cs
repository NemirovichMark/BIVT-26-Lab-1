namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if ((a > 0 && b > 0) || (a < 0 && b < 0))
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
            if (d % 1 != 0)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (b!=0 && a % b == 0)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            // Console.Write("Число d");
            // double d = double.Parse(Console.ReadLine())
            // Console.Write("Число f");
            // double f = double.Parse(Console.ReadLine())
            // Console.Write("Число g");
            // double g = double.Parse(Console.ReadLine())
            if ((Math.Abs(d)>Math.Abs(f) )&&( Math.Abs(d)>Math.Abs(g)));
            {
                Console.Write(d);
            }
            if ((Math.Abs(f)>Math.Abs(d) )&&( Math.Abs(f)>Math.Abs(g)));
            {
                Console.Write(f);
            }
            if ((Math.Abs(g)>Math.Abs(f) )&&( Math.Abs(g)>Math.Abs(d)));
            {
                Console.Write(g);
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here

            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here

            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            
            // end

            return answer;
        }
    }
}

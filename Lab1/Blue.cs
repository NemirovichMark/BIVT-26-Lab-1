namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if (a > 0 && b > 0 || a < 0 & b < 0)
            {  answer = true; }
               
        
                
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            if (d % 1 > 0 || d % 1 < 0)
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
            if (a % b == 0)
            {
                answer = true;
             }
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code 
            if (Math.Abs(d) > Math.Abs(f) && (Math.Abs(d) > Math.Abs(g)))
            { 
                answer = d; 
             }
            else if ((Math.Abs(g) > Math.Abs(f) && (Math.Abs(g) > Math.Abs(d))))
            { 
                answer = g;
             }
            else if ((Math.Abs(f) > Math.Abs(g) && (Math.Abs(f) > Math.Abs(d))))
            {
                answer = f;
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1)
            {  answer = 0; }
            else if (x <= 0)
            { answer = x + 1; }
            else if (x > 0)
            { answer = 1; }
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            if (circleS / 3.1415 <= squareS / 4)
            {  answer = true; }
            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here
            if (Math.Abs(d) < Math.Abs(f))
            { if (d > 0)
                    answer = -1;
            }
            else
            { if (f > 0)
                answer = 1; }
            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int s = a / 2 + b / 2 + c / 2;
            int s2 = a / 2 + b / 2 + (c / 2 + 1);
            if (s % 3 == 0 && a >= s / 3 && b >= s / 3 && c >= s / 3 && s / 3 >= 1)
            { answer = true; }
            else if (s2 % 3 == 0 && a >= s2 / 3 && b >= s2 / 3 && c >= s2 / 3 && s2 / 2 >= 1)
            { answer = true; }
            // end

            return answer;
        }
    }
}

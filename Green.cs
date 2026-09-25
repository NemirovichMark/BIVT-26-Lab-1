using System.ComponentModel.Design;

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

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            answer = (a + b) > Math.Abs(a) + Math.Abs(b) / 2;
            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            int d = Math.Max(a, b);
            answer = Math.Max(d, c);
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x) > 1)
            {
                answer = 0;
            }
            else
            { 
                answer = x * x - 1;
            }
            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            double exam;
            if (x < 0)
                exam = x + 1;
            else
                exam = 1 - x;
            if (exam >=y & y>=0)
                return true;
            else
                return answer;
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
            if (n <= 0)
                answer = false;
            else
                if (n % 2 == 0)
                    answer = false;
                else
                    return answer;
            // end

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here
            int tea = (X + 1) / 2;
            if(X>=7 & Y*tea>=240&Y*tea<=360)
                answer= true;   

            // end

            return answer;
        }
    }
}
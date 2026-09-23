namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if (a * b > 0)
                answer = true;
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            return Math.Abs(d - Math.Floor(d)) >= 0.0001;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;
            // code here
            if (b != 0 && a % b == 0)
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
            answer = Math.Max(Math.Abs(d), Math.Max(Math.Abs(f), Math.Abs(g)));
            if (answer == Math.Abs(d))
                answer = d;
            else if (answer == Math.Abs(f))
                answer = f;
            else 
                answer = g;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x<=-1)
                answer = 0;
            else if (-1<x && x<=0)
                answer = x+1;
            else
                answer = 1;
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            
            double r = Math.Sqrt(circleS / Math.PI);
            
            double kv = Math.Sqrt(squareS);
            if(r*2<=kv)
                answer = true;
            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here
            if(Math.Abs(d)< Math.Abs(f))
            {
                if (d > 0)
                    answer = -1;
            }
            else
            {
                if (f > 0)
                    answer = 1;
            }
            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int meshok1 = a / 2 + b / 2 + c / 2;
            if (meshok1%3==0)
            {
                int r = meshok1 / 3;
                if (r >= 1)
                    answer = true;
            }
            else
            {
                int meshok2 = meshok1 + 1;
                if (meshok2 % 3 == 0)
                {
                    int r2=meshok2 / 3;
                    if(r2>= 1)
                        answer=true;
                }
            }
            // end

            return answer;
        }
    }
}
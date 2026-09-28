using System.Security.Cryptography;

namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            

            if (Math.Abs(d) >= 1.0)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
                    
            

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

           
            double sr = (d + f) / 2;
            if (sr>0) {
                answer = true;
            }
            else { answer = false; }
              

                return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            
            int a1 = Math.Abs(a);
            int b1 = Math.Abs(b);
            int summ = a + b;
            int summ1 = (a1 + b1)/2;
            if (summ > summ1) { answer = true; }
            else { answer = false; }
                

                return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;
            if (a > b)
            {
                answer = a;}
            else { answer = b; }

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;
            if (Math.Abs(x) > 1.0)
            {
                answer = 0;}
            else { double x1 = Math.Pow(x,2);
                answer = x1 - 1;
            }
            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;
            if (y > 0.0 && y <= 1.0 && Math.Abs(x) <= 1.0 && y <= 1 - Math.Abs(x))
            {
                answer = true;}
            else
            {
                answer = false;
            }

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            if (n <0) { answer = false; }
            else {
                if (n % 2 == 0)
                {
                    answer = false;
                }
            } 

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            
            if (X < 7) return false;
            int teaCount = 4;
            int shift = teaCount * Y;
            int initialSleep = 4 * 60 + 1440; 
            int finalSleep = initialSleep - shift;
            int minSleep = 22 * 60; 
            int maxSleep = 24 * 60;
            answer = finalSleep >= minSleep && finalSleep <= maxSleep;

            return answer;
        }
    }
}

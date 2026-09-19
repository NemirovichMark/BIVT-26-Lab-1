using System.Net.Http.Headers;
using System.Xml.Serialization;

namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;
            if (Math.Abs(d) >= 1) answer= true;

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            if(((d+f)/2)>0) answer= true;

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

             if(a+b>(Math.Abs(a)+Math.Abs(b))/2) answer = true;

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;
            int[] arr = {a, b, c};

            answer = arr.Max();
          

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            switch (Math.Abs(x)){
                case <=1:
                    answer = x * x - 1;
                    break;
                case > 1:
                    answer = 0;
                    break;

                }
            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;
            if (y >= 0 && ((x < 0 && y <= 1 + x) || (x >= 0 && y <= 1 - x))) { answer = true; }
            

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            if (n < 0) { answer = false; }
            else if (n % 2 == 0) { answer = false; }

          

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            if (X >= 7 && ((X + 1) / 2) * Y >= 240 && ((X + 1) / 2) * Y <= 360) { answer = true; }

            // end

            return answer;
        }
    }
}

using System;

namespace Lab1
{
    public class White
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            answer = d > 0;
            // end

            return answer;
        }

        public bool Task2(int n)
        {
            bool answer = false;

            // code here
            answer = n % 2 == 0;
            // end

            return answer;
        }

        public int Task3(int a, int b)
        {
            int answer = 0;

            // code here
            answer = a > b ? a : b;
            // end

            return answer;
        }

        public double Task4(double d, double f)
        {
            double answer = 0;

            // code here
            if (Math.Abs(d) <= Math.Abs(f))
            {
                answer = d;
            }
            else
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
            if (Math.Abs(x) > 1)
            {
                answer = 1;
            }
            else
            {
                answer = x;
            }
            // end

            return answer;
        }

        public bool Task6(double x, double y, double r)
        {
            bool answer = false;

            // code here
            answer = Math.Abs(x * x + y * y - r * r) <= 1e-4; //1e-4 is 10^-4
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = false;

            // code here
            int s = n * n;
            if (s - n > 2 * n)
            {
                if (n % 2 == 0)
                {
                    answer = true;
                }
            }
            // end

            return answer;
        }

        public bool Task8(double L, int T, int M)
        {
            bool answer = false;

            // code here
            // 1. Time: Ship speed = 10 mph, max time = 3 hours. Max distance = 30
            bool timeOk = L <= 30;

            // 2. Landmarks: At least 5 total (Trees + Mountains)
            bool landmarksOk = (T + M) >= 5;

            // 3. Mountains must be strictly even
            bool mountainsOk = M % 2 == 0;

            answer = timeOk && landmarksOk && mountainsOk;
            // end

            return answer;
        }
    }
}
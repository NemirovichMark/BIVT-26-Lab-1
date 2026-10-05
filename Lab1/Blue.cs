namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
           if (a > 0 && b > 0 || a < 0 && b < 0)
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
            if (d <0)
            {
                d =-d;
            }
            if (d % 1 >= 0.0001)
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
            if (b !=0)
            {
                if (a % b == 0)
                {
                    answer = true;
                }
            }
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            if (d* d > f * f && d * d > g * g)
            {
                answer = d;
            }
            if (f * f > d * d && f * f > g * g)
            {
                answer = f;
            }
            if (g * g > d * d && g * g > f * f)
            {
                answer = g;
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1)
            {
                answer = 0;
            }
            if (x > -1 && x <= 0)
            {
                answer = x + 1;
            }
            if (x > 0)
            {
                answer = 1;
            }
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            var diam_sq = Math.Sqrt(squareS);
            var rad_cir = Math.Sqrt(circleS / Math.PI);
            var diam_cir = rad_cir * 2;
            if (diam_sq >= diam_cir) 
            { 
                answer = true; 
            }
            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here
            if (d * d < f * f)
            {
                if (d > 0)
                {
                    answer = -1;
                }
                else
                {
                    return answer;
                }
            }
            else
            {
                if (f > 0)
                {
                    answer = 1;
                }
                else
                {
                    return answer;
                }
            }
            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int a1 = a / 2;
            int b1 = b / 2;
            int c1 = c / 2;
            int sum = a1 + b1 + c1;
            if (sum % 3 == 0)
            {
                int f = sum / 3;
                if (f >= 1 && f <= Math.Min(a, Math.Min(b, c)))
                { answer = true; }
            }
            sum++;
            if (sum % 3 == 0)
            {
                int f = sum / 3;
                if (f >= 1 && f <= Math.Min(a, Math.Min(b, c)))
                { answer = true; }
            }
            // end

            return answer;
        }
    }
}

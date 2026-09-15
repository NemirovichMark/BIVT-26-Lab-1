namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if ((a > 0 && b > 0) || (a < 0 && b <0)) {
                    answer = true;
            }
            else {
                    answer = false;
            }
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            int a = (int)d;
            if (Math.Abs(d - Math.Round(d)) >= 0.0001)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if ((b != 0) && (a%b== 0)) { 
             
                answer = true;
            }
            else {
                answer = false;
            }
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            double max = d;
            if (Math.Abs(f) > Math.Abs(max))
            {
                max = f;
            }
            if (Math.Abs(g) > Math.Abs(max))
            {
                max = g;

            }
            answer = max;
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
            if ((x <= 0) && (x > -1))
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
            if (Math.Sqrt(squareS) >= (Math.Sqrt(circleS / Math.PI)*2))
            {
                answer = true;

            }
            else
            {
                answer = false;
            }
            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here
            if (Math.Abs(d) < Math.Abs(f))
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
            int monetok_a = a/2;
            int monetok_b = b/2;
            int monetok_c = c/2;
            int sum = monetok_a + monetok_b + monetok_c;
            if ((sum % 3==0) && (sum / 3 >= 1) && (sum / 3 <= a) && (sum / 3 <= b) && (sum / 3 <= c))
            {
                answer = true;
            }
            else
            {
                sum += 1;
                 if ((sum % 3 == 0) && (sum / 3 >= 1) && (sum / 3 <= a) && (sum / 3 <= b) && (sum / 3 <= c))
                {
                    answer = true;
                }
            }
                // end

                return answer;
        }
    }
}

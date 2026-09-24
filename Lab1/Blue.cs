namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if (a > 0 && b > 0)
            { answer = true; }
            else if (a < 0 && b < 0)
            { answer = true; }
            else
            { answer = false; }
                // end

                return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            d=Math.Abs(d);
            double c = d*100000;
            if (c % 100000 > 0)
            { answer = true; }
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (b != 0)
            {
                if (a % b == 0) 
                { answer = true; }
            }

            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            double da = Math.Abs(d);
            double fa = Math.Abs(f);
            double ga = Math.Abs(g);

            if (da>=fa && da>=ga)
            { answer = d; }

            if(fa >= da && fa >= ga)
            { answer = f; }

            if(ga >= fa && ga >= da)
            { answer = g; }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x<=-1)
            {  answer = 0; }
            if (x>-1 && x<= 0)
            { answer = x+1; }
            if (x>0)
            { answer = 1; }
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double Sc = Math.Sqrt(circleS / 3.14);
            double Ss = Math.Sqrt(squareS);
            if (Sc*2<=Ss)
            { answer = true; }
            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here
            if (Math.Abs(d)<Math.Abs(f))
            {
                if (d>0)
                { answer = -1; }
                else
                { return answer; }
            }
            else
            {
                if (f>0)
                { answer = 1; }
                else
                { return answer; }
            }
            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int[] money = {a,b,c};
            int za = a / 2;
            int zb = b / 2;
            int zc = c / 2;
            int mn = money.Min();
            if (za + zb + zc >= 3 && (za+zb+zc)%3==0 && mn >= (za + zb + zc) / 3)
            { answer=true; }
            else if ((za+zb+zc)%3==2 && mn >= (za + zb + zc+1)/3)
            { answer=true; }

            // end

            return answer;
        }
    }
}


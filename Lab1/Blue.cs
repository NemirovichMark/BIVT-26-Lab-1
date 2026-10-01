namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if (a*b>0)
            {
                answer = true;
            }
            else
            {
                answer=false;
            }
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            
            if (((Math.Abs(d)-(Math.Abs(d)-Math.Abs(d)%1)))>=0.00001) answer = true;
            else answer = false;
            
            
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (b!=0 && a%b==0){answer=true;}
            else{answer=false;}
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            double maxi = Math.Max(Math.Abs(d), Math.Max(Math.Abs(f), Math.Abs(g)));
            if (Math.Abs(d) == maxi)
            {
                answer = d;
            }
            else if (Math.Abs(f) == maxi)
            {
                answer = f;
            }
            else answer = g;

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1) answer = 0;
            else if (x>-1 && x <= 0) answer = x + 1;
            else answer = 1;
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double side =Math.Sqrt(squareS);
            double radius = Math.Sqrt((circleS / Math.PI));
            if (side >= 2 * radius)
            {
                answer = true;
            }
            else answer = false;

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
           }
           else
           {
               if (f > 0)
               {
                   answer = 1;
               }
           }
           // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int n = 0; 
            int summa = a /2 + b/2 + c/2;
            if (summa % 3 == 0)
            {
                n = summa / 3;
            }
            else if ((summa + 1) % 3 == 0)
            {
                n = (summa+1) / 3;
            }
            else answer = false;
            if (n>=1 && n <= (Math.Min(a, Math.Min(b, c)))) answer = true;
            else answer = false;
                
            // end

            return answer;
        }
    }
}

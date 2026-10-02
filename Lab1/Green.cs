//я что то поменял
using System.ComponentModel.Design;

namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            if (d>=1 || d<=-1)
            { answer = true; }
            else
            { answer = false; }
            // end

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            double cz = (d + f) / 2;
            if (cz > 0)
            { answer = true; }

            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            double smab = a + b;
            double cz = (Math.Abs(a) + Math.Abs(b))/2;
            if (smab > cz)
            {  answer = true; }
            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            int mxab =Math.Max(a, b);
            answer = Math.Max(c, mxab);
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if(Math.Abs(x)>1)
            { answer = 0; }
            else
            { answer = (x*x-1); }
                // end

                return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            answer = (y >= 0) && (y <= 1 - Math.Abs(x));
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
            answer = true;
            if (n < 0)
            { answer = false; }
            else
            {
                if (n % 2 == 0)
                {
                    answer = false;
                }
            }
            // end

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here
            int tobed = 4 * 60;
            int wakeup = 14 * 60;
            int targwakeup = 7 * 60;
            int minsleep = 7 * 60;
            int maxsleep = 9 * 60;

            bool target = false;

            for(int day = 1; day <= X; day++)
            {
                if(!target)
                { 
                    wakeup -= 60;
                    if(wakeup<=targwakeup)
                    {
                        wakeup = targwakeup;
                        target = true;
                    }
                }
                if((day-1)%2==0)
                {
                    tobed -= Y;
                    if(tobed<0)
                    {
                        tobed += 1440;
                    }
                }
                int duration;
                if (tobed>wakeup)
                {
                    duration = (1440 - tobed) + wakeup;
                }
                else
                {
                    duration = wakeup - tobed;
                }
                if (day==X&&target&&duration>=minsleep&&duration<=maxsleep)
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }
            // end

            return answer;
        }
    }
}

namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            answer = Math.Abs(d) >= 1;

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;
            
            
            double avg = (d + f) / 2;
            answer = avg > 0;

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            double sum = a + b;
            double avgAbs = (Math.Abs(a) + Math.Abs(b)) / 2.0;
            answer = sum > avgAbs;

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            answer = a;
            if (b > answer) answer = b;
            if (c > answer) answer = c;

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            if (Math.Abs(x) > 1.0)
                answer = 0;
            else
                answer = x * x - 1;

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            answer = y >= 0 && y <= 1 - Math.Abs(x);
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
            if (n < 0)
                answer = false;
            else if (n % 2 == 0)
                answer = false;
            // end

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            int wakeMinutes = 14 * 60 - X * 60;
            if (wakeMinutes < 7 * 60) wakeMinutes = 7 * 60;

            
            int teaDays = (X + 1) / 2;
            int sleepMinutes = 4 * 60 - teaDays * Y;
            while (sleepMinutes < 0) sleepMinutes += 24 * 60;
            
            int duration;
            if (wakeMinutes >= sleepMinutes)
                duration = wakeMinutes - sleepMinutes;
            else
                duration = (24 * 60 - sleepMinutes) + wakeMinutes;

            
            answer = (wakeMinutes == 7 * 60) &&
                     (duration >= 7 * 60 && duration <= 9 * 60);

            return answer;
        }
    }
}

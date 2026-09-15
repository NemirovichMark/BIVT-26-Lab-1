    namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            double absoluted = Math.Abs(d);
            Console.WriteLine(absoluted);
            if (absoluted >= 1) { answer = true; }
            // end

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            double avg = (d + f) / 2.0;
            if (avg > 0.0) { answer = true; }
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            int sum = (a + b);
            double avg = (Math.Abs(a) + Math.Abs(b) / 2.0);
            if (sum > avg) { answer = true; }
            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            if (a > b && a > c) { answer = a; }
            if (b > a && b > c) { answer = b; }
            if (c > a && c > b) { answer = c; }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double y;
            if (Math.Abs(x) > 1) { y = 0; }
            else { y = x * x - 1; }
            return y;
            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            if (y <= 1 - Math.Abs(x) && y >= 0) { answer = true; }
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
            if (n < 0) { answer = false; }
            else if (n % 2 == 0) { answer = false; }

            // end

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here
            int wakeup = 14 * 60;
            int sleep = 4 * 60;
            for (int day = 1; day <= X; day++)
            {
                if (wakeup > 7 * 60) wakeup -= 60;

                if (day % 2 == 1)
                    sleep -= Y;
            }
            int sleepDuration = (wakeup - sleep);
            if (sleepDuration < 0) { sleepDuration += 24 * 60; }
            if (wakeup == 7 * 60 && sleepDuration >= 7 * 60 && sleepDuration <= 9 * 60) { answer = true; }
            // end

            return answer;
        }
    }
}
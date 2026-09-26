namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here

            double D = Math.Abs(d);

            if (D >= 1) { answer = true; } else { answer = false; }

            // end

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            double arif = (d + f) / 2;

            if (arif > 0) { answer = true; } else { answer = false; }

            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            int A = Math.Abs(a);
            int B = Math.Abs(b);
            double srzn = (a + b) / 2.0;

            if ((a + b) > srzn) { answer = true; } else { answer = false; }


            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            int step1 = Math.Max(a, b);
            answer = Math.Max(step1, c);

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double X = Math.Abs(x);
            if (X <= 1) { answer = (x * x) - 1; } else { answer = 0; }

            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            double z = 1 - Math.Abs(x);
            if ((x <= 1) && (x >= -1) && (y >= 0) && (y <= z)) { answer = true; } else { answer = false; }

            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
            if (n < 0) { answer = false; }
            else if (n % 2 == 0) { answer = false; }
            else { answer = true; }


            // end

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here
            if (X < 7) { answer = false; }
            int teas = (X + 1) / 2;
            int minutes = teas * Y;
            int t = 240 - minutes;
            if (t >= -120 && t <= 0) { answer = true; }

            // end

            return answer;
        }
    }
}
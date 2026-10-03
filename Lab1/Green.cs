namespace Lab1;

public class Green
{
    public bool Task1(double d)
    {
        bool answer = false;

        // code here
        if ((d >= 1) || (d <= -1))
        {
            answer = true;
        }
        else
        {
            answer = false;
        }
        Console.WriteLine(answer);
        return answer;
    }
    // end
    public bool Task2(double d, double f)
    {
        bool answer = false;

        // code here
        double avg = (d + f) / 2;
        answer = (avg > 0);
        return answer;
        // end
    }
    public bool Task3(int a, int b)
    {
        bool answer = false;

        // code here 
        {
            double sum = a + b;
            double avg = (Math.Abs(a) + Math.Abs(b));
            if (avg > sum)
            {
                answer = true;
            }
            else;
            return answer;
            // end
        }
    }
    public int Task4(int a, int b, int c)
    {
        int answer = 0;
        // code here
        int max = a;
        if (b > a) max = b;
        if (c > max) max = c;
        answer = max;
        return answer;
        // end
    }
    public double Task5(double x)
    {
        double answer = 0;

        // code here
        x = Convert.ToDouble(Console.ReadLine());
        if (Math.Abs(x) > 1)
        {
            answer = 0;
        }
        else
        {
            answer = x * x - 1;
        }
        return answer;
        // end
    }
    public bool Task6(double x, double y)
    {
        bool answer = false;

        // code here                                                        
        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());
        if (y >= 0 && y <= 1 - Math.Abs(x))
        {
            answer = true;
        }
        else;
        return answer;    // end
    }

    public bool Task7(int n)
    {
        // code here
        bool answer = true;
        if (n < 0)
        {
            answer = false;
        }
        else if (n % 2 == 0)
        {
            answer = false;
        }
        return answer;
        // end
    }
    public bool Task8(int X, int Y)
    {
        // code here
        int sleep = 4 * 60;
        int wake = 14 * 60;
        int targetWake = 7 * 60;

        for (int day = 1; day <= X; day++)
        {
            wake = wake - 60;
            if (day % 2 == 1)
            sleep = sleep - Y;

        }
        int duration = wake - sleep;

        if (duration <= 0)
            duration += 24 * 60;

        bool answer = (wake <= targetWake) && (duration >= 7 * 60) && (duration <= 9 * 60);
        return answer;

        // end
    }
}

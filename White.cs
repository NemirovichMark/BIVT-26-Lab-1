namespace Lab1
{
    public class White
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            using System;
class Program {
    static bool IsPositive(double d) 
    { return d > 0;
    }
static void Main()
{
    double d = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine(IsPositive(d));
}
}

            // end

            return answer;
        }
        public bool Task2(int n)
        {
            bool answer = false;

            // code here
            using System;
class Program { static bool IsEven(int n) { return n % 2 == 0; }
static void Main()
{
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(IsEven(n));
}
}

            // end

            return answer;
        }
        public int Task3(int a, int b)
        {
            int answer = 0;

            // code here
            using System;
class Program { static int MaxNumber(int a, int b) { if (a > b) return a; else return b; }
static void Main()
{
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(MaxNumber(a, b));
}
}

            // end

            return answer;
        }
        public double Task4(double d, double f)
        {
            double answer = 0;

            // code here
using System;
class Program { static double MinAbs(double d, double f)
{ 
    if (Math.Abs(d) < Math.Abs(f)) return d; else return f; }
static void Main()
{
    double d = Convert.ToDouble(Console.ReadLine());
    double f = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine(MinAbs(d, f));
}
}
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
using System;
class Program { static double FunctionY(double x) 
{ 
    if (Math.Abs(x) > 1) 
        return 1; 
    else
        return x;
}
static void Main()
{
    double x = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine(FunctionY(x));
}
}
            // end

            return answer;
        }
        public bool Task6(double x, double y, double r)
        {
            bool answer = false;

            // code here
using System;
class Program 
{
    static bool IsOnCircle(double x, double y, double r)
    { 
        return Math.Abs(x * x + y * y - r * r) <= 1e-4; 
    }
static void Main()
{
    double x = Convert.ToDouble(Console.ReadLine());
    double y = Convert.ToDouble(Console.ReadLine());
    double r = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine(IsOnCircle(x, y, r));
}
}
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = false;

            // code here
using System;
class Program { static void Main() { int n = Convert.ToInt32(Console.ReadLine());
int s = n * n;

    bool answer = false;

    if (s - n > 2 * n)
    {
        if (n % 2 == 0)
        {
            answer = true;
        }
    }

    Console.WriteLine(answer);
}
}
            // end

            return answer;
        }
        public bool Task8(double L, int T, int M)
        {
            bool answer = false;

            // code here
using System;
class Program 
{
    static bool IsSuitable(double L, int T, int M)
{
        if (L <= 30 && T + M >= 5 && M % 2 == 0) 
            return true;
        else
            return false; 
    }
static void Main()
{
    double L = Convert.ToDouble(Console.ReadLine());
    int T = Convert.ToInt32(Console.ReadLine());
    int M = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(IsSuitable(L, T, M));
}
}
            // end

            return answer;
        }
    }
}
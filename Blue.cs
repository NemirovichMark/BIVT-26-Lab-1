namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;
            string a1 = Console.ReadLine();
            string b1 = Console.ReadLine();
            int a = int.Parse(a1);
            int b = int.Parse(b1);
            if (a > 0 && b > 0){
                answer = true;
            }
            if (a > 0 && b > 0){
                answer = true;
            }
            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;
            string a1 = Console.ReadLine();
            int a = int.Parse(a1);
            if (a%1 != 0){
                answer = true;
            }
            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;
            string a1 = Console.ReadLine();
            string b1 = Console.ReadLine();
            int a = int.Parse(a1);
            int b = int.Parse(b1);
            if (a%b == 0){
                answer = true;
            }
            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;
            string d1 = Console.ReadLine();
            string f1 = Console.ReadLine();
            string g1 = Console.ReadLine();
            double d = double.Parse(d1);
            double f = double.Parse(d1);
            double g = double.Parse(d1);
            if (d > f > g){
                answer = d
            }
            if (d > g > f){
                answer = d
            }
            if (f > d > g){
                answer = f
            }
            if (f > g > d){
                answer = f
            }
            if (g > f > d){
                answer = g
            }
            if (g > d > f){
                answer = g
            }
            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;
            string x1 = Console.ReadLine()
            int x = int.Parse(x1)
            if (x <= -1){
                answer = 0
            }
            if (-1 < x && x <= 0){
                answer = x + 1;
            }
            if (x > 0){
                answer = 1;
            }
            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;
            string x1 = Console.ReadLines();
            string x2 = Console.ReadLines();
            circleS = double.Parse(x1);
            squareS = double.Parse(x2);
            if (circleS/3.14 <= squareS/4){
                answer = true
            }
            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;
            string d1 = Console.ReadLine();
            string f1 = Console.ReadLine();
            double d = double.Parse(d1);
            double f = double.Parse(f1);
            if (d > f){
                if (d > 0){
                    answer = -1;
                }
            }
            if (f > d){
                if (f > 0){
                    answer = 1;
                }
            }
            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = true;
            string a1 = Console.ReadLine();
            string b1 = Console.ReadLine();
            string c1 = Console.ReadLine();
            double a = double.Parse(a1);
            double b = double.Parse(b1);
            double c = double.Parse(c1);
            if ((a+b+c)/3 > a){
                answer = false;
            }
            if ((a+b+c)/3 > b){
                answer = false;
            }
            if ((a+b+c)/3 > c){
                answer = false;
            }
            if ((a+b+c)/3%1 != 0){
                if ((a+b+c+1)/3%1 != 0){
                    answer = false
                }
            }
            return answer;
        }
    }
}
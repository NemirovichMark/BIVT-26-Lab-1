namespace Lab1
{
    public class Program
    {
        public static void Main()
        {
            Green green = new Green();
            Console.WriteLine(green.Task1(-0.2));
            Console.WriteLine(green.Task2(2, 3));
            Console.WriteLine(green.Task3(2, 1));
            Console.WriteLine(green.Task4(2, 3, 4));
            Console.WriteLine(green.Task5(0.5));
            Console.WriteLine(green.Task6(2.5, 1.89));
            Console.WriteLine(green.Task7(5));
            Console.WriteLine(green.Task8(30, 12));
        }
    }
}

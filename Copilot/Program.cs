namespace Copilot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int sum = Add(5, 7);
            Console.WriteLine($"The sum of 5 and 7 is: {sum}");

            Console.ReadLine();
            sum = Add(10, 20);
            Console.WriteLine($"The sum of 10 and 20 is: {sum}");

            Console.ReadLine();
        }

        // Add two numbers
        public static int Add(int a, int b)
        {
            return a + b;
        }

    }
}
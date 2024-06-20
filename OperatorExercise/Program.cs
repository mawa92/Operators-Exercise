namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = a + b;

            int diff = a - b;

            int product = a * b;

            int quotient = a / b;

            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");
            Console.WriteLine($"{a}+{b} is {sum}");
            Console.WriteLine($"{a}-{b} is {diff}");
            Console.WriteLine($"{a}*{b} is {product}");

            Console.WriteLine("Please enter the radius of your ciricle");
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);
            Console.WriteLine(AreaOfCircle(radius));

        }

        private static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);

            return area;
        }
    }
}

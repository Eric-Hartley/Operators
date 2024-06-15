namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?"); // output
            var name = Console.ReadLine(); // input

            Console.Write($"Hello, {name}. "); // output


            Console.WriteLine("What is your favorite color?"); // output
            var FavColor = Console.ReadLine(); // input

            Console.WriteLine("What is your favorite animal?"); // output
            var FavAnimal = Console.ReadLine(); // input

            Console.WriteLine("What is your favorite band?"); // output
            var FavBand = Console.ReadLine(); // input

        }
    }
}
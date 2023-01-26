namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Number guessing game
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("try to guess my fave number");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine($"{userInput} is too low");
            }
            else if(userInput < favNumber)
            {
                Console.WriteLine($"{userInput} is too high");
            }
            else(userInput > favNumber)
            {
                Console.WriteLine($"{userInput} you guessed it yayyyy");
            }
        }
    }
}

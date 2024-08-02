namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            var r = new Random(666);

            var favNumber = r.Next(1, 1000);

            Console.WriteLine("Try to guess my favorite number!");

            var userInput = int.Parse(Console.ReadLine());

            if (favNumber == userInput)
            {
                Console.WriteLine("Correct!");
            }
            else 
            {
                Console.WriteLine("Incorrect");
            }

            if (favNumber == userInput)
            {
                Console.WriteLine("Correct!");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too High!");
            }
            else
            {
                Console.WriteLine("Too Low!");
            }


        }
    }
}

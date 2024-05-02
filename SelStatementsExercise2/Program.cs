
namespace SelectionStatementsExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject");

            var subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("Math is a hard subject");
                    break;
                case "Science":
                    Console.WriteLine("Science is a fun subject!");
                    break;
                case "History":
                    Console.WriteLine("Is a boring subject");
                    break;
                case "English":
                    Console.WriteLine("English is an interesing subject");
                    break;
                case "Coding":
                    Console.WriteLine("Coding is the best subject in the world");
                    break;
                default:
                    Console.WriteLine($"Oh wow, i havent taken that subject before {subject} sounds fun");
                    break;
            }
        }
    }
}


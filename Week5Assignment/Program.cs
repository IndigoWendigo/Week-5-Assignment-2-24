using System.ComponentModel;

namespace Week5Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProblemOne();
            ProblemThree();
            ProblemFour();
        }

        static void ProblemOne()
        {
            int x = 1;
            int counter = 0;
            while(x != 101)
            {
                x++;
                if(x % 3 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine("Between 1 and 100, there are " + counter + " numbers that are perfectly divisible by three.");
        }

        static void ProblemThree()
        {
            Console.WriteLine("Please enter a number between 1 and 10 and get the factorial of it");

            int a = int.Parse(Console.ReadLine());

            int result = 1;

            for (int i = a; i > 0; i--)
            {
                result = result * i;
            }
            Console.WriteLine(result);
        }

        static void ProblemFour()
        {
            var randomNumber = new Random().Next(10);
            for (var i = 1; i <= 4; i++)
            {
                Console.Write("Guess my number between 1 and 10: ");
                var input = Convert.ToInt32(Console.ReadLine());
                if (input == randomNumber)
                {
                    Console.WriteLine("You won");
                    break;
                }
                else if (i == 4)
                {
                    Console.WriteLine("You lost");
                }
            }
            Console.ReadLine();
        }

        
    }
}
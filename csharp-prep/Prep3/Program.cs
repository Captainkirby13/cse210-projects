using System;

class Program
{
    static void Main(string[] args)
    {
        //  Part 1 and 2 
        // Console.Write("What is the magic number? ");
        // int number = int.Parse(Console.ReadLine());
        
        
        // This is fopr part 3 
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);

        int guess = -1;

        while (guess != number) {
            
            Console.Write("What is your guess for the number? ");
            guess = int.Parse(Console.ReadLine());

            if (number > guess)
            {
                Console.WriteLine("guess again Hint: it's Higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("guess again Hint: it's Lower");
            }
            else
            {
                Console.WriteLine("You have guessed it, great job!");
            }

        }                    
    }
}

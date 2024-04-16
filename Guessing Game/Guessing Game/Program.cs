internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;
        int min = 1;
        int max = 100;
        int guess = 0;
        int number = 0;
        int guesses = 0;
        String answer = "";

        while(playAgain) {
            number = random.Next(min, max + 1);

            while(number != guess) {
                Console.WriteLine("Guess a number betwen 1 - 100");
                guess = Convert.ToInt32(Console.ReadLine());

                if(guess > number) {
                    Console.WriteLine("Number too high");    
                }
                else if(guess < number) {
                    Console.WriteLine("Number too low");
                }
                guesses++;
            }
            Console.WriteLine("Number is " + number);
            Console.WriteLine("You WIN!");
            Console.WriteLine("Guesses: " + guesses);

            Console.WriteLine();
            Console.WriteLine("Do you want to play again?");
            Console.WriteLine("Press: Y for (yes) and N for (no)");
            answer = Console.ReadLine();

            if(answer.Equals("y")) {
                playAgain = true;
            }else {
                playAgain = false;
            }
        }

        
    }
}
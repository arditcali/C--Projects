using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;

        while(playAgain) {
            String player = "";
            String comp = "";

            while(player != "rock" && player != "paper" && player != "scissors") {
                Console.WriteLine("Enter: rock / paper / scissors");
                player = Console.ReadLine();   
            }

            switch(random.Next(1, 4)) {
                case 1: comp = "rock";
                    break;
                case 2: comp = "paper";
                    break;
                case 3: comp = "scissors";
                    break;        
            }

            Console.WriteLine("Player: " + player);
            Console.WriteLine("Computer: " + comp);

            switch(player) {
                case "rock":
                    if(comp == "rock") {
                        Console.WriteLine("Its a draw");
                    }
                    else if(comp == "paper") {
                        Console.WriteLine("You lose");
                    }else {
                        Console.WriteLine("You win");
                    }
                    break;
                case "paper":
                    if(comp == "rock") {
                        Console.WriteLine("You win");
                    }
                    else if(comp == "paper") {
                        Console.WriteLine("Its a draw");
                    }else {
                        Console.WriteLine("You lose");
                    }
                    break;
                case "scissors":
                    if(comp == "rock") {
                        Console.WriteLine("You lose");
                    }
                    else if(comp == "paper") {
                        Console.WriteLine("You win");
                    }else {
                        Console.WriteLine("Its a draw");
                    }
                    break;        
            }

            Console.WriteLine("Do you want to play again?");
            Console.WriteLine("y for (Yes) and n for (NO)");

            String answer = Console.ReadLine();

            if(answer.Equals("y")) {
                playAgain = true;
            }else {
                playAgain = false; 
            }

        }
    }
}
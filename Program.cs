

string inputPlayer, inputRobot;
int randNumber;

bool playAgain = true;

while (playAgain)
{
    int playerScore = 0;
    int robotScore = 0;

    while (playerScore < 3 && robotScore < 3)
    {
        
        Console.WriteLine("Choose you object (rock, paper, scissors): ");
        inputPlayer = Console.ReadLine();

        Random rand = new Random();
        randNumber = rand.Next(1, 4);

        switch (randNumber)
        {
            case 1:
                inputRobot = "rock";
                Console.WriteLine($"Robot choose: {inputRobot}");
                if (inputRobot == inputPlayer)
                {
                    Console.WriteLine("Draw! \n\n");
                }
                else if (inputPlayer == "paper")
                {
                    Console.WriteLine("You won! \n\n");
                    playerScore++;
                }
                else if (inputPlayer == "scissors")
                {
                    Console.WriteLine("Robot won! \n\n");
                    robotScore++;
                }
                break;
            case 2:
                inputRobot = "paper";
                Console.WriteLine($"Robot choose: {inputRobot}");
                if (inputRobot == inputPlayer)
                {
                    Console.WriteLine("Draw! \n\n");
                }
                else if (inputPlayer == "rock")
                {
                    Console.WriteLine("Robot won! \n\n");
                    robotScore++;
                }
                else if (inputPlayer == "scissors")
                {
                    Console.WriteLine("You won! \n\n");
                    playerScore++;
                }
                break;
            case 3:
                inputRobot = "scissors";
                Console.WriteLine($"Robot choose: {inputRobot}");
                if (inputRobot == inputPlayer)
                {
                    Console.WriteLine("Draw! \n\n");
                }
                else if (inputPlayer == "paper")
                {
                    Console.WriteLine("Robot won! \n\n");
                    robotScore++;
                }
                else if (inputPlayer == "rock")
                {
                    Console.WriteLine("you won! \n\n");
                    playerScore++;
                }
                break;
            default:
                Console.WriteLine("Invalid entry! \n\n");
                break;
        }

        if (playerScore == 3)
        {
            Console.WriteLine("Player has won");
        }
        else if (robotScore == 3)
        {
            Console.WriteLine("Robot has won");
        }

        
    }
    Console.WriteLine($"Player score: {playerScore} - Robot score: {robotScore}");

    Console.WriteLine("Do you want paly again?(y/n)");
    string loop = Console.ReadLine();
    if (loop == "y")
    {
        playAgain = true;
        Console.Clear();
    }
    else if (loop == "n")
    {
        playAgain = false;
    }
}
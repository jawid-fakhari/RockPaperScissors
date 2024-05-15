using Spectre.Console;

string inputRobot;
int randNumber;

int playerScore = 0;
int robotScore = 0;



bool playAgain = true;

while (true)
{

    SelectionPrompt<string> selectionPrompts = new SelectionPrompt<string>()
               .Title($"Player Score: {playerScore} - Robot Score: {robotScore}")
               .AddChoices("Rock", "Paper", "Scissors");

    string playerSelection = AnsiConsole.Prompt(selectionPrompts);
    AnsiConsole.Write($"You choose: {playerSelection} - ");

    Console.Clear();

    Random rand = new Random();
    randNumber = rand.Next(1, 4);

    switch (randNumber)
    {
        case 1:
            inputRobot = "Rock";
            Console.WriteLine($"Robot choose: {inputRobot}");

            if (inputRobot == playerSelection)
            {
                Console.WriteLine("Draw! \n\n");
            }
            else if (playerSelection == "Paper")
            {
                Console.WriteLine("You won! \n\n");
                playerScore++;
            }
            else if (playerSelection == "Scissors")
            {
                Console.WriteLine("Robot won! \n\n");
                robotScore++;
            }
            break;
        case 2:
            inputRobot = "Paper";
            Console.WriteLine($"Robot choose: {inputRobot}");
            if (inputRobot == playerSelection)
            {
                Console.WriteLine("Draw! \n\n");
            }
            else if (playerSelection == "Rock")
            {
                Console.WriteLine("Robot won! \n\n");
                robotScore++;
            }
            else if (playerSelection == "Scissors")
            {
                Console.WriteLine("You won! \n\n");
                playerScore++;
            }
            break;
        case 3:
            inputRobot = "Scissors";
            Console.WriteLine($"Robot choose: {inputRobot}");
            if (inputRobot == playerSelection)
            {
                Console.WriteLine("Draw! \n\n");
            }
            else if (playerSelection == "Paper")
            {
                Console.WriteLine("Robot won! \n\n");
                robotScore++;
            }
            else if (playerSelection == "Rock")
            {
                Console.WriteLine("you won! \n\n");
                playerScore++;
            }
            break;
        default:
            Console.WriteLine("Invalid entry! \n\n");
            break;
    }
}
//while (playAgain)
//{
//    int playerScore = 0;
//    int robotScore = 0;

//    while (playerScore < 3 && robotScore < 3)
//    {

//        Console.WriteLine("Choose you object (Rock, Paper, Scissors): ");
//        playerSelection = Console.ReadLine();

//        Random rand = new Random();
//        randNumber = rand.Next(1, 4);

//        switch (randNumber)
//        {
//            case 1:
//                inputRobot = "Rock";
//                Console.WriteLine($"Robot choose: {inputRobot}");
//                if (inputRobot == playerSelection)
//                {
//                    Console.WriteLine("Draw! \n\n");
//                }
//                else if (playerSelection == "Paper")
//                {
//                    Console.WriteLine("You won! \n\n");
//                    playerScore++;
//                }
//                else if (playerSelection == "Scissors")
//                {
//                    Console.WriteLine("Robot won! \n\n");
//                    robotScore++;
//                }
//                break;
//            case 2:
//                inputRobot = "Paper";
//                Console.WriteLine($"Robot choose: {inputRobot}");
//                if (inputRobot == playerSelection)
//                {
//                    Console.WriteLine("Draw! \n\n");
//                }
//                else if (playerSelection == "Rock")
//                {
//                    Console.WriteLine("Robot won! \n\n");
//                    robotScore++;
//                }
//                else if (playerSelection == "Scissors")
//                {
//                    Console.WriteLine("You won! \n\n");
//                    playerScore++;
//                }
//                break;
//            case 3:
//                inputRobot = "Scissors";
//                Console.WriteLine($"Robot choose: {inputRobot}");
//                if (inputRobot == playerSelection)
//                {
//                    Console.WriteLine("Draw! \n\n");
//                }
//                else if (playerSelection == "Paper")
//                {
//                    Console.WriteLine("Robot won! \n\n");
//                    robotScore++;
//                }
//                else if (playerSelection == "Rock")
//                {
//                    Console.WriteLine("you won! \n\n");
//                    playerScore++;
//                }
//                break;
//            default:
//                Console.WriteLine("Invalid entry! \n\n");
//                break;
//        }

//        if (playerScore == 3)
//        {
//            Console.WriteLine("Player has won");
//        }
//        else if (robotScore == 3)
//        {
//            Console.WriteLine("Robot has won");
//        }


//    }
//    Console.WriteLine($"Player score: {playerScore} - Robot score: {robotScore}");

//    Console.WriteLine("Do you want paly again?(y/n)");
//    string loop = Console.ReadLine();
//    if (loop == "y")
//    {
//        playAgain = true;
//        Console.Clear();
//    }
//    else if (loop == "n")
//    {
//        playAgain = false;
//    }
//}
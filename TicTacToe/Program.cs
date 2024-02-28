using System.ComponentModel;

namespace TicTacToe;
class Program
{

    //Board 2D array
    static string[,] board = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };

    static int turns = 0;


    static void Main(string[] args)
    {
        int player = 2; //Player one starts
        int input = 0;
        bool inputCorrect = true;


        do
        {

            if (player == 2)
            {
                player = 1;
                HandleXOrO(player, input);
            }
            else if (player == 1)
            {
                player = 2;
                HandleXOrO(player, input);
            }

            DisplayBoard();
            CheckWinner();

            do
            {
                Console.WriteLine("\nPlayer {0}: Take a turn", player);

                // In case of incorrect input
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Write a number you dosser");
                }

                if ((input == 1) && (board[0, 0] == "1"))
                    inputCorrect = true;

                else if ((input == 2) && (board[0, 1] == "2"))
                    inputCorrect = true;

                else if ((input == 3) && (board[0, 2] == "3"))
                    inputCorrect = true;

                else if ((input == 4) && (board[1, 0] == "4"))
                    inputCorrect = true;

                else if ((input == 5) && (board[1, 1] == "5"))
                    inputCorrect = true;

                else if ((input == 6) && (board[1, 2] == "6"))
                    inputCorrect = true;

                else if ((input == 7) && (board[2, 0] == "7"))
                    inputCorrect = true;

                else if ((input == 8) && (board[2, 1] == "8"))
                    inputCorrect = true;

                else if ((input == 9) && (board[2, 2] == "9"))
                    inputCorrect = true;

                else
                {
                    Console.WriteLine("Write a number within the range you dosser !");
                    inputCorrect = false;
                }
            } while (!inputCorrect);


        } while (true);

    }




    // Reset the Game
    static void ResetGame()
    {
        string[,] boardIntial = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
        board = boardIntial;
        DisplayBoard();
        turns = 0;
    }

    //Display Board
    static void DisplayBoard()
    {

        Console.Clear();
        Console.WriteLine("   |   |   ");
        Console.WriteLine(" {0} | {1} | {2}  ", board[0, 0], board[0, 1], board[0, 2]);
        Console.WriteLine("___|___|___");
        Console.WriteLine("   |   |   ");
        Console.WriteLine(" {0} | {1} | {2}  ", board[1, 0], board[1, 1], board[1, 2]);
        Console.WriteLine("___|___|___");
        Console.WriteLine("   |   |   ");
        Console.WriteLine(" {0} | {1} | {2}  ", board[2, 0], board[2, 1], board[2, 2]);
        turns++;
        Console.WriteLine("\n Turn {0}", turns);
    }




    static void CheckWinner()
    {





        // Horizontal and vertical win
        for (int i = 0; i < 3; i++)
        {
            //Diagonal win
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {

                if (board[0, 2] == "X")
                {
                    Console.WriteLine("Player 1 wins");


                }

                else
                {
                    Console.WriteLine("Player 2 wins");

                }

                Console.WriteLine("Press any key to reset the game");
                Console.ReadKey();
                ResetGame();
                break;

            }

            else if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {

                if (board[0, 0] == "X")
                {
                    Console.WriteLine("Player 1 wins");

                }

                else
                {
                    Console.WriteLine("Player 2 wins");

                }

                Console.WriteLine("Press any key to reset the game");
                Console.ReadKey();
                ResetGame();
                break;


            }

            else if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
            {
                if (board[i, 0] == "X")
                {
                    Console.WriteLine("Player 1 wins");

                }

                else
                {
                    Console.WriteLine("Player 2 wins");

                }

                Console.WriteLine("Press any key to reset the game");
                Console.ReadKey();
                ResetGame();
                break;
            }

            else if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
            {
                if (board[i, 0] == "X")
                {
                    Console.WriteLine("Player 1 wins");


                }

                else
                {
                    Console.WriteLine("Player 2 wins");

                }
                Console.WriteLine("Press any key to reset the game");
                Console.ReadKey();
                ResetGame();
                break;
            }

            else if (turns == 10)
            {
                Console.WriteLine("Draw, one of yous need to do better");
                Console.WriteLine("Press any key to reset the game");
                Console.ReadKey();
                ResetGame();
                break;
            }

        }


    }

    public static void HandleXOrO(int player, int input)
    {

        string playerSign = " ";


        if (player == 1)
        {
            playerSign = "X";
        }
        else if (player == 2)
        {
            playerSign = "O";
        }


        switch (input)
        {
            case 1: board[0, 0] = playerSign; break;
            case 2: board[0, 1] = playerSign; break;
            case 3: board[0, 2] = playerSign; break;
            case 4: board[1, 0] = playerSign; break;
            case 5: board[1, 1] = playerSign; break;
            case 6: board[1, 2] = playerSign; break;
            case 7: board[2, 0] = playerSign; break;
            case 8: board[2, 1] = playerSign; break;
            case 9: board[2, 2] = playerSign; break;
        }

    }

}






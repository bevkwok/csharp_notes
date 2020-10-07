using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] allNum = new string[,]
            {
                {"1","2","3"},
                {"4","5","6"},
                {"7","8","9"}
            };
            
            bool winner = false;

            System.Console.WriteLine(allNum[0, 0] + " | " + allNum[0, 1] + " | " + allNum[0, 2]);
            System.Console.WriteLine(allNum[1, 0] + " | " + allNum[1, 1] + " | " + allNum[1, 2]);
            System.Console.WriteLine(allNum[2, 0] + " | " + allNum[2, 1] + " | " + allNum[2, 2]);

            System.Console.WriteLine("Player 1: Choose your field");
            string player1choice = Console.ReadLine();

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(player1choice == allNum[i,j] && player1choice != "O" && player1choice != "X")
                    {
                        allNum[i,j] = "O";
                    }
                    else
                    {
                        System.Console.WriteLine("Invalid entry, please try again");
                    }
                }
                
            }

        }

    }
}

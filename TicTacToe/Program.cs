using System;

namespace TicTacToe
{
    class Program
    {
        static string[,] allNum = new string[,]
        {
            {"1","2","3"},
            {"4","5","6"},
            {"7","8","9"}
        };



        static int turns = 0;
        static void Main(string[] args)
        {
            int player = 2; // Player 1 starts
            int input = 0;
            bool inputCorrect = true;



            do
            {
                if (player == 2)
                {
                    player = 1;
                    EnterXorO("O", input);
                }
                else if(player == 1)
                {
                    player = 2;
                    EnterXorO("X", input);
                }

                SetField();

                //check winning condition
                string[] signs = {"X", "O"};

                foreach(string sign in signs)
                {
                    if(((allNum[0,0] == sign) && (allNum[0,1] == sign) && (allNum[0,2] == sign))
                    || (allNum[1,0] == sign) && (allNum[1,1] == sign) && (allNum[1,2] == sign)
                    || (allNum[2,0] == sign) && (allNum[2,1] == sign) && (allNum[2,2] == sign)
                    || (allNum[0,0] == sign) && (allNum[1,0] == sign) && (allNum[2,0] == sign)
                    || (allNum[0,1] == sign) && (allNum[1,1] == sign) && (allNum[2,1] == sign)
                    || (allNum[0,2] == sign) && (allNum[1,2] == sign) && (allNum[2,2] == sign)
                    || (allNum[0,0] == sign) && (allNum[1,1] == sign) && (allNum[2,2] == sign)
                    || (allNum[0,2] == sign) && (allNum[1,1] == sign) && (allNum[2,0] == sign)
                    )
                    {
                        if(sign == "X")
                        {
                            System.Console.WriteLine("Player 2 is our winner!");
                        }
                        else
                        {
                            System.Console.WriteLine("Player 1 is our winner!");
                        }
                        System.Console.WriteLine("Please press any key to reset the game");
                        Console.ReadKey();
                        ResetField();

                        break;
                    }
                    else if (turns == 10)
                    {
                        System.Console.WriteLine("\n Draw!");
                        System.Console.WriteLine("Please press any key to reset the game");
                        Console.ReadKey();
                        ResetField();
                    }
                }

                do
                {
                    System.Console.WriteLine("\nPlayer {0}: Choose your field! ", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        System.Console.WriteLine("Please enter a number!");
                    }   

                    //test if field is already taken
                    if((input == 1) && (allNum[0,0] == "1"))
                    {
                        inputCorrect = true;
                    }
                    else if((input == 2) && (allNum[0,1] == "2"))
                    {
                        inputCorrect = true;
                    }
                    else if((input == 3) && (allNum[0,2] == "3"))
                    {
                        inputCorrect = true;
                    }
                    else if((input == 4) && (allNum[1,0] == "4"))
                    {
                        inputCorrect = true;
                    }
                    else if((input == 5) && (allNum[1,1] == "5"))
                    {
                        inputCorrect = true;
                    }
                    else if((input == 6) && (allNum[1,2] == "6"))
                    {
                        inputCorrect = true;
                    }
                    else if((input == 7) && (allNum[2,0] == "7"))
                    {
                        inputCorrect = true;
                    }
                    else if((input == 8) && (allNum[2,1] == "8"))
                    {
                        inputCorrect = true;
                    }
                    else if((input == 9) && (allNum[2,2] == "9"))
                    {
                        inputCorrect = true;
                    }
                    else
                    {
                        System.Console.WriteLine("\n Incorrect input!");
                        inputCorrect = false;
                    }

                }while(!inputCorrect);

            }while(true);

        }

        public static void ResetField()
        {
            string[,] starting = new string[,]
            {
                {"1","2","3"},
                {"4","5","6"},
                {"7","8","9"}
            };
            allNum = starting;
            SetField();
            turns = 0;
        }

        public static void SetField()
        {
            Console.Clear();
            System.Console.WriteLine("   |   |   ");
            System.Console.WriteLine(" {0} | {1} | {2} ", allNum[0, 0], allNum[0, 1], allNum[0, 2]);
            System.Console.WriteLine("___|___|___");
            System.Console.WriteLine("   |   |   ");
            System.Console.WriteLine(" {0} | {1} | {2} ", allNum[1, 0], allNum[1, 1], allNum[1, 2]);
            System.Console.WriteLine("___|___|___");
            System.Console.WriteLine("   |   |   ");            
            System.Console.WriteLine(" {0} | {1} | {2} ", allNum[2, 0], allNum[2, 1], allNum[2, 2]);
            System.Console.WriteLine("___|___|___");
            System.Console.WriteLine("   |   |   ");
            turns++;
        }

        public static void EnterXorO(string Sign, int input)
        {

            switch (input)
            {
                case 1: allNum[0, 0] = Sign; break;
                case 2: allNum[0, 1] = Sign; break;
                case 3: allNum[0, 2] = Sign; break;
                case 4: allNum[1, 0] = Sign; break;
                case 5: allNum[1, 1] = Sign; break;
                case 6: allNum[1, 2] = Sign; break;
                case 7: allNum[2, 0] = Sign; break;
                case 8: allNum[2, 1] = Sign; break;
                case 9: allNum[2, 2] = Sign; break;
            }
        }

    }
}

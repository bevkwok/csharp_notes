using System;

namespace if_else
{
    class Program
    {
        // Challenge - If Statements 1
            static string username;
            static string password;

            static string loginUsername;
            static string loginPassword;
        static void Main(string[] args)
        {
            // Challenge - If Statements 1
            Register();
            Login();
            CheckScore(5, "Jim");
        }

        //Challenge - If Statements 1
        public static void Register()
        {
            System.Console.WriteLine("Please enter you username");
            username = Console.ReadLine();

            System.Console.WriteLine("Please enter your password");
            password = Console.ReadLine();
        }

        // Challenge - If Statements 1
        public static void Login()
        {
            System.Console.WriteLine("Login username:");
            loginUsername = Console.ReadLine();

            
            System.Console.WriteLine("Login password:");
            loginPassword = Console.ReadLine();

            if(loginUsername == username && loginPassword == password){
                System.Console.WriteLine("Loggin Sccessfully");
            } else {
                System.Console.WriteLine("Incorrect Username or Password. ");
            }
        }


        //Challenge - If Statements 2

        static int score;
        static int highscore = 10;
        static string highscorePlayer = "Tom";

        public static void CheckScore(int score, string playerName)
        {
            if(score >= highscore)
            {
                highscore = score;
                highscorePlayer = playerName;
                System.Console.WriteLine("New highscore is" + score + "from player" + playerName);
            } 
            else
            {
                System.Console.WriteLine("The old highscore of " + highscore + "could not be broken and is still held by " + highscorePlayer);
            }
        }

        //testing

    }
}

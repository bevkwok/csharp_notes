using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Challenge 1
            string friend1 = "Amy";
            string friend2 = "David";
            string friend3 = "Taylor";

            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);

            //Challenge 2 - User input
            System.Console.WriteLine("Enter the first number");
            string numOne = Console.ReadLine();
            int num1 = int.Parse(numOne);

            System.Console.WriteLine("Enter the second number");
            string numTwo = Console.ReadLine();
            int num2 = int.Parse(numTwo);

            AddNum(num1, num2);

            // try, catch and finally note
            try
            {
                AddNum(num1, num2);
            }
            catch (System.FormatException)
            {
                
                System.Console.WriteLine("Please enter number instead of letter");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Something went wrong");
            }
            finally
            {
                System.Console.WriteLine("This will run when the try and catch is done");
            }

        }

        //Challenge 1
        public static void GreetFriend(string friendName)
        {
            System.Console.WriteLine("Hi {0}, my friend!", friendName);
        }

        //Challenge 2 - User input
        public static void AddNum(int num1, int num2)
        {
            System.Console.WriteLine(num1 + num2);
        }
    }
}

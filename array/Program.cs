using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            // first way to initialize an array
            int[] array1 = new int[3];

            array1[0] = 1;
            array1[1] = 2;
            array1[2] = 3;

            //second way to initialize an array
            int[] array2 = {1, 2, 3};

            //third way to initialize an array
            int[] array3 = new int[] {1, 2, 3};

            System.Console.WriteLine("Please enter the first input");

            string input = Console.ReadLine();
            bool valid = false;
            string inputType = string.Empty;

            string[] inputOption = new string[] {
                "Press 1 for String",
                "Press 2 for integer",
                "Press 3 for Boolean"
            };

            foreach(string option in inputOption)
            {
                System.Console.WriteLine(option);
            }

            System.Console.WriteLine("Please enter the second input");

            string input2 = Console.ReadLine();

            int numOfInput2 = int.Parse(input2);


            switch(numOfInput2)
            {
                case 1:
                    System.Console.WriteLine("You have entered a value {0}", input);
                    valid = Isalphabe(input);
                    inputType = "String";
                    System.Console.WriteLine("");
                    break;
                case 2:
                    int stringToNum;
                    valid = int.TryParse(input, out stringToNum);
                    inputType = "Integer";
                    break;
                case 3:
                    bool stringToBool = false;
                    valid = bool.TryParse(input, out stringToBool);
                    inputType = "Boolean";
                    break;
                default:
                    System.Console.WriteLine("input value must be number 1, 2 or 3");
                    break;
            }

            System.Console.WriteLine("You have entered a value : {0}", input);
            if(valid)
            {
                System.Console.WriteLine("It is valid : {0}", inputType);
            }
            else
            {
                System.Console.WriteLine("It is an invalid : {0}", inputType);
            }
        }

        public static bool Isalphabe(string value)
        {
            foreach(char c in value)
            {
                if(!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

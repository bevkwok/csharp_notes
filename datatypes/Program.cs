using System;

namespace datatypes
{
    class Program
    {
        static void Main(string[] args)
        {

            // Challenge 1 – String and its methods

            string unknown;
            Console.Write("Please enter your name and press enter!");
            string input = Console.ReadLine();
            unknown = input;
            string nameUpperCase = String.Format("Upper case: {0}", unknown.ToUpper());
            unknown.ToUpper();
            Console.WriteLine(unknown.ToUpper());
            unknown.ToLower();
            Console.WriteLine(unknown.ToLower());
            unknown.Trim();
            Console.WriteLine(unknown.Trim());
            string subString = unknown.Substring(2);
            Console.WriteLine(subString);


            // Challenge 2 - String and its methods 

            Console.Write("Enter a string here: ");
            string input2 = Console.ReadLine();
            
            Console.Write("Enter the character to search: ");
            char charToSearch = Console.ReadLine()[0];

            int indexOfchar = input2.IndexOf(charToSearch);
            System.Console.WriteLine(indexOfchar);

            System.Console.WriteLine("Index of character {0} in string is {1}", charToSearch, indexOfchar);

            System.Console.WriteLine("Enter your first name");
            string firstName = Console.ReadLine();

            System.Console.WriteLine("Enter your last name");
            string lastName = Console.ReadLine();

            string fullName = string.Concat(firstName, " ", lastName);
            System.Console.WriteLine("Full Name: {0}", fullName);

            System.Console.WriteLine();

            // Challenge - Datatypes And Variables

            byte intByte = 2;
            sbyte intSbyte = 22;
            int intInt = 222;
            uint intUint = 2222;
            short intShort = -2222;
            ushort intUShort = 2222;
            long intLong = -22222222222;
            ulong intUlong = 2222222222;
            float pointFloat = -1.2387f;
            double pointDouble = -0.23498732987;
            char charChar = 'c';
            bool tOrf = true;
            string charString = "string";


            string numString = "10";
            string realString = "A String";
            int strToNum = Int32.Parse(numString);



        }
    }
}

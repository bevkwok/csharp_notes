using System;

namespace jagged_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare jaggedArray
            int[][] jaggedArray = new int[3][]; //3 array inside

            //add value to jaggedArray
            jaggedArray[0] = new int[5]; // first one has 5 values
            jaggedArray[1] = new int[3]; // second one has 3 values
            jaggedArray[2] = new int[2]; // third one has 2 values

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11};
            jaggedArray[1] = new int[] { 1, 2, 5 };
            jaggedArray[2] = new int[] { 3, 8 };

            //Another way
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 2, 3, 5, 7, 11},
                new int[] { 1, 4, 9 },
                new int[] { 3, 8 }
            };

            System.Console.WriteLine("number 9 is at {0}", jaggedArray2[1][2]);
            System.Console.WriteLine("number 7 is at {0}", jaggedArray2[0][3]);
            System.Console.WriteLine("number 8 is at {0}", jaggedArray2[2][1]);

            //loop thought the whole jaggedArray2
            for(int i = 0; i < jaggedArray2.Length; i++)
            {
                for(int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    System.Console.WriteLine(jaggedArray2[i][j]);
                }
            }


            //Jagged Array Challenge
            // 3 friends arrays, 2 family member of each friend in each friend array
            // introduce family members from different friend to each other

            string[][] friendsFamilies = new string[][]
            {
                new string[] {"John", "Joe"},
                new string[] {"Amy", "Austin"},
                new string[] {"David", "Don"}
            };

            for(int i = 0; i < friendsFamilies.Length; i++)
            {
                for(int j = 0; j < friendsFamilies[i].Length; j++)
                {
                    if(i == 0)
                    {
                        System.Console.WriteLine("Hi, I am Jess. I have my family {0}", friendsFamilies[i][j]);
                    }
                    if(i == 1)
                    {
                        System.Console.WriteLine("Hi, I am Angus. I have my family {0}", friendsFamilies[i][j]);
                    }
                    if(i == 2)
                    {
                        System.Console.WriteLine("Hi, I am Dustin. I have my family {0}", friendsFamilies[i][j]);
                    }
                }
            }

        }
    }
}

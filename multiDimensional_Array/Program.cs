using System;

namespace multiDimensional_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declare 2D array
            string[,] twoD;


            //Declare 3D array
            int[,,] threeD;

            // 2D array
            int[,] array2D = new int[,]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            System.Console.WriteLine("Get number 7"); 
            System.Console.WriteLine(array2D[2,0]);
            // array2D = [2, 0]


            // 3D array
            int[,,] array3D = new int[,,]
            {
                {
                    {1,2,3},
                    {4,5,6}
                },
                {
                    {7,8,9},
                    {10,11,12}
                }
            }; 

            //different way to initiate 2D array;
            string[,] stringArr2D = new string[3, 2] 
            {
                {"a1", "a2"}, 
                {"b1", "b2"}, 
                {"c1", "c2"}
            };  
            // change b2 to chicken
            stringArr2D[1,1] = "chicken";

            //to find out the dimension of the array
            int dimension = stringArr2D.Rank;
            System.Console.WriteLine(dimension); 

            //one more way to initiate 2D array
            int[,] moreArr2D = {{1,2,3}, {4,5,6}};
        }
    }
}

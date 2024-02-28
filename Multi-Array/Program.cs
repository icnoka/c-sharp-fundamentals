namespace Multi_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a 2D array with size 2,2
            int[,] array1 = new int[,] { 
                //      0   1  columns
           /*rows 0 */ { 1, 2 }, 
           /*     1 */ { 3, 4 }
            };


            // Print out the members of array1
            Console.WriteLine($"array1[0,0]: {array1[0, 0]}");
            Console.WriteLine($"array1[0,1]: {array1[0, 1]}");
            Console.WriteLine($"array1[0,1]: {array1[1, 0]}");
            Console.WriteLine($"array1[0,1]: {array1[1, 1]}");
            Console.WriteLine();

            //Using nested loops to display members
            Console.WriteLine("Length of array1 is: " + array1.Length);
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    Console.WriteLine(array1[i, j]);
                }
            }

            // Recreate the same 2D array with size 4,4
            Console.WriteLine("\nRecreating the same 2D array with size 4,4");
            array1 = new int[4, 4] {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 }
            };

            //Using nested loops to display members
            Console.WriteLine("Length of array1 is: " + array1.Length);
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    Console.WriteLine(array1[i, j]);
                }
            }

            //Sum up all elements in array
            int ans = 0;
            Console.WriteLine("\nSum up all elements in array");
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    ans = ans + array1[i, j];
                    Console.WriteLine(ans);
                }
            }
            Console.WriteLine("Sum Total: " + ans);

            int[][] array2 = [[1, 1, 1, 1], [2, 2, 2, 2]];
            Console.WriteLine(array2[0][1]);
            //Console.WriteLine(array2.);
            array2[0] = [1, 2, 3, 4];
            array2[1] = new int[4] { 1, 2, 3, 4 };

            Console.WriteLine();
            //Yidnekachew Gebresilasei Solution:  laugh 8 like 3 heart 1
            Console.WriteLine("Displaying Yidnekachew solution.");
            var arr1 = new int[4, 4]
            {
                {1,2,3,4 },
                {5,6,7,8 },
                {9,10,11, 12},
                {11,12,13,14},

            };

            for (int i = 0; i < Math.Sqrt(arr1.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(arr1.Length); j++)
                {
                    Console.WriteLine(arr1[i, j]);







                } 

            }


        }
    }
}

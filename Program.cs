using System;

namespace Q1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int n = 5, find = 75;
            int[,] mat = new int[,] { { 1, 2, 3, 4, 5, },
                                        { 10, 20, 30, 40, 50},
                                        { 55, 60, 75, 80, 95 },
                                        { 12, 24, 36, 48, 100},
                                        { 61, 73, 85, 97, 59} };
            search(mat, n, find);
        }

        public static void search(int[,] mat, int n, int find)
        {
            bool found = false;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] == find)
                    {
                        found = true;
                        Console.WriteLine("Found " + find + " at location " + i + "," + j + ".\n");
                        return;
                    }
                }
            }
            if (!found)
                Console.WriteLine(find + " does not exist in this array.\n");
            else
                Console.WriteLine("Error");
        }
    }
}

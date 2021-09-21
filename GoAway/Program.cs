using System;
using System.Collections.Generic;

namespace Go1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find courses taken by only one student
            //
            string[,] array2D = new string[,] { { "stud1", "C5" }, { "stud2", "C2" }, { "stud3", "C3" }, { "stud3", "C4" }, { "stud5", "C5" } };

            int count;

            for (int i = 0; i <= (array2D.Length / 2) - 1; i++)
            {
                count = 0;
                for (int j = 0; j <= (array2D.Length / 2) - 1; j++)
                {
                    if (array2D[i, 1] == array2D[j, 1] && i != j)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine(array2D[i, 0] + " " + array2D[i, 1]);
                }
            }
        }
    }
}

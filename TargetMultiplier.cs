using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class TargetMultiplier
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            long rows = long.Parse(input[0]);
            long cols = long.Parse(input[1]);

            var matrix = new long[rows][];

            for (long row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine().Split().Select(long.Parse).ToArray();
            }
            Console.WriteLine();

            string[] target = Console.ReadLine().Split();
            long target1=long.Parse(target[0]);
            long target2 = long.Parse(target[0]);


            for (int row = 0; row < rows; row++)
            {
                Console.WriteLine(string.Join(" ", matrix[target1][target2]));
            }


            
        }
    }


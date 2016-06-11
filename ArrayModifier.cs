using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class ArrayModifier
    {
        static void Main()
        {
            var arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            while (true)
            {
                var cmd = Console.ReadLine().Split(' ');

                if (cmd[0]=="end")
                {
                    break;
                }

                if (cmd[0]=="swap")
                {
                    long index1 = long.Parse(cmd[1]);
                    long index2 = long.Parse(cmd[2]);
                    var oldValue = arr[index1];
                    arr[index1] = arr[index2];
                    arr[index2] = oldValue;
                }

                else if (cmd[0] == "multiply")
                {
                    long index1 = long.Parse(cmd[1]);
                    long index2 = long.Parse(cmd[2]);
                    arr[index1] = arr[index1] * arr[index2];
                }
                else if (cmd[0]=="decrease")
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i]--;
                    }
                }
            }

            Console.WriteLine(string.Join(", ",arr));
        }
    }


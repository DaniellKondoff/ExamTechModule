using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.WaterSupplies
{
    class WaterSupplies
    {
        static void Main(string[] args)
        {
            double  Water = double.Parse(Console.ReadLine());
            var botlles = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double botlleCapacity = double.Parse(Console.ReadLine());


            if (Water % 2 == 0)
            {
                // start from left to right

                int breakIndex = -1;
                for (int i = 0; i < botlles.Length; i++)
                {
                    double requeredWater = botlleCapacity - botlles[i];

                    if (Water >=requeredWater)
                    {
                        botlles[i] += requeredWater;
                        Water -= requeredWater;
                    }
                    else
                    {
                        breakIndex = i;
                        botlles[i] += Water;
                        break;
                    }
                }

                if (breakIndex== -1)
                {
                    Console.WriteLine("Enough water!");
                    Console.WriteLine("Water left: {0}l.",Water);
                }
                else
                {
                    int botllesCount = botlles.Where(bottle => bottle < botlleCapacity).Count();
                    List<int> indexes = new List<int>();

                    double waterShortage = 0;

                    for (int i = breakIndex; i < botlles.Length; i++)
                    {
                        indexes.Add(i);
                        waterShortage += botlleCapacity - botlles[i];
                    }

                    Console.WriteLine("We need more water!");
                    Console.WriteLine("Bottles left: {0}",botllesCount);
                    Console.WriteLine("With indexes : {0}", string.Join(",", indexes));
                    Console.WriteLine("We need {0} more liters!",waterShortage);
                }
                


            }

            else
            {
                // start from right to left
                int breakIndex = -1;
                for (int i = botlles.Length - 1; i >= 0; i--)
                {
                    double requeredWater = botlleCapacity - botlles[i];

                    if (Water >= requeredWater)
                    {
                        botlles[i] += requeredWater;
                        Water -= requeredWater;
                    }
                    else
                    {
                        breakIndex = i;
                        botlles[i] += Water;
                        break;
                    }
                }

                if (breakIndex == -1)
                {
                    Console.WriteLine("Enough water!");
                    Console.WriteLine("Water left: {0}l.", Water);
                }

                else
                {
                    int botllesCount = botlles.Where(bottle => bottle < botlleCapacity).Count();
                    List<int> indexes = new List<int>();

                    double waterShortage = 0;

                    for (int i = breakIndex; i < botlles.Length; i++)
                    {
                        indexes.Add(i);
                        waterShortage += botlleCapacity - botlles[i];
                    }

                    Console.WriteLine("We need more water!");
                    Console.WriteLine("Bottles left: {0}", botllesCount);
                    Console.WriteLine("With indexes : {0}", string.Join(",", indexes));
                    Console.WriteLine("We need {0} more liters!", waterShortage);
                }
               
                
            }
           
        }
    }
}

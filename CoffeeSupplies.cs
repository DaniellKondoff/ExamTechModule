using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class CoffeeSupplies
    {
        static void Main()
        {
            string[] delimiters = Console.ReadLine().Split();
            string firstDelimiter = delimiters[0];
            string secondDelimiter = delimiters[1];

            Dictionary<string, string> coffeeTypeByPeaople = new Dictionary<string,string>();
            Dictionary<string, int> coffeTypeByQuantity = new Dictionary<string, int>();

            ReadInformation(coffeeTypeByPeaople, coffeTypeByQuantity, firstDelimiter, secondDelimiter);
            MonitorCoffeeUsage(coffeeTypeByPeaople, coffeTypeByQuantity);
            PrintReport(coffeeTypeByPeaople, coffeTypeByQuantity);
            
        }

        private static void PrintReport(Dictionary<string, string> coffeeTypeByPeaople, Dictionary<string, int> coffeTypeByQuantity)
        {
            Console.WriteLine("Coffee Left:");
            var filtredCoffeeTypes = coffeTypeByQuantity.Where(coffeeType => coffeeType.Value > 0).ToDictionary(coffeeType =>coffeeType.Key, coffeeType => coffeeType.Value );

            foreach (var filtredCoffeType in filtredCoffeeTypes.OrderByDescending(coffeeType => coffeeType.Value))
            {
                Console.WriteLine("{0} {1}", filtredCoffeType.Key,filtredCoffeType.Value);
            }

            Console.WriteLine("For:");

            var coffeeLeftForPeople = coffeeTypeByPeaople.Where(person => filtredCoffeeTypes.ContainsKey(person.Value))
                .OrderBy(person => person.Value)
                .ThenByDescending(person => person.Key);
            foreach (var keyValuePair in coffeeLeftForPeople)
            {
                Console.WriteLine("{0} {1}",keyValuePair.Key, keyValuePair.Value);
            }

            
        }

        private static void MonitorCoffeeUsage(Dictionary<string, string> coffeeTypeByPeaople, Dictionary<string, int> coffeTypeByQuantity)
        {
            while (true)
            {
                string command = Console.ReadLine();

                if (command=="end of week")
                {
                    break;
                }

                string[] commandArgs = command.Split();
                string personName = commandArgs[0];
                int quantity = int.Parse(commandArgs[1]);

                string coffeeType = coffeeTypeByPeaople[personName];
                coffeTypeByQuantity[coffeeType] -= quantity;

                if (coffeTypeByQuantity[coffeeType] <=0)
                {
                    Console.WriteLine("Out of {0}", coffeeType);
                }
            }
        }

        private static void ReadInformation(Dictionary<string, string> coffeeTypeByPeaople, Dictionary<string, int> coffeTypeByQuantity, string firstDelimiter, string secondDelimiter)
        {
            while (true)
            {
                string command = Console.ReadLine();

                if (command=="end of info")
                {
                    break;
                }

                if (command.Contains(firstDelimiter))
                {
                    int indexOfDelimiter = command.IndexOf(firstDelimiter);
                    string personName = command.Substring(0, indexOfDelimiter);
                    string coffeType = command.Substring(indexOfDelimiter + firstDelimiter.Length);

                    if (coffeeTypeByPeaople.ContainsKey(personName))
                    {
                        coffeeTypeByPeaople[personName] = coffeType;
                    }

                    else
                    {
                        coffeeTypeByPeaople.Add(personName, coffeType);
                    }

                    
                }

                else
                {
                    int indexOfDelimiter = command.IndexOf(secondDelimiter);
                    string cofeeName = command.Substring(0, indexOfDelimiter);
                    int quantity = int.Parse(command.Substring(indexOfDelimiter + firstDelimiter.Length));

                    if (coffeTypeByQuantity.ContainsKey(cofeeName))
                    {
                        coffeTypeByQuantity[cofeeName] += quantity;
                    }
                    else
                    {
                        coffeTypeByQuantity.Add(cofeeName,quantity);
                    }

                }
            }
        }
    }


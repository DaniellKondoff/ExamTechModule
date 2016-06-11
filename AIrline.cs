using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class AIrline
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            decimal overralProfti = 0;
            

            for (int i = 0; i < N; i++)
            {
                var adultPassCount = decimal.Parse(Console.ReadLine());
                var adultTicketPrice = decimal.Parse(Console.ReadLine());
                var youthPassCount = decimal.Parse(Console.ReadLine());
                var youthTicketPrice = decimal.Parse(Console.ReadLine());
                var fuelPriceHour = decimal.Parse(Console.ReadLine());
                var fuelConsumHour = decimal.Parse(Console.ReadLine());
                var flightDuration = decimal.Parse(Console.ReadLine());

                var income = (adultPassCount * adultTicketPrice) + (youthPassCount * youthTicketPrice);
                var expenses = flightDuration * fuelConsumHour * fuelPriceHour;
                var different = income - expenses;
                if (income >= expenses)
                {
                    Console.WriteLine("You are ahead with {0:f3}$.", different);
                }
                else
                {
                    Console.WriteLine("We've got to sell more tickets! We've lost {0:f3}$.", different);
                }

                overralProfti += different;
                


            }
            Console.WriteLine("Overall profit -> {0:f3}$.",overralProfti);
            Console.WriteLine("Average profit -> {0:f3}$.",overralProfti/N);
        }
            
    }


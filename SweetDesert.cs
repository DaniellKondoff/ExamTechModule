using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_June2016
{
    class SweetDesert
    {
        static void Main(string[] args)
        {
            var cash = decimal.Parse(Console.ReadLine());
            var guests = decimal.Parse(Console.ReadLine());
            var bananasPrice = decimal.Parse(Console.ReadLine());
            var eggsPrice = decimal.Parse(Console.ReadLine());
            var berriesPrice = decimal.Parse(Console.ReadLine());

            //var sets = (int)(guests / 6);
            //if (guests%6 !=0)
            //{
            //    sets++;
            //}

            var sets = Math.Ceiling(guests / 6);

            var pricePerSet = 2 * bananasPrice + 4 * eggsPrice + 0.2m * berriesPrice;
            var moneyRequered = sets * pricePerSet;

            if (cash<moneyRequered)
            {
                var shortage = moneyRequered - cash;
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.",shortage);
            }

            else
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.",moneyRequered);
            }

        }
    }
}

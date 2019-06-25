using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CottaCush
{
    class Program
    {


        static void Main(string[] args)
        {

            var problem = new CamelBananaProblem();
            int currentCamelCount = 1;
            int maxBananas = problem.CalculateBananasAtMarket();
            int maxCamels = 0;


            while (currentCamelCount < 10)
            {
                
                problem = new CamelBananaProblem();
                currentCamelCount++;
                problem.NumberOfCamels = currentCamelCount;
                int current = problem.CalculateBananasAtMarket();
                if (current > maxBananas)
                {
                    maxBananas = current;
                    maxCamels = problem.NumberOfCamels;
                }
            }

            Console.WriteLine(maxBananas + " " + maxCamels);
        }


    }
}

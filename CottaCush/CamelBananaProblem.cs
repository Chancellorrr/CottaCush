using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CottaCush
{
    class CamelBananaProblem
    {
        public CamelBananaProblem(int initialBananaCount = 3000, int maxLoadPerCamel = 1000, int numberOfCamels = 1, int totalDistance = 1000)
        {
            InitialBananaCount = initialBananaCount;
            CurrentBananaCount = initialBananaCount;
            MaxLoadPerCamel = maxLoadPerCamel;
            NumberOfCamels = numberOfCamels;
            TotalDistance = totalDistance;
        }

        public int InitialBananaCount { get; set; }
        public int CurrentBananaCount { get; set; }
        public int BananasAtMarket { get; set; } = 0;
        public int DistanceCovered { get; set; } = 0;
        public int MaxLoadPerCamel { get; set; }
        public int NumberOfCamels { get; set; }
        public int TotalDistance { get; set; }

        public int CalculateBananasAtMarket()
        {
            int adjustedCamel = NumberOfCamels > (InitialBananaCount / MaxLoadPerCamel) ? CurrentBananaCount / MaxLoadPerCamel : NumberOfCamels;
            while (true)
            {
                int noOfTrips = ((CurrentBananaCount / MaxLoadPerCamel) * 2) - adjustedCamel;
                DistanceCovered += MaxLoadPerCamel / noOfTrips;
                CurrentBananaCount -= MaxLoadPerCamel;
                if (CurrentBananaCount <= MaxLoadPerCamel)
                {
                    BananasAtMarket = CurrentBananaCount - (TotalDistance - DistanceCovered);
                    break;
                }
            }
            return BananasAtMarket;

        }

    }
}

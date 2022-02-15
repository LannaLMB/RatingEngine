using rating_engine.Models.Factors;
using System.Linq;

namespace rating_engine.Services
{
    public class RatingAlgorithmService
    {
        public double GetStateFactor(string stateInput)
        {
            StateFactors states = new StateFactors();
            double stateFactor = 0;

            var myKey = states.factorsByState.FirstOrDefault(x => x.Key == stateInput).Key;
            stateFactor = states.factorsByState[myKey];

            return stateFactor;
        }

        public double GetBusinessFactor(string businessInput)
        {
            BusinessFactors businesses = new BusinessFactors();
            double businessFactor = 0;

            var myKey = businesses.factorsByBusiness.FirstOrDefault(x => x.Key == businessInput).Key;
            businessFactor = businesses.factorsByBusiness[myKey];

            return businessFactor;
        }

        public double GetBasePremium(int revenue)
        {
            double basePremium = 0;
            basePremium = revenue / 1000;

            return basePremium;
        }

        public double GetPremium(double stateFactor, double businessFactor, double basePremium, double hazardFactor)
        {
            double premium = 0;
            premium = stateFactor * businessFactor * basePremium * hazardFactor;

            return premium;
        }
    }
}

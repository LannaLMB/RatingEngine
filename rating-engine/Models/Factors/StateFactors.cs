using System.Collections.Generic;

namespace rating_engine.Models.Factors
{
    public class StateFactors
    {
        public Dictionary<string, double> factorsByState = new Dictionary<string, double>
        {
            {"OH" , 1 },
            {"FL", 1.2 },
            {"TX", 0.943 }
        };
    }
}

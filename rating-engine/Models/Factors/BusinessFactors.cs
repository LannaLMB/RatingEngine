using System.Collections.Generic;

namespace rating_engine.Models.Factors
{
    public class BusinessFactors
    {
        public Dictionary<string, double> factorsByBusiness = new Dictionary<string, double>
        {
            {"Architect", 1 },
            {"Plumber", 0.5 },
            {"Programmer", 1.25 }
        };
    }
}

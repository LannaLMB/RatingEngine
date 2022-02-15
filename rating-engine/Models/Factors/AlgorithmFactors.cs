namespace rating_engine.Factors
{
    public class AlgorithmFactors
    {
        public double StateFactor { get; set; }
        public double BusinessFactor { get; set; }
        public double BasePremium { get; set; }
        public int HazardFactor { get; set; } = 4;
        public double TotalPremium { get; set; }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using rating_engine.Factors;
using rating_engine.Models.Requests;
using rating_engine.Models.Responses;
using rating_engine.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rating_engine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RatingEngineController : ControllerBase
    {
        [HttpPost]
        public TotalPremiumResponse GenerateTotalPremium([FromBody] TotalPremiumRequest totalPremiumRequest)
        {
            RatingAlgorithmService ratingAlgorithmService = new RatingAlgorithmService();
            AlgorithmFactors algorithmFactors = new AlgorithmFactors();

            double stateFactor = ratingAlgorithmService.GetStateFactor(totalPremiumRequest.State);
            double businessFactor = ratingAlgorithmService.GetBusinessFactor(totalPremiumRequest.Business);
            double basePremium = ratingAlgorithmService.GetBasePremium(totalPremiumRequest.Revenue);
            int hazardFactor = algorithmFactors.HazardFactor;

            double totalPremium = ratingAlgorithmService.GetPremium(stateFactor, businessFactor, basePremium, hazardFactor);

            TotalPremiumResponse totalPremiumResponse = new TotalPremiumResponse();
            totalPremiumResponse.Premium = totalPremium;

            return totalPremiumResponse;
        }
    }
}

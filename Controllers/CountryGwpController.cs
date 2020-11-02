using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GWPCalculation.Interfaces;
using GWPCalculation.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GWPCalculation.Controllers
{
    [ApiController]
    [Route("server")]
    public class CountryGwpController : ControllerBase
    {
        
        private readonly ILogger<CountryGwpController> _logger;
        private readonly IGWPAverageCalculator _averageCalculator;
        private readonly IGWPMockedValues _GWPMockedValues;

        public CountryGwpController(ILogger<CountryGwpController> logger, IGWPAverageCalculator averageCalculator, IGWPMockedValues GWPMockedValues)
        {
            _logger = logger;
            _averageCalculator = averageCalculator;
            _GWPMockedValues = GWPMockedValues;
        }

        [HttpGet]
        [ResponseCache(Duration = 100)]	
        [Route("api/gwp/avg")]
        public Task<double> Get()
        {
            //Put every logic in try catch
            double avg=0.0;
            try
            {
                int[] values=_GWPMockedValues.GetGWPMockedValues("MockedData"); //Should use enum instead of strings for datatype
                avg=  _averageCalculator.GetGWPAverage(values).Result;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error in API response");

            }
            return Task.FromResult(avg);

        }
    }
}

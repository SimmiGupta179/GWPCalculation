using GWPCalculation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GWPCalculation.Services
{
    public class GWPAverageCalculator : IGWPAverageCalculator
    {
        public async Task<double> GetGWPAverage(int[] values)
        {
            return values.Average(); // running synchronously for now
        }
    }
}

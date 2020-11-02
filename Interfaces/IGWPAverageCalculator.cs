using System.Collections.Generic;
using System.Threading.Tasks;

namespace GWPCalculation.Interfaces
{
    public interface IGWPAverageCalculator
    {
        Task<double> GetGWPAverage(int[] values);
    }
}
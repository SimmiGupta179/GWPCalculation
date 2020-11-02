using GWPCalculation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GWPCalculation.Interfaces
{
    public interface IGWPDBConnection
    {
        public string GetDBConnection(string databaseType);
    }
}

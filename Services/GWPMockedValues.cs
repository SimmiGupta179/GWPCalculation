using GWPCalculation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GWPCalculation.Services
{
    public class GWPMockedValues : IGWPMockedValues
    {
        IGWPDBConnection _IGWPDBConnection;
        public GWPMockedValues(IGWPDBConnection IGWPDBConnection)
        {
            _IGWPDBConnection = IGWPDBConnection;
        }

        public int[] GetGWPMockedValues(string databaseName)
        {
            var connectionObject = _IGWPDBConnection.GetDBConnection(databaseName);
            if (connectionObject.Equals("MockedDataConnectionObject"))
            {
                return GWPValues.Values;
            }
            else
            {
                throw new Exception("InvalidDataConnectionObject");
            }

        }
    }
}

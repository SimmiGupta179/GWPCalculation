using GWPCalculation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GWPCalculation.Services
{
    public class DBConnector : IGWPDBConnection
    {
        public string GetDBConnection(string databaseType)
        {
            if (databaseType == "MockedData")
            {
                return "MockedDataConnectionObject";
            }
            else
            {
                //Here we can return connection for other databases based on database type, for now, throwing exception
                throw new Exception("Invalid Database Name");
            }
            
        }
    }
}

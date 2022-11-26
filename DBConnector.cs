using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniscentPOSAI
{
    internal class DBConnector
    {

        public string DBConnection()
        {
            string connect = @"Data Source=DAPANAS\DAPANAS_OFFICE;Initial Catalog=OmniscentDB;Integrated Security=True";
            return connect;
        }
    }
}

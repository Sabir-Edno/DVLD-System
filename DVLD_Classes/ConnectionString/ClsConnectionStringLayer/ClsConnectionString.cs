using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsConnectionStringLayer
{
    public class ClsConnectionString
    {

        private const string _ConnectionString = "Data Source=.;Initial Catalog=DVLD;Integrated Security=SSPI";

        public static string ConnectionString { get { return _ConnectionString; } }

    }
}

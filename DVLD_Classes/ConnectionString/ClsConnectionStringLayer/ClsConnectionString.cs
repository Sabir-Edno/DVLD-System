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

        private const string _ConnectionString = "Server=.;Database=DVLD;User Id=sa;Password=sa123456";

        public static string ConnectionString { get { return _ConnectionString; } }

    }
}

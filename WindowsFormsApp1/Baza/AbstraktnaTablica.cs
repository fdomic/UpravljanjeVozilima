using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportnaApp.Baza
{
    public class AbstraktnaTablica
    {
        public static string Konfiguracija()
        {
            return ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        }
    }
}

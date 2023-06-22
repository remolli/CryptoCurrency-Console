using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrency_Console
{
    public class ModelRequest
    {
        public string asset_id_base { get; set; }
        public RateUnit[] rates { get; set; }
    }
    public class RateUnit
    {
        public string time { get; set; }
        public string asset_id_quote { get; set; }
        public double rate { get; set; }
    }
}

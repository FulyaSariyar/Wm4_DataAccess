using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using North_DbFirst.Models;

namespace North_DbFirst.Models
{
    public partial class Product //dikkat partial oldugu için bunu yaparsak UrunForm loaddaki displaymember vermemize gerek kalmaz.
    {
        public override string ToString()
        {
            return $"{ ProductName} - {UnitPrice:c2}";
        }
    }
}

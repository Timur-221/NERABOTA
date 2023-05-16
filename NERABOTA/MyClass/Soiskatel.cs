using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NERABOTA.Data
{
    public partial class Soiskatel
    {
        public string MessageNameBuyer
        {
            get
            {
                return $" {surname_sois} {otchestvo_sois}";
            }
        }
    }
}

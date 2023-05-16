using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NERABOTA.Data
{
    public partial class Work
    {
        public string MessageNameWork
        {
            get
            {
                return $" {name_work}";
            }
        }
    }
}

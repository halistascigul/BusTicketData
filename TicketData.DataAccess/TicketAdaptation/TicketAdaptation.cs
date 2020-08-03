using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketData.Core.Data;

namespace TicketData.DataAccess.TicketAdaptation
{
    public class TicketAdaptation : BaseHelper
    {
        public TicketAdaptation()
        {
            ConnectionString = "Data Source=.; Initial Catalog=TicketDataDb; Integrated Security=true";
        }
    }
}

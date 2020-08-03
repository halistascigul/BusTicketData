using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketData.Core.Model;

namespace TicketData.Domain.Entities
{
    public class State : BaseModel
    {
        public string Province { get; set; }
    }
}

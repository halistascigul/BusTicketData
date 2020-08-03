using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketData.Domain.Entities;

namespace TicketData.DataAccess.Mapping
{
    public class StateProvinceMap : BaseMap<State>
    {
        public StateProvinceMap()
        {
            ToTable("Provinces");
            Property(x => x.Province).HasMaxLength(50);
        }
    }
}

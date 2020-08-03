using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketData.Domain.Entities;

namespace TicketData.DataAccess.Mapping
{
    public class BusMap : BaseMap<Bus>
    {
        public BusMap()
        {
            ToTable("Buses");
            Property(x => x.BusModel).HasMaxLength(50);
            Property(x => x.BusType).HasMaxLength(10);
            Property(x => x.WhereFrom).HasMaxLength(50);
            Property(x => x.WhereTo).HasMaxLength(50);
            Property(x => x.TravelDate).HasColumnType("datetime2");
            Property(x => x.TravelTime).HasMaxLength(5);
        }
    }
}

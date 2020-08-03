using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketData.Domain.Entities;

namespace TicketData.DataAccess.Mapping
{
    public class PassengerMap : BaseMap<Passenger>
    {
        public PassengerMap()
        {
            ToTable("Passengers");
            Property(x => x.FullName).HasMaxLength(50).IsRequired();
            Property(x => x.IdentityNumber).IsRequired();
            Property(x => x.Phone).HasMaxLength(15).IsRequired();
            Property(x => x.Email).HasMaxLength(100).IsRequired();
            Property(x => x.FeeToPay).HasColumnType("money");

            HasRequired(x => x.Bus)
                .WithMany(x => x.Passengers)
                .HasForeignKey(x => x.BusId)
                .WillCascadeOnDelete(false);
        }
    }
}

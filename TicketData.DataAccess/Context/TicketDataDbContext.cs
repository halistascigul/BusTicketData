using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketData.DataAccess.Mapping;
using TicketData.Domain.Entities;

namespace TicketData.DataAccess.Context
{
    public class TicketDataDbContext : DbContext
    {
        public TicketDataDbContext() : base ("CstrTicketDataDb")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BusMap());
            modelBuilder.Configurations.Add(new PassengerMap());
            modelBuilder.Configurations.Add(new StateProvinceMap());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<State> States { get; set; }
    }
}

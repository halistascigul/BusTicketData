namespace TicketData.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using TicketData.Domain.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<TicketData.DataAccess.Context.TicketDataDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TicketData.DataAccess.Context.TicketDataDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Buses.AddOrUpdate(x => x.BusModel,
                new Bus
                {
                    BusModel = "A-4MEG-(40)",
                    BusType = "2+1",
                    SeatingCapacity=39,
                    TravelDate= new DateTime(2020,07,20),
                    TravelTime="18:30",
                    WhereFrom="Ankara",
                    WhereTo="İstanbul"
                },
                new Bus 
                { 
                    BusModel= "A-5MEG-(42)",
                    BusType="2+1",
                    SeatingCapacity=40,
                    TravelDate = new DateTime(2020, 07, 19),
                    TravelTime = "20:30",
                    WhereFrom = "Ankara",
                    WhereTo = "İzmir"
                });
            context.Passengers.AddOrUpdate(x => x.FullName,
                new Passenger
                {
                    FullName = "Halis TAŞCIGÜL",
                    IdentityNumber = 12345678910,
                    Phone = "555 55 55",
                    Email = "yakup@mail.com",
                    BusId = 1,
                    FeeToPay = 100,
                    Gender = "Erkek",
                    SeatNumber = 1
                }); ; ;
            context.States.AddOrUpdate(x => x.Province,
                new State
                {
                    Province = "Ankara"
                },
                new State
                {
                    Province = "İstanbul"
                },
                new State
                {
                    Province = "İzmir"
                }, 
                new State
                {
                    Province="Antalya"
                }, 
                new State
                {
                    Province="Eskişehir"
                }, 
                new State
                {
                    Province="Bursa"
                });
        }
    }
}

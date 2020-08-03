using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketData.Core.Model;

namespace TicketData.Domain.Entities
{
    public class Bus : BaseModel
    {
        public string BusModel { get; set; }
        public byte SeatingCapacity { get; set; }
        public string BusType { get; set; }
        public List<Passenger> Passengers { get; set; }
        public DateTime TravelDate { get; set; }
        public string TravelTime { get; set; }
        public string WhereFrom { get; set; }
        public string WhereTo { get; set; }
    }
}

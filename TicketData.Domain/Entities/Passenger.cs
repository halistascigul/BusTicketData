using TicketData.Core.Model;

namespace TicketData.Domain.Entities
{
    public class Passenger : BaseModel
    {
        public string FullName { get; set; }
        public long IdentityNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public byte SeatNumber { get; set; }
        public decimal FeeToPay { get; set; }
        public int BusId { get; set; }
        public Bus Bus { get; set; }
    }
}

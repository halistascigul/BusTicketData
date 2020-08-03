using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketData.Core.Model
{
    public abstract class BaseModel
    {
        public BaseModel()
        {
            IsActive = true;
            IsDeleted = false;
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}

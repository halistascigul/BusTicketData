using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketData.Core.Extension
{
    public static class CommonException
    {
        public static Exception ToInnestException(this Exception ex)
        {
            if (ex.InnerException!=null)
            {
                return ex.InnerException.ToInnestException();
            }
            return ex;
        }
    }
}

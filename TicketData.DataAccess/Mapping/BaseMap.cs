﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketData.Core.Model;

namespace TicketData.DataAccess.Mapping
{
    public class BaseMap<T> : EntityTypeConfiguration<T>
        where T : BaseModel
    {
        public BaseMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Created).HasColumnType("datetime2");
            Property(x => x.Updated).HasColumnType("datetime2");
        }
    }
}

using Organization.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Organization.Domain.Entities
{
    public class Role:BaseEntity
    {
        public required string Name { get; set; }
    }
}

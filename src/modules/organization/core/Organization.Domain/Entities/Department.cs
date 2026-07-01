using Organization.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Organization.Domain.Entities
{
    public class Department:BaseEntity
    {
        public required string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public abstract class EntityBase
    {
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}

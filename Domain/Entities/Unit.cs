using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Unit : EntityBase
    {
        public int Id { get; set; }
        public string UnitNumber { get; set; }
        public string UnitType { get; set; }

        public string Model { get; set; }
    }
}

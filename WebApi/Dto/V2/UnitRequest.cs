using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Dto.V2
{
    public class UnitRequest : V1.UnitRequest
    {
        public string Model { get; set; }
    }
}

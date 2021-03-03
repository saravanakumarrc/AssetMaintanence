﻿using Application;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Dto.V1;

namespace WebApi.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route("api/units")]
    [ApiController]
    public class UnitsV1Controller : ControllerBase
    {
        private readonly IUnitsManager _unitsManager;

        public UnitsV1Controller(IUnitsManager unitsManager)
        {
            _unitsManager = unitsManager;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] UnitRequest unitRequest)
        {
            var entity = new Unit { CreatedBy = "saravana", UnitNumber = unitRequest.UnitNumber, UnitType = unitRequest.UnitType };
            entity = await _unitsManager.Add(entity);
            if(entity != null)
            {
                var unitResponse = new UnitResponse { UnitNumber = entity.UnitNumber, UnitType = entity.UnitType };
                return Created($"uri/{ entity.Id }", unitResponse);
                //TODO: replace uri with the URI composer
            }
            return NoContent();
        }
    }
}

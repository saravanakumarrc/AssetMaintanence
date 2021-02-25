using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IUnitsManager
    {
        Task<Unit> Add(Unit unit);
    }
}

using Domain.Entities;
using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public class UnitsManager : IUnitsManager
    {
        private readonly IRepository<Unit> _repository;

        public UnitsManager(IRepository<Unit> repository)
        {
            _repository = repository;
        }

        public Task<Unit> Add(Unit unit)
        {
            if (unit == null) throw new InvalidArgumentForUseCase();
            // validation logic -- TODO: using fluent validation
            return _repository.Add(unit);
        }
    }
}

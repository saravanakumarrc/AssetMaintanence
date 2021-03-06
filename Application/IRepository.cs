﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IRepository<T> where T : EntityBase
    {
        Task<T> Add(T entity);
    }
}

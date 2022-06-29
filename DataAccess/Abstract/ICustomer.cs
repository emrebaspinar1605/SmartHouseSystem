using Core.DataAccess;
using Entities;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface ICustomer:IEntityRepository<Customer>
    {
    }
}

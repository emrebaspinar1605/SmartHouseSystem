using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using Entities;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Concrete
{
    public class EfCustomer : EfEntityRepositoryBase<Customer, SmartHouseContext>, ICustomer
    {
      
    }
}

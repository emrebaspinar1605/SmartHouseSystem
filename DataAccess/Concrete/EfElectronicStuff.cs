using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Concrete
{
    public class EfElectronicStuff : EfEntityRepositoryBase<ElectronicStuff,SmartHouseContext>, IElectronicStuff
    {
       
    }
}

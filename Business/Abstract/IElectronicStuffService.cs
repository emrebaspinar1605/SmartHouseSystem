using Core.Utilities.Results;
using Entities;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IElectronicStuffService
    {
        IDataResult<ElectronicStuff> GetById(int electronicId);
        IDataResult<List<ElectronicStuff>> GetList();
        IResult Calculate(ElectronicStuff stuff);
        IResult Add(ElectronicStuff stuff);
        IResult Delete(ElectronicStuff stuff);
        IResult Update(ElectronicStuff stuff);
    }
}

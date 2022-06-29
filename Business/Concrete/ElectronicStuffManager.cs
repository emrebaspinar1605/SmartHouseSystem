using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ElectronicStuffManager : IElectronicStuffService
    {
        private IElectronicStuff _stuff;
        public ElectronicStuffManager(IElectronicStuff stuff)
        {
            _stuff = stuff;
        }
        public IResult Add(Entities.ElectronicStuff stuff)
        {
            _stuff.Add(stuff);
            return new SuccessResult(Messages.ElectricStuffAdded);
        }

        public IResult Calculate(Entities.ElectronicStuff stuff)
        {
            int electric = Convert.ToInt32(stuff.SpendElectric);
            int moneyPerSpendElectric = Convert.ToInt32(stuff.PriceForSpendElectric);
            int calculate = electric * moneyPerSpendElectric;
            return new SuccessResult(Messages.Calculated);
        }

        public IResult Delete(Entities.ElectronicStuff stuff)
        {
            _stuff.Delete(stuff);
            return new SuccessResult(Messages.ElectricStuffDeleted);
        }

        public IDataResult<Entities.ElectronicStuff> GetById(int electronicId)
        {
            return new SuccessDataResult<Entities.ElectronicStuff>(_stuff.Get(e => e.Id == electronicId));
        }

        public IDataResult<List<Entities.ElectronicStuff>> GetList()
        {
            return new SuccessDataResult<List<Entities.ElectronicStuff>>(_stuff.Getall());
        }
        

        public IResult Update(Entities.ElectronicStuff stuff)
        {
            _stuff.Update(stuff);
            return new SuccessResult(Messages.ElectricStuffUpdated);
        }
    }
}

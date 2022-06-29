using Core.Entity;

namespace Entities
{
    public class ElectronicStuff:IEntity
    {
        public int Id { get; set; }
        public double SpendElectric { get; set; }
        public double PriceForSpendElectric { get; set; }
    }
}

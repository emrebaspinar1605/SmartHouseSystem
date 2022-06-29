using Core.Entity;

namespace Entities
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int YearOfProduction { get; set; }
        public decimal SpendElectric { get; set; }
    }
}

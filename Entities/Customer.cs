using Core.Entity;

namespace Entities
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Tel { get; set; }
    }
}

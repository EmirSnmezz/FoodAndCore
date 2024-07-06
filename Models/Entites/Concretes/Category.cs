using FoodAndCore.Core.Entites.Abstracts;

namespace FoodAndCore.Models.Entites.Concretes
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public List<Food> Foods { get; set; }
    }
}

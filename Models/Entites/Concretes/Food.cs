using FoodAndCore.Core.Entites.Abstracts;

namespace FoodAndCore.Models.Entites.Concretes
{
    public class Food : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public int Stock { get; set; }
    }
}

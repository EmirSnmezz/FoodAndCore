using FoodAndCore.Core.Entites.Abstracts;
using FoodAndCore.Models.Entites.Concretes;
using FoodAndCore.Models.Generic_Repository.Abstract;

namespace FoodAndCore.Models.Repositories.Abstract
{
    public interface IFoodRepository : IEntityRepository<Food>
    {
    }
}

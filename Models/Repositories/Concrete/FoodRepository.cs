using FoodAndCore.Models.Entites.Concretes;
using FoodAndCore.Models.Repositories.Abstract;

namespace FoodAndCore.Models.Generic_Repository.Concrete
{
    public class FoodRepository : EntityRepositoryBase<Food, Context>, IFoodRepository
    {
        public FoodRepository(Context context) : base(context)
        {
        }
    }
}

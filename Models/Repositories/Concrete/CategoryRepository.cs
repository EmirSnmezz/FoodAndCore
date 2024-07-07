using FoodAndCore.Models.Entites.Concretes;
using FoodAndCore.Models.Generic_Repository.Concrete;
using FoodAndCore.Models.Repositories.Abstract;

namespace FoodAndCore.Models.Repositories.Concrete
{
    public class CategoryRepository : EntityRepositoryBase<Food, Context>, IFoodRepository
    {
        public CategoryRepository(Context context) : base(context)
        {
        }
    }
}

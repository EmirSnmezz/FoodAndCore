using FoodAndCore.Core.Entites.Abstracts;
using FoodAndCore.Core.Utilities.Abstract.DataResult;
using FoodAndCore.Core.Utilities.Abstract.Result;
using System.Linq.Expressions;

namespace FoodAndCore.Models.Generic_Repository.Abstract
{
    public interface IEntityRepository<T> where T: class, IEntity ,new()
    {
        public Core.Utilities.Abstract.Result.IResult Add(T entity);
        public Core.Utilities.Abstract.Result.IResult Update(T entity);
        public Core.Utilities.Abstract.Result.IResult Delete (int id);
        public IDataResult<List<T>> GetAll();
    }
}

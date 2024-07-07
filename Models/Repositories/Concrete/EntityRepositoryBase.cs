using FoodAndCore.Core.Constant;
using FoodAndCore.Core.Entites.Abstracts;
using FoodAndCore.Core.Utilities.Abstract.DataResult;
using FoodAndCore.Core.Utilities.Concrete.DataResults;
using FoodAndCore.Core.Utilities.Concrete.Results;
using FoodAndCore.Models.Generic_Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FoodAndCore.Models.Generic_Repository.Concrete
{
    public class EntityRepositoryBase<T, TContext> : IEntityRepository<T>
        where T : class, IEntity, new()
        where TContext : DbContext, new()
    {

        TContext _context;

        public EntityRepositoryBase(TContext context)
        {
            _context = context;
        }
        public Core.Utilities.Abstract.Result.IResult Add(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity), Messages.AddErrorMessage);
            _context.Add(entity);
            _context.SaveChanges();
            return new SuccessResult(Messages.AddSuccessMessage);
        }

        public Core.Utilities.Abstract.Result.IResult Delete(int id)
        {
            if (id == 0) throw new ArgumentNullException(Messages.DeleteErrorMessage);

            var result = _context.Set<T>().Find(id);
            _context.Remove(result);
            _context.SaveChanges();

            return new SuccessResult(Messages.DeleteSuccessMessage);
        }

        public IDataResult<List<T>> GetAll(Expression<Func<T, bool>> filter = null)
        {
           if(filter == null)
            {
                var result = _context.Set<T>().ToList();
                if(result == null)
                {
                    return new ErrorDataResult<List<T>>( result, Messages.GetErrorMessage);
                }
                return new SuccessDataResult<List<T>>(result, Messages.GetSuccessMessage);
            }

           else
            {
                var result =  _context.Set<T>().Where(filter).ToList();

                if (result == null)
                {
                    return new ErrorDataResult<List<T>>(result, Messages.GetErrorMessage);
                }
                return new SuccessDataResult<List<T>>(result, Messages.GetSuccessMessage);
            }
        }

        public Core.Utilities.Abstract.Result.IResult Update(T entity)
        {
            if(entity == null)
            {
                return new ErrorResult(Messages.UpdateErrorMessage);
            }

            _context.Set<T>().Update(entity);
            _context.SaveChanges();

            return new SuccessResult(Messages.UpdateSuccessMessage);
        }
    }
}

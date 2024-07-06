using FoodAndCore.Core.Utilities.Abstract.Result;
using IResult = FoodAndCore.Core.Utilities.Abstract.Result.IResult;

namespace FoodAndCore.Core.Utilities.Abstract.DataResult
{
    public interface IDataResult<T> : IResult where T : class
    {
        public T Data { get; }
    }
}

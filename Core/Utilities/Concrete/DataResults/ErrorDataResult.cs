using FoodAndCore.Core.Utilities.Abstract.DataResult;
using FoodAndCore.Core.Utilities.Concrete.Results;

namespace FoodAndCore.Core.Utilities.Concrete.DataResults
{
    public class ErrorDataResult<T> : DataResult<T>, IDataResult<T> where T : class
    {
        public ErrorDataResult(T data, string message) : base(data, message, false)
        {
        }

        public ErrorDataResult(T data) : base(data, false)
        {

        }
    }
}

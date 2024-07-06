using FoodAndCore.Core.Utilities.Abstract.DataResult;

namespace FoodAndCore.Core.Utilities.Concrete.DataResults
{
    public class SuccessDataResult<T> : DataResult<T> , IDataResult<T> where T : class
    {
        public SuccessDataResult(T data, string message) :base(data,message,true)
        {
        }

        public SuccessDataResult(T data) : base(data,true) 
        {

        }
    }
}

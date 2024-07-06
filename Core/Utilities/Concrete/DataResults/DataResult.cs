using FoodAndCore.Core.Utilities.Abstract.DataResult;
using FoodAndCore.Core.Utilities.Concrete.Results;

namespace FoodAndCore.Core.Utilities.Concrete.DataResults
{
    public class DataResult<T> : Result, IDataResult<T> where T : class
    {
        public DataResult(T data ,string message, bool isSuccess) : base(message, isSuccess)
        {
            Data = data;   
        }

        public DataResult(T data, bool isSuccess) :base(isSuccess)
        {
            Data = data;
        }

        public T Data { get ; }
    }
}

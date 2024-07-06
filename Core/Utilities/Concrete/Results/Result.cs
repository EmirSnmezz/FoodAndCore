using FoodAndCore.Core.Utilities.Abstract.Result;
using IResult = FoodAndCore.Core.Utilities.Abstract.Result.IResult;

namespace FoodAndCore.Core.Utilities.Concrete.Results
{
    public class Result : IResult
    {
        public Result(string message, bool isSuccess) : this(isSuccess)
        {
            Message = message;
        }

        public Result(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }

        public string Message { get; set ; }
        public bool IsSuccess { get; set ; }
    }
}

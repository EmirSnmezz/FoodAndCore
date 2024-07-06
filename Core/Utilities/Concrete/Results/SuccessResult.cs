namespace FoodAndCore.Core.Utilities.Concrete.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) :base(message, true)
        {
        }

        public SuccessResult(bool isSuccess) : base(true)
        {
        }

    }
}

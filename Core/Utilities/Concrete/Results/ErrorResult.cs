namespace FoodAndCore.Core.Utilities.Concrete.Results
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) :base(message, false)
        {
            this.Message = message;
        }

        public ErrorResult(bool isSuccess) : base(false)
        {
        }
    }
}

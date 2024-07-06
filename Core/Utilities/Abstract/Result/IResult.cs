namespace FoodAndCore.Core.Utilities.Abstract.Result
{
    public interface IResult
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}

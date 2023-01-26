namespace CALCULATOR.API.Data
{
    public class WebResponse<T>
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public string StatusCode { get; set; }
        public T Body { get; set; }
    }
}

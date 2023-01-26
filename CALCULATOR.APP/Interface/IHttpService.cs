namespace CALCULATOR.APP.Interface
{
    public interface IHttpService
    {
        Task<T> Post<T>(string uri, object value);
    }
}

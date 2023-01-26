namespace CALCULATOR.APP.Interface
{
    public interface IHttpService
    {
        Task<T> Get<T>(string uri);
    }
}

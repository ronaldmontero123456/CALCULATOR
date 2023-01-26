using CALCULATOR.APP.Data;

namespace CALCULATOR.APP.Interface
{
    public interface ICalculatorService
    {
        Task<WebResponse<double>> GetResultAsync(string result);
    }
}

using CALCULATOR.APP.Data;
using CALCULATOR.APP.Interface;

namespace CALCULATOR.APP.Services
{
    public class CalculatorService : ICalculatorService
    {
        IHttpService _httpService;
        public CalculatorService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<WebResponse<double>> GetResultAsync(string result)
        {
            return await _httpService.Post<WebResponse<double>>("api/Calculate", result);
        }
    }
}

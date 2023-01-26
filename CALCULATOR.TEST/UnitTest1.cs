using CALCULATOR.API.Controllers;
using CALCULATOR.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace CALCULATOR.TEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculate()
        {
            var controller = new CalculateController();
            var result = controller.GetResultOfCalculate("5 * 3") as OkObjectResult;
            WebResponse<double> webResponse = result.Value as WebResponse<double>;
            Assert.AreEqual(15, webResponse.Body);
        }
    }
}
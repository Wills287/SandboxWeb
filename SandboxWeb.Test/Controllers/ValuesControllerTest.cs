using Microsoft.AspNetCore.Mvc;
using Moq;
using SandboxWeb.Controllers;
using SandboxWeb.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Xunit;

namespace SandboxWeb.Test.Controllers
{
    public class ValuesControllerTest
    {
        private readonly Mock<ValuesService> valuesService;

        private readonly ValuesController valuesController;

        public ValuesControllerTest()
        {
            valuesService = new Mock<ValuesService>();

            valuesService.Setup(s => s.SelectValues())
                .Returns(new List<string>()
                {
                    "value1",
                    "value2"
                });

            valuesController = new ValuesController(valuesService.Object);
        }

        [Fact]
        public void ShouldGetList()
        {
            var result = valuesController.Get();
            var okResult = result as OkObjectResult;

            Assert.NotNull(okResult);
            Assert.Equal(200, okResult.StatusCode);

            var values = okResult.Value as IList<string>;

            Assert.Contains(values, v => v.Equals("value1"));
            Assert.Contains(values, v => v.Equals("value2"));
        }

        [Fact]
        public void ShouldGetSingle()
        {
            var result = valuesController.Get(5);

            var value = result.Value;

            Assert.Equal("value", value);
        }
    }
}

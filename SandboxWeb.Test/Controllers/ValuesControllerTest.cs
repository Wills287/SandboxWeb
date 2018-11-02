using SandboxWeb.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace SandboxWeb.Test.Controllers
{
    public class ValuesControllerTest
    {
        private readonly ValuesController valuesController;

        public ValuesControllerTest()
        {
            valuesController = new ValuesController();
        }

        [Fact]
        public void ShouldGetList()
        {
            var result = valuesController.Get();

            var values = result.Value;

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

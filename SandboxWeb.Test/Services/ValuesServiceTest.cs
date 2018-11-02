using SandboxWeb.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SandboxWeb.Test.Services
{
    public class ValuesServiceTest
    {
        private readonly ValuesService valuesService;

        public ValuesServiceTest()
        {
            valuesService = new ValuesService();
        }

        [Fact]
        public void ShouldGetList()
        {
            var values = valuesService.SelectValues();

            Assert.Contains(values, v => v.Equals("value1"));
            Assert.Contains(values, v => v.Equals("value2"));
        }
    }
}

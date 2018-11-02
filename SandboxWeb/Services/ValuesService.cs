using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandboxWeb.Services
{
    public class ValuesService
    {
        public IList<string> SelectValues()
        {
            return new List<string>()
            {
                "value1",
                "value2"
            };
        }
    }
}

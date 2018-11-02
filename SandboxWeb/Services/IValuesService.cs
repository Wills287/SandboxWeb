using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandboxWeb.Services
{
    public interface IValuesService
    {
        IList<string> SelectValues();
    }
}

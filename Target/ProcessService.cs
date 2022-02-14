using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target.Service
{
    public class ProcessService
    {
        public string GetProcessInfo() {
            return $"{DateTime.Now.ToString()}: This Target info.";
        }
    }
}

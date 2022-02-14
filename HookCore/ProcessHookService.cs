using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetDetour;


namespace HookCore
{
    public class ProcessHookService : IMethodHook
    {
        [HookMethod("Target.Service.ProcessService")]
        public string GetProcessInfo() {
            return "Hook" + GetProcessInfo_Original();
        }

        [OriginalMethod]
        public string GetProcessInfo_Original() {
            return null;
        }
    }

}

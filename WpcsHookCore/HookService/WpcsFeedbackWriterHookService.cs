using DotNetDetour;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpcsHookCore.HookService
{
    public class WpcsFeedbackWriterHookService : IMethodHook
    {
        [HookMethod("Target.Service.ProcessService")]
        public bool GetProcessInfo()
        {
            //

            return ProcessFile_Original();
        }

        [OriginalMethod]
        public bool ProcessFile_Original()
        {
            return true;
        }
    }
}

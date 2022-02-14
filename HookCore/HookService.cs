using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetDetour;

namespace HookCore
{
    public class HookService
    {
        public static int Start(string msg) {
            try
            {
                MethodHook.Install();
            }
            catch
            {
                return -1;
            }

            return 1;
        }
    }
}

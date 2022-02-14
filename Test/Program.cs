using FastWin32.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            // input the pid
            Console.WriteLine("Please input pid");

            var pidString = Console.ReadLine();
            uint pid = uint.Parse(pidString);

            // inject
            string path = AppDomain.CurrentDomain.BaseDirectory + "HookCore.dll";

            Inject(pid, path, "HookCore.HookService", "Start", "");

            Console.ReadLine();
        }

        static void Inject(uint pid, string assemblyPath, string typeName, string methodName, string argument) {
            try
            {
                Injector.InjectManaged(pid, assemblyPath, typeName, methodName, argument, out int returnValue);
                Console.WriteLine(returnValue);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

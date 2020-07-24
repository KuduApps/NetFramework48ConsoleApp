using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    var assembly = Assembly.GetExecutingAssembly();
                    var targetFrameworkAttribute = assembly.GetCustomAttributes(typeof(TargetFrameworkAttribute), false).FirstOrDefault() as TargetFrameworkAttribute;
                    if (targetFrameworkAttribute != null)
                    {
                        Console.WriteLine($"Running {targetFrameworkAttribute.FrameworkDisplayName}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                Thread.Sleep(10000);
            }
        }
    }
}

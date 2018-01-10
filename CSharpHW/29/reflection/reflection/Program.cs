using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace reflection
{
    class Program
    {
        static void Main()
        {
            Assembly asm = null;
            try
            {
                asm = Assembly.LoadFrom(@"..\..\..\..\assembly\assembly\bin\Debug\assembly.exe");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (asm != null)
            {
                Type t = asm.GetType("assembly.Worker");
                MethodInfo[] allMethods = t.GetMethods();
                foreach( var method in allMethods)
                {
                    Console.WriteLine(method.Name);
                }
                ConstructorInfo Constructor = t.GetConstructor(Type.EmptyTypes);
                object ClassObj = Constructor.Invoke(new object[] { });

                MethodInfo o = t.GetMethod("ShowMessege",new Type[]{typeof(string)});
                o.Invoke(ClassObj, new string[] {"asdawd"});
                MethodInfo a = t.GetMethod("ShowMessege", new Type[0]);
                a.Invoke(ClassObj, new object[0]);
            }

            Console.ReadLine();
        }
    }
}

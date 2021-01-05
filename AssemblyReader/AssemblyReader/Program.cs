using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyReader
{
    class Program
    {
        static void Main(string[] args)
        {

            //-1- Load the assembly file location.
            Assembly assemblyObject = Assembly.LoadFile("C:\\Users\\cstuser\\Downloads\\MarissaGoncalvesLab4(Part-2-Included)\\AssemblyReader\\AssemblyReader\\bin\\Debug\\TracingApplication.exe");

            //-2- Get a reference to the SampleClass type.
            Type SampleClass = assemblyObject.GetType("TracingApplication.SampleClass");

            //-3- Instantiate the Class into an object.
            object selectedObject = Activator.CreateInstance(SampleClass);

            //-4- Get a reference of the method.
            MethodInfo methodInfo = SampleClass.GetMethod("print");

            //-5- Setup the parameters array.
            String[] parameter = { "This is a message passed to another assembly as a parameter!" };

            //-6- Invoke the method.
            methodInfo.Invoke(selectedObject, parameter);
        }
    }
}

using System;
using System.IO;
using System.Reflection;

namespace LoadAssembly
{
    class Program
    {
        static void Main(string[] args)
        {
            var DLL = Assembly.LoadFile(@"D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\CLProject1\bin\Debug\net5.0\CLProject1.dll");

            foreach (Type type in DLL.GetExportedTypes())
            {
                if(type.Name == "Class1")
                {
                    dynamic c = Activator.CreateInstance(type);
                    c.Output(@"Hello");
                }

                if (type.Name == "Customer")
                {
                    dynamic d = Activator.CreateInstance(type);
                    d.CustomerId = 1010;
                    d.FirstName = "Noor";
                    d.LastName = "deen";
                    d.Email = "noorudeens@yahoo.in";             
                    d.PrintCustomer(d);
                }              

               
            }

            Console.ReadLine();

            //CLProject1.Class1 obj = new CLProject1.Class1();

            //obj.Output("Noorudeen");

            //Console.ReadLine();
        }
    }
}

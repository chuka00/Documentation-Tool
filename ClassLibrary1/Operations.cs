using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ClassLibrary1
{
    public class Operations
    {
        public static void GetDocs(Type classtype)
        {
            ShowClassAttributes(classtype);
            ShowPropAttributes(classtype);
            ShowMethodAttributes(classtype);
        }

        public static void ShowClassAttributes(Type classtype)
        {
            Console.WriteLine("Assembly: {0}", Assembly.GetExecutingAssembly());
            Console.WriteLine("\nClass: \n\n{0}", classtype.Name);

            object[] classAttr = classtype.GetCustomAttributes(true);

            foreach (Attribute item in classAttr)
            {
                if (item is DocumentAttribute)
                {
                    DocumentAttribute doc = (DocumentAttribute)item;
                    Console.WriteLine("\nDescription:\n\t{0}", doc.Description);
                }
            }
        }

        public static void ShowPropAttributes(Type classtype)
        {
            Console.WriteLine("\n\nProperties: ");
            Console.WriteLine();

            PropertyInfo[] properties = classtype.GetProperties();

            for (int i = 0; i < properties.GetLength(0); i++)
            {
                object[] propAttr = properties[i].GetCustomAttributes(true);

                foreach (Attribute item in propAttr)
                {
                    if (item is DocumentAttribute)
                    {
                        DocumentAttribute doc = (DocumentAttribute)item;
                        Console.WriteLine("{0}\nDescription:\n\t{1}\nInput:\n\t{2}\n", properties[i].Name, doc.Description, doc.Input);
                    }
                }
            }
        }

        public static void ShowMethodAttributes(Type classtype)
        {
            Console.WriteLine("\nMethods:\n");
            MethodInfo[] methods = classtype.GetMethods();


            for (int i = 0; i < methods.GetLength(0); i++)
            {
                object[] methAttr = methods[i].GetCustomAttributes(true);

                foreach (Attribute item in methAttr)
                {
                    if (item is DocumentAttribute)
                    {
                        DocumentAttribute doc = (DocumentAttribute)item;
                        Console.WriteLine("{0}\nDescription:\n\t{1}\nInput:\n\t{2}", methods[i].Name, doc.Description, doc.Input);
                    }
                }
            }
        }
    }
}

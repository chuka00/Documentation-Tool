using ClassLibrary1;
using System.Buffers;
using System.Reflection;

namespace Fetcher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operations operations = new Operations();
            Operations.GetDocs(typeof(Customer));
            //DocumentAttribute.GetDocs(typeof(SamplePerson));
            //Console.WriteLine("Hello, World!");
            //DocumentAttribute documentAttribute = new DocumentAttribute(Customer);

        }
    }
}
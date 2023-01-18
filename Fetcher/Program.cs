using ClassLibrary1;
using System.Buffers;
using System.Reflection;

namespace Fetcher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operations.GetDocs(typeof(Customer));
        }
    }
}
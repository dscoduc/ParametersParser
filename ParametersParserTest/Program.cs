using System;
using System.Linq;

namespace ParameterParserTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var parameters = new ParametersParser.Parameters();
            foreach (var parameter in parameters)
            {
                Console.WriteLine("Index   : " + parameter.Index);
                Console.WriteLine("Bruto   : " + parameter.Bruto);
                Console.WriteLine("Netto   : [" + parameter.Netto + "]");
                Console.WriteLine("Key     : " + parameter.Key);
                Console.WriteLine("Value   : [" + (parameter.Value == null ? "<null>" : parameter.Value) + "]");
                Console.WriteLine("HasValue: " + parameter.HasValue);
                Console.WriteLine("");
            }

            string testValue = parameters.GetFirstValue("-test");

            var t = parameters.FirstOrDefault(x => x.Key == "-Test");
        }
    }
}

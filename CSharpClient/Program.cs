using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var processedNumbers = new int[] { 1, 2 };

            Console.WriteLine($"{ FSharpTest.MyMath.DivideByTwoAndFilterEvens( Microsoft.FSharp.Collections.ListModule.OfSeq(processedNumbers) ) }");
            Console.WriteLine( FSharpTest.PigLatin.ToPigLatin("Hello world from C#") );
            Console.ReadKey();
        }
    }
}

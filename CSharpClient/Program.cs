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
            var processedNumbers = new int[] { 1, 2, 3 };
            var fsInteropNum = Microsoft.FSharp.Collections.ListModule.OfSeq(processedNumbers);

            Console.WriteLine($"{ FSharpTest.MyMath.MultiplyByTwoAndPreserveOdds(fsInteropNum) }");
            Console.WriteLine($"{ FSharpTest.MyMath.HasEvens(fsInteropNum) }");

            Console.WriteLine( FSharpTest.PigLatin.ToPigLatin("Hello world from C#") );

            Task.Run( async () => {
                await FSharpTest.Worker.DoStuffInteropAsync(5000);
                Console.WriteLine("Work complete!");
                });

            Console.ReadKey();
        }
    }
}

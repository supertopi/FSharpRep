using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSharpTest;

namespace CSharpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var processedNumbers = new int[] { 1, 2, 3 };
            var fsInteropNum = Microsoft.FSharp.Collections.ListModule.OfSeq(processedNumbers);

            Console.WriteLine($"{ MyMath.MultiplyByTwoAndPreserveOdds(fsInteropNum) }");
            Console.WriteLine($"{ MyMath.HasEvens(fsInteropNum) }");
            Console.WriteLine($"{ MyMath.HasEvens(MyMath.MultiplyByTwoAndPreserveOdds(fsInteropNum)) }");


            Console.WriteLine( PigLatin.ToPigLatin("Hello world from C#") );

            Task.Run( async () => {
                await Worker.DoStuffInteropAsync(5000);
                Console.WriteLine("Work complete!");
                });

            //var member = new FSharpTest.HockeyTeam.TeamMember(); cannot be done!
            var player = new HockeyTeam.Player(new HockeyTeam.Person("Gordie Howe", 88), HockeyTeam.Position.Wingman, 9);
            Console.WriteLine(HockeyTeam.IsGoalie(player));

            Console.ReadKey();
        }
    }
}

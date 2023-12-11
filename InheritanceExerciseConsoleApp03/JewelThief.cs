using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExerciseConsoleApp03
{
    class JewelThief : Locksmith
    {
        private string stolenJewels;
        protected override void ReturnContents(string safeContents, SafeOwner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine($"I'm stealing this jewels! I stole :{stolenJewels}");
        }
    }
}

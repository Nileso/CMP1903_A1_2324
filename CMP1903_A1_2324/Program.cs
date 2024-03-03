using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
             /* Create a Game object and call its methods.*/

            Game game = new Game();
            int[] nums = game.ReturnRolls();
            game.OutputDice(nums);

            /* Create a Testing object to verify the output and operation of the other classes.*/
            Testing tester = new Testing();
            tester.Test();
        }
    }
}

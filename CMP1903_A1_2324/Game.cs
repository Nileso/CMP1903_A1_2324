using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        Die die1 = new Die();
        Die die2 = new Die();
        Die die3 = new Die();
        //Methods
        public int[] ReturnRolls()//returns a list of the dice values
        {
            int num1 = die1.Roll();
            int num2 = die2.Roll();
            int num3 = die3.Roll();
            return new int[] { num1, num2, num3 };
        }

        public int SumTheDice()//returns the sum of the dice
        {
            return die1.currentValue + die2.currentValue + die3.currentValue;
        }
        public void OutputDice(int[] nums)//outputs the dice
        {
            Console.WriteLine($"First die is {nums[0]}");
            Console.WriteLine($"Second die is {nums[1]}");
            Console.WriteLine($"Third die is {nums[2]}");
            Console.WriteLine($"The total is {nums[0] + nums[1] + nums[2]}");
        }
    }
}

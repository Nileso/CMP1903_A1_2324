using System.Diagnostics;


namespace CMP1903_A1_2324
{
    internal class Testing
    {
        public void Test() 
        {
            /*
            * This class should test the Game and the Die class.
            * Create a Game object, call the methods and compare their output to expected output.*/

            Game game = new Game()//creates a game object
            int[] nums = game.ReturnRolls();
            int sumOfNums = nums[0] + nums[1] + nums[2];
            Debug.Assert(sumOfNums == game.SumTheDice(), "Error: The sums do not match"); //compares the two sums to check for an error

            /* Create a Die object and call its method.
            * Use debug.assert() to make the comparisons and tests.*/

            Die dieTest = new Die(); //creates a new die for test purposes
            dieTest.Roll();
            Debug.Assert(dieTest.currentValue >= 1 && dieTest.currentValue <= 6, "Error: Value is not between 1 and 6 inclusive"); //checks if the dice rolls are between the correct values
        }

    }
}

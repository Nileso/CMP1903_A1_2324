using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property
        public int currentValue { get; private set; } //current value is public to get but private to set

        // Field
        static Random random = new Random(); /*creating the 'random' object is required to generate random numbers*/
        
        //Method
        public int Roll() // gets the current value for the die
        {
            currentValue = random.Next(1, 7); //creates a random number for current value
            return currentValue;
        }


    }
}

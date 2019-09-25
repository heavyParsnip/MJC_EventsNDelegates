using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJC_EventsNDelegates
{
    class Die
    {
        //EVENTS
        public event MessageDelegate RolledATwenty;

        //FIELDS
        Random random;
        int rollCounter;

        //PROPERTIES

        //CONSTRUCTORS
        public Die(Random random)
        {
            this.random = random;
            rollCounter = 0;
        }

        //METHODS
        /// <summary>
        /// Roll a die
        /// </summary>
        public int RollDie()
        {
            rollCounter++;
            int roll = random.Next(1, 21);
            
            if(roll == 20 && RolledATwenty != null)
            {
                RolledATwenty("Rolled a 20", $"This was roll #{rollCounter}");
            }

            return roll;
        }
    }
}

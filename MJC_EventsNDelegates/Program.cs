using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJC_EventsNDelegates
{
    //Delegate
    delegate void MessageDelegate(string label, string message);

    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate objects
            Random random = new Random();
            MessageLog messageLog = new MessageLog();
            Die die = new Die(random);

            //Hook up events
            die.RolledATwenty += new MessageDelegate(messageLog.Save);

            //Roll 100d20
            for(int i = 0; i < 100; i++)
            {
                int roll = die.RollDie();
                Console.WriteLine($"Rolling...{roll}");
            }

            //Print message log
            Console.WriteLine();
            messageLog.Print();
            Console.ReadLine();

        }
    }
}

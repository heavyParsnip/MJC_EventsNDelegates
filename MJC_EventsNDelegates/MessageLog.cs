using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJC_EventsNDelegates
{
    class MessageLog
    {
        //FIELDS
        List<string> labels;
        List<string> messages;

        //PROPERTIES

        //CONSTRUCTORS
        public MessageLog()
        {
            labels = new List<string>();
            messages = new List<string>();
        }

        //METHODS
        /// <summary>
        /// Saves a label and a message
        /// </summary>
        public void Save(string label, string message)
        {
            labels.Add(label);
            messages.Add(message);
        }

        /// <summary>
        /// Print the message log
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Messages logged: ");
            for(int i = 0; i < messages.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"\n{labels[i]}: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(messages[i]);
            }
        }
    }
}

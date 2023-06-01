using System;

namespace WriteStuff1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Put in the name of the file.");
                return;
            }

            //name of the file chosen
            string fileName = args[0];
            Queue<string> stringsQueue = new Queue<string>();

            while (true)
            {
                //Reads user input every sentence
                Console.Write("Insert a  string: ");
                string input = Console.ReadLine();

                //If there is nothing, stop program
                if (string.IsNullOrEmpty(input))
                break;

                stringsQueue.Enqueue(input);
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {

                }
            }
        }
    }
}

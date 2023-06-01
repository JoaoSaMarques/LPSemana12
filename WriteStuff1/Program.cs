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
        }
    }
}

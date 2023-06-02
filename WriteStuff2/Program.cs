using System;

namespace WriteStuff2
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
            
            //Saves the strings into the file 
            try
            {   
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    while (stringsQueue.Count > 0)
                    {
                        string str = stringsQueue.Dequeue();
                        writer.WriteLine(str);
                    }
                }
            }

            Console.WriteLine("Saved the  strings!");
            //If it does not save
            catch (IOException e)
            {
                Console.WriteLine("Failed to save: " + e.Message);
            }
        }
    }
}

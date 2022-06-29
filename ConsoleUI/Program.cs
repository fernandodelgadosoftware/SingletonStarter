using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            TableServers servers = new TableServers();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("The next server is: " + servers.GetNextServer());
            }

            Console.ReadLine();
        }

        private static void Host1GetNextServer()
        {
            Console.WriteLine("The next server is: " + servers.GetNextServer());
        }
    }
}

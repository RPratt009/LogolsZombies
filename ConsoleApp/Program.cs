using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StatusRepository repository = new StatusRepository();
            List<Status> statuses = repository.GetAll();
            Console.WriteLine("Statuses:");
            foreach(Status status in statuses)
            {
                Console.WriteLine($"{status.FirstName} {status.LastName} has status of {status.StatusDescription}.");
            }
        }
    }
}

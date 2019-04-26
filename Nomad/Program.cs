using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomad
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ClientContext())
            {
                foreach (var client in context.Clients.ToList())
                {
                    Console.WriteLine($"{ client.Customer}, { client.Age}, {client.Id}, {client.Deadline}");
                }
            }

            Console.Read();
        }
    }
}

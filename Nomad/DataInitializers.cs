using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomad
{
    public class DataInitializers: CreateDatabaseIfNotExists<ClientContext>
    {
        protected override void Customer(ClientContext context )
        {
            context.Clients.AddRange(new List<Client>
            {
                new Client
                {
                    Customer = "Sergey",
                    Age = 25
                   
                },
                new Client
                {
                    Customer = "Viktor",
                    Age = 30
                },
                new Client
                {
                    Customer = "Vlad",
                    Age = 31
                },
            });
            context.SaveChanges();
        }
    }
}

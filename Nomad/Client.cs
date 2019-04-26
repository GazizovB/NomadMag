using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomad
{
    public class Client
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Customer { get; set; }
        public int Age { get; set; }
        public DateTime Deadline { get; set; }
    }
}

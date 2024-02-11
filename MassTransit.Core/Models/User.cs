using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassTransit.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Address { get; set; } = String.Empty;
    }
}
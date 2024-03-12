using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Domain.Core.Events
{
    public abstract class Event
    {
        public DateTime TimeStamp { get; protected set; }
        public string? ExchangeName { get; set; }
        public string? RoutingKey { get; set; } 
        protected Event() 
        {
            TimeStamp = DateTime.Now;
        }
    }
}

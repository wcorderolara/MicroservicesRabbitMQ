using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroRabbit.Domain.Core.Commands;
using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Domain.Core.Bus
{
    internal interface IEventBus
    {
        Task SendCommand<T>(T command) where T: Command;
        void Publish<T>(T @event) where T : Event;
        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LostAndFound.SharedKernel
{
    public abstract class BaseDomainEvent: INotification
    {
        public DateTime TimeOccured { get; set; } = DateTime.UtcNow;

        public List<BaseDomainEvent> Events = new List<BaseDomainEvent>();
    }
}

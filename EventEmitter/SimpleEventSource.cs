using Microsoft.Diagnostics.Tracing;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventEmitter
{
    [EventSource(Name = "MyEventSource")]
    public sealed class SimpleEventSource : EventSource
    {
        
        static public SimpleEventSource Log = new SimpleEventSource();

        [Event(1, Level = EventLevel.Informational)]
        public void Info(string message)
        {
            WriteEvent(1, message);
        }

        [Event(2, Level = EventLevel.Warning)]
        public void Warn(string message)
        {
            WriteEvent(2, message);
        }
    }
}

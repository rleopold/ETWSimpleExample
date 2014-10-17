using Microsoft.Diagnostics.Tracing.Session;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("listening for ETW events...");
            using (var session = new TraceEventSession("MySession"))
            {
                session.EnableProvider("MyEventSource");
                session.Source.Dynamic.AddCallbackForProviderEvent("MyEventSource", "Info", data => Debug.WriteLine(data.ToString()));
                session.Source.Dynamic.AddCallbackForProviderEvent("MyEventSource", "Warn", data => Debug.WriteLine(data.ToString()));
                session.Source.Process();
                Console.ReadLine();
            }

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventEmitter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("firing ETW messages...");
            SimpleEventSource.Log.Info("Starting up...");

            var t1 = Observable.Interval(TimeSpan.FromSeconds(5));
            t1.Subscribe(x => SimpleEventSource.Log.Info("ETW Informational entry"));

            var t2 = Observable.Interval(TimeSpan.FromSeconds(10));
            t2.Subscribe(x => SimpleEventSource.Log.Warn("ETW Warning message"));

            Console.ReadLine();
            SimpleEventSource.Log.Info("Ending ..");
        }
    }
}

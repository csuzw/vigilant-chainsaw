using System;
using Mono.Unix;
using Mono.Unix.Native;
using Microsoft.Owin.Hosting;

namespace VigilantChainsaw.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseAddress = "http://+:3579";

            using (WebApp.Start<Startup>(baseAddress))
            {
                Console.WriteLine("Your application is running on " + baseAddress);
                Console.WriteLine("Press any [Enter] to close the host.");
                WaitForTerminator();
            }
        }

        private static void WaitForTerminator()
        {
            if (IsRunningOnMono())
            {
                var terminationSignals = GetUnixTerminationSignals();
                UnixSignal.WaitAny(terminationSignals);
            }
            else
            {
                Console.ReadLine();
            }
        }

        private static bool IsRunningOnMono()
        {
            return Type.GetType("Mono.Runtime") != null;
        }

        private static UnixSignal[] GetUnixTerminationSignals()
        {
            return new[]
            {
                new UnixSignal(Signum.SIGINT),
                new UnixSignal(Signum.SIGTERM),
                new UnixSignal(Signum.SIGQUIT),
                new UnixSignal(Signum.SIGHUP)
            };
        }
    }
}

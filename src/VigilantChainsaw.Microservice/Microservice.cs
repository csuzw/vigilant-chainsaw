using Mono.Unix;
using Mono.Unix.Native;
using Nancy.Hosting.Self;
using System;

namespace VigilantChainsaw.Framework
{
    public static class Microservice
    {
        public static void Start(IMicroserviceConfiguration config)
        {
            if (config == null) throw new ArgumentNullException("config");

            var bootstrapper = new Bootstrapper(config);
            var hostConfig = new HostConfiguration        
            {
                UrlReservations = new UrlReservations { CreateAutomatically = true },
            };
            var uri = new Uri("http://localhost:" + config.Port);

            using (var host = new NancyHost(bootstrapper, hostConfig, uri))
            {
                host.Start();

                Console.WriteLine("{0} is running on {1}", config.Name, uri);
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

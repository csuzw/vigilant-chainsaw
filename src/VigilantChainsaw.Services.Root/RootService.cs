using System;
using System.Reflection;

namespace VigilantChainsaw.Services.Root
{
    public class RootService : IRootService
    {
        public string Get()
        {
            return "Hello World!";
        }

        public string GetOperatingSystem()
        {
            return Environment.OSVersion.ToString();
        }

        public string GetVersion()
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
    }
}

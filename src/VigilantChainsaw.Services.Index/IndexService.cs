using System;
using System.Reflection;

namespace VigilantChainsaw.Services.Index
{
    public class IndexService : IIndexService
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

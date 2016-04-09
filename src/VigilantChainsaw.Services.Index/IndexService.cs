using System;

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
    }
}

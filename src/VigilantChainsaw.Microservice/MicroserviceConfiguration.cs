using Nancy.TinyIoc;
using System;

namespace VigilantChainsaw.Framework
{
    public class MicroserviceConfiguration : IMicroserviceConfiguration
    {
        public string Name { get; set; }
        public string Port { get; set; }
        public Action<TinyIoCContainer> ConfigureApplicationContainer { get; set; }
    }
}

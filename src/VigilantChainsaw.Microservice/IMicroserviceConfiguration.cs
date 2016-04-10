using Nancy.TinyIoc;
using System;

namespace VigilantChainsaw.Framework
{
    public interface IMicroserviceConfiguration
    {
        string Name { get; }
        string Port { get; }
        Action<TinyIoCContainer> ConfigureApplicationContainer { get; }
    }
}

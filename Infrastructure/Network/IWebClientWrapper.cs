using System;
using System.Collections.Generic;
using System.Linq;

namespace Alquiler.Infrastructure.Network
{
    public interface IWebClientWrapper
    {
        void Post(string address, string json);
    }
}
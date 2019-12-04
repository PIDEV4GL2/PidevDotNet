
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PidevDotNet.Pi.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        Model1 DataContext { get; }
    }

}

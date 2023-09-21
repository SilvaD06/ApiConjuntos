using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStateWebDotNet7Api.Infra.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IResidentRepository residents { get; }
        IUserRepository users { get; }
    }
}

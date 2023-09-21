using RealStateWebDotNet7Api.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStateWebDotNet7Api.Infra.Interface
{
    public interface IUserRepository : IGenericRepository<Users>
    {
        Users Authenticate(string username, string password);
    }
}

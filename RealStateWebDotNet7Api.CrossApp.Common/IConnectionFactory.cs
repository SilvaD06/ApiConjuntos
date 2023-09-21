using System.Data;

namespace RealStateWebDotNet7Api.CrossApp.Common
{
    public interface IConnectionFactory
    {
        IDbConnection getConnection { get; }
    }
}

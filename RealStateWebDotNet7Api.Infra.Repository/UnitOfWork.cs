using RealStateWebDotNet7Api.Infra.Interface;

namespace RealStateWebDotNet7Api.Infra.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public IResidentRepository residents { get; }

        public IUserRepository users {get; }

        public UnitOfWork(IResidentRepository residents, IUserRepository users)
        {
            this.residents = residents;
            this.users = users;
        }

        void IDisposable.Dispose()
        {
            System.GC.SuppressFinalize(this);   
        }
    }
}

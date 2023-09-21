using RealStateWebDotNet7Api.Domain.Entity;
using RealStateWebDotNet7Api.Domain.Interface;
using RealStateWebDotNet7Api.Infra.Interface;

namespace RealStateWebDotNet7Api.Domain.Core
{
    //Business logic comes here. process info before sending to infrastructure layer.
    public class ResidentsDomain : IResidentsDomain
    {
        private readonly IUnitOfWork _UnitOfWork;
        public ResidentsDomain (IUnitOfWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;
        }

        #region SyncMethods
        public bool Insert(Residents resident)
        {
            return _UnitOfWork.residents.Insert(resident);
        }
        public bool Update(Residents resident)
        {
            throw new NotImplementedException();
        }
        public bool Delete(Residents resident)
        {
            throw new NotImplementedException();
        }
        public Residents Get(int id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Residents> GetAll()
        {
            throw new NotImplementedException();
        }

        #endregion


        #region SyncMethods

        public async Task<bool> InsertAsync(Residents resident)
        {
           return await _UnitOfWork.residents.InsertAsync(resident);
        }
        public Task<bool> UpdateAsync(Residents resident)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteAsync(Residents resident)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<Residents>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
        public Task<Residents> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Residents> GetAllPaginated(int pageNum, int pageSize)
        {
           return _UnitOfWork.residents.GetAllPaginated(pageNum, pageSize);
        }

        public int CountT()
        {
            return _UnitOfWork.residents.CountT();
        }

        #endregion



    }
}
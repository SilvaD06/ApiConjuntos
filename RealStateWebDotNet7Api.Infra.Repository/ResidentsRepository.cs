using System;
using RealStateWebDotNet7Api.CrossApp.Common;
using RealStateWebDotNet7Api.Infra.Data;
using RealStateWebDotNet7Api.Infra.Interface;
using RealStateWebDotNet7Api.Domain.Entity;
using Dapper;

namespace RealStateWebDotNet7Api.Infra.Repository
{
    public class ResidentsRepository : IResidentRepository
    {
        private readonly IConnectionFactory _connectionFactory;

        public ResidentsRepository (IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        #region Sync Methods 

        public bool Insert(Residents resident)
        {
            using (var connection = _connectionFactory.getConnection)
            {
                var query = "Insert_Person";
                var parameters = new DynamicParameters();
                parameters.Add("FirstName", resident.FirstName);
                parameters.Add("LastName", resident.LastName);
                parameters.Add("Email", resident.Email);
                parameters.Add("Telephone", resident.Telephone);
                parameters.Add("IdDocumentType", resident.IdDocumentType);
                parameters.Add("DocumentNumber", resident.DocumentNumber);
                parameters.Add("IdResidence", resident.IdResidence);
                parameters.Add("IsResident", resident.IsResident);
             
                var result = connection.Execute(query, param: parameters, commandType: System.Data.CommandType.StoredProcedure);
                return result > 0;
            }

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

        public IEnumerable<Residents> GetAllPaginated(int pageNum, int pageSize)
        {
            using var connection = _connectionFactory.getConnection;
            var query = "Residents_List_pag";
            var parameters = new DynamicParameters();
            parameters.Add("PageNum", pageNum);
            parameters.Add("PageSize", pageSize);

            var residents = connection.Query<Residents>(query, param:parameters, commandType: System.Data.CommandType.StoredProcedure);
      
            return residents;
        }

        public int CountT()
        {
            using var connection = _connectionFactory.getConnection;
            var query = "Select Count(IdPerson) from Person";
            var count = connection.ExecuteScalar<int>(query , commandType:System.Data.CommandType.Text);

            return count;
        }

        #endregion
        #region Async Methods 

        public async Task<bool> InsertAsync(Residents resident)
        {
            using (var connection = _connectionFactory.getConnection)
            {
                var query = "Insert_Person";
                var parameters = new DynamicParameters();
                parameters.Add("FirstName", resident.FirstName);
                parameters.Add("LastName", resident.LastName);
                parameters.Add("Email", resident.Email);
                parameters.Add("Telephone", resident.Telephone);
                parameters.Add("IdDocumentType", resident.IdDocumentType);
                parameters.Add("DocumentNumber", resident.DocumentNumber);
                parameters.Add("IdResidence", resident.IdResidence);
                parameters.Add("IsResident", resident.IsResident);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: System.Data.CommandType.StoredProcedure);
                return result > 0;
            }
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
        public Task<IEnumerable<Residents>> GetAllPaginatedAsync(int pageNum, int pageSize)
        {
            throw new NotImplementedException();
        }
        public int CountTAsync()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
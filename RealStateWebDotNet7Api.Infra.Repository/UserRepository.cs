using Dapper;
using RealStateWebDotNet7Api.CrossApp.Common;
using RealStateWebDotNet7Api.Domain.Entity;
using RealStateWebDotNet7Api.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStateWebDotNet7Api.Infra.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IConnectionFactory _connectionFactory;
        public UserRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public Users Authenticate(string userName, string password)
        {
            using (var connection = _connectionFactory.getConnection)
            {
                var query = "UsersGetByUsrNameAndPassword";
                var parameters = new DynamicParameters();
                parameters.Add("UserName", userName);
                parameters.Add("Password", password);

                var user = connection.QuerySingle<Users>(query, param: parameters, commandType: System.Data.CommandType.StoredProcedure);
                return user;
            }
        }

        Users IUserRepository.Authenticate(string username, string password)
        {
            throw new NotImplementedException();
        }

        int IGenericRepository<Users>.CountT()
        {
            throw new NotImplementedException();
        }

        int IGenericRepository<Users>.CountTAsync()
        {
            throw new NotImplementedException();
        }

        bool IGenericRepository<Users>.Delete(Users entity)
        {
            throw new NotImplementedException();
        }

        Task<bool> IGenericRepository<Users>.DeleteAsync(Users entity)
        {
            throw new NotImplementedException();
        }

        Users IGenericRepository<Users>.Get(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Users> IGenericRepository<Users>.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Users>> IGenericRepository<Users>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        IEnumerable<Users> IGenericRepository<Users>.GetAllPaginated(int pageNum, int pageSize)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Users>> IGenericRepository<Users>.GetAllPaginatedAsync(int pageNum, int pageSize)
        {
            throw new NotImplementedException();
        }

        Task<Users> IGenericRepository<Users>.GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        bool IGenericRepository<Users>.Insert(Users entity)
        {
            throw new NotImplementedException();
        }

        Task<bool> IGenericRepository<Users>.InsertAsync(Users entity)
        {
            throw new NotImplementedException();
        }

        bool IGenericRepository<Users>.Update(Users entity)
        {
            throw new NotImplementedException();
        }

        Task<bool> IGenericRepository<Users>.UpdateAsync(Users entity)
        {
            throw new NotImplementedException();
        }
    }
}

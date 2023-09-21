using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using RealStateWebDotNet7Api.CrossApp.Common;

namespace RealStateWebDotNet7Api.Infra.Data
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly IConfiguration _configuration;
        public ConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration; 

        }

        public IDbConnection getConnection
        {
            get
            {
                var sqlConnection = new SqlConnection();
                if (sqlConnection == null) return null;

                sqlConnection.ConnectionString = _configuration.GetConnectionString("realstateSqlConnection");
                sqlConnection.Open();
                return sqlConnection;
            }
        }
    }
}
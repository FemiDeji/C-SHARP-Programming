using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;

namespace APITutorial.Data
{

    public class DataContextDapper
    {
        
        private string _connectionString = "Server=mssql-178256-0.cloudclusters.net,10009;Database=DotNetCourseDatabase;User Id=Nox;Password=Asd12345;TrustServerCertificate=true;Connection Timeout=30;";

        public IEnumerable<T> LoadData<T>(string sql)
        {
            IDbConnection dbConnection = new SqlConnection(_connectionString);
            return dbConnection.Query<T>(sql);
        }

        public T LoadDataSingle<T>(string sql)
        {
            IDbConnection dbConnection = new SqlConnection(_connectionString);
            return dbConnection.QuerySingle<T>(sql);
        }

        public bool ExecuteSql(string sql)
        {
            IDbConnection dbConnection = new SqlConnection(_connectionString);
            return (dbConnection.Execute(sql) > 0);
        }

        public int ExecuteSqlWithRowCount(string sql)
        {
            IDbConnection dbConnection = new SqlConnection(_connectionString);
            return dbConnection.Execute(sql);
        }
        
    }
}
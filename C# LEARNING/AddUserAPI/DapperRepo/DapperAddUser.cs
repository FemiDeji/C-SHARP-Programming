using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using AddUserApi.Models;
using Dapper;      

namespace AddUserApi.DapperRepo
{
    public class DapperAddUser : IDapperAddUser
    {
        private readonly IConfiguration _configuration;
        private readonly SqlConnection _connection;

        public DapperAddUser(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new SqlConnection(configuration.GetConnectionString("Default Connection"));
        }
    
        //Parameters to add user
        public async Task<User> AddUser(string Name, string Staff_ID, string Email, string Device, int Phone_number, string Lab_role, string Password)
        {
            var parameters = new DynamicParameters();
            parameters.Add(@"Name", Name);
            parameters.Add(@"Staff_ID", Staff_ID);
            parameters.Add(@"Email", Email);
            parameters.Add(@"Device", Device);
            parameters.Add(@"Phone_number", Phone_number);
            parameters.Add(@"Lab_role", Lab_role);
            parameters.Add(@"Password", Password);
            
            return await _connection.QueryFirstOrDefaultAsync<User>(@"AddUser",parameters, commandType:System.Data.CommandType.StoredProcedure);
        }

        //Paremeters to remove user
        public async Task<User> DeleteUser(string Name, string Staff_ID, string Email, string Device, int Phone_number, string Lab_role)
        {
            var parameters = new DynamicParameters();
            parameters.Add(@"Staff_ID", Staff_ID);
            
            return await _connection.QueryFirstOrDefaultAsync<User>(@"DeleteUser",parameters, commandType:System.Data.CommandType.StoredProcedure);
        }

        //Parameter to access the list of added users by the super admin
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _connection.QueryAsync<User>("AllUsers", commandType: System.Data.CommandType.StoredProcedure);
        }
    }
}
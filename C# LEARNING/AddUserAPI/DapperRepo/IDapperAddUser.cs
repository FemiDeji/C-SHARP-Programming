using AddUserApi.Models;

namespace AddUserApi.DapperRepo
{
    public interface IDapperAddUser
    {
        public Task<User> AddUser(string Name, string Staff_ID, string Email, string Device, int Phone_number, string Lab_role, string Password);
        public Task<User> DeleteUser(string Staff_ID);
        public Task<IEnumerable<User>> GetUsers();
    }
}
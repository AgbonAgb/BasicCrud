using BasicCrud.DTO;
using BasicCrud.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BasicCrud.Repository
{
    public interface IUsers
    {

        Task<User> CreateUser(User user);
        Task<UserDto> UpdateUser(User user);
        Task<User> GetUser(string userid);
        Task<IEnumerable<User>> GetAllUsers();
        Task<bool> DelUser(string userid);
    }
}

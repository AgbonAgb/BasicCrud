using BasicCrud.Data;
using BasicCrud.DTO;
using BasicCrud.Model;
using BasicCrud.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicCrud.Services
{
    public class UserServices : IUsers
    {
        private readonly AppDbContext _appbContext;

        public UserServices(AppDbContext appbContext)
        {
            _appbContext=appbContext;
        }
        public async Task<User> CreateUser(User user)
        {

            var ExistUser = await _appbContext.Users.FindAsync(user.Id);

            if (ExistUser == null)
            {
                try
                {
                    await _appbContext.AddAsync(user);
                    var sv=   await _appbContext.SaveChangesAsync();
                    if (sv == 1)
                    {
                        ExistUser = await _appbContext.Users.FindAsync(user.Id);
                    }
                    return await Task.FromResult(ExistUser);
                }
                catch (System.Exception)
                {

                    throw;
                }
               

               
            }
            return ExistUser;
        }

        public async Task<bool> DelUser(string userid)
        {
            bool rtn = false;
            try
            {
                //var existing = _appbContext.Users.FindAsync(userid);
                var existing = await _appbContext.Users.Where(x => x.Id == userid).FirstOrDefaultAsync();
                if (existing != null)
                {
                    //_userServices.Remove(existing);

                    _appbContext.Remove(existing);
                    await _appbContext.SaveChangesAsync();
                    rtn = true;
                }
            }
            catch (System.Exception ex)
            {

                throw;
            }
            return rtn;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            var existUser = await _appbContext.Users.ToListAsync();

            return existUser;
        }

        public async Task<User> GetUser(string userid)
        {
            var existUser = await _appbContext.Users.Where(x=>x.Id== userid).FirstOrDefaultAsync();

            return existUser;
        }

        public Task<UserDto> UpdateUser(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using MatingApp.API.Models;

namespace MatingApp.API.Data
{
    public interface IMatingRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int id);
    }
}
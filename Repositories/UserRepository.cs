using System.Linq;
using System.Threading.Tasks;
using ProductsApi.Data;
using ProductsApi.Models;

namespace ProductsApi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDataContext _context;

        public UserRepository(IDataContext context)
        {
            _context = context;
        }

        public async Task<bool> Verify(string email, string password)
        {
            var maybeUser =   _context.Users.Where(user => user.Email == email && user.Password == password).FirstOrDefault();
            if(maybeUser == null){
                return false;
            } else {
                return true;
            }
        }
    }
}
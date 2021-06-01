using System.Threading.Tasks;

namespace ProductsApi.Repositories
{
    public interface IUserRepository
    {
         Task<bool> Verify(string email, string password);
    }
}
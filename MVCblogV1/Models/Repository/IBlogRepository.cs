using MVCblogV1.Models.db;

namespace MVCblogV1.Models.Repository
{
    public interface IBlogRepository
    {
        Task AddUser(User user);
        Task<User[]> GetUsers();
    }
}

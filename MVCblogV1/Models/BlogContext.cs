using Microsoft.EntityFrameworkCore;
using MVCblogV1.Models.db;

namespace MVCblogV1.Models
{
    /// <summary>
    /// Класс контекста, представляющий доступ к сущностям в БД
    /// </summary>
    public class BlogContext : DbContext
    {
        //Ссылка на таблицу Users
        public DbSet<User> Users { get; set; }

        //Ссылка на таблицу UserPost
        public DbSet<UserPost> UserPosts { get; set; }

        //Ссылка на таблицу Request
        public DbSet<Request> Requests { get; set; }

        //Логика взаимодействия с таблицами в БД
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

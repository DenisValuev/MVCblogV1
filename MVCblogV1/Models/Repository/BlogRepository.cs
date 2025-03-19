using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCblogV1.Models.db;

namespace MVCblogV1.Models.Repository
{
    public class BlogRepository : IBlogRepository
    {
        //Ссылка на контекст
        private readonly BlogContext _context;

        //Инициализация 
        public BlogRepository(BlogContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task AddUser(User user)
        {
            //Добавление пользователя
            var entry = _context.Entry(user);
            if (entry.State == EntityState.Detached)
            {
                await _context.Users.AddAsync(user);
            }
            //Сохранение изменений
            await _context.SaveChangesAsync();
        }

        public async Task<User[]> GetUsers()
        {
            //Получим всех зарегистрированных пользователей
            return await _context.Users.ToArrayAsync();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MVCblogV1.Models.db;
using MVCblogV1.Models.Repository;

namespace MVCblogV1.Controllers
{
    public class UsersController : Controller
    {
        private readonly IBlogRepository _blog;

        public UsersController(IBlogRepository blog)
        {
            _blog = blog;
        }

        /// <summary>
        /// Вывод в представление Authors всех зарегистрированных пользователей
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Authors()
        {
            var authors = await _blog.GetUsers();
            return View(authors);
        }
        /// <summary>
        /// Отображение представления Register
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(User user)
        {
            user = new User()
            {
                Id = Guid.NewGuid(),
                FirstName = $"{user.FirstName}",
                LastName = $"{user.LastName}",
                JoinDate = DateTime.Now
            };
            await _blog.AddUser(user);
            return View(user);
        }
    }
}

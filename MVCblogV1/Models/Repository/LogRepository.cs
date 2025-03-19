using Microsoft.EntityFrameworkCore;
using MVCblogV1.Models.db;

namespace MVCblogV1.Models.Repository
{
    public class LogRepository : ILogRepository
    {
        private readonly BlogContext _context;
        public LogRepository(BlogContext context)
        {
            _context = context;
        }
        public async Task Log(Request request)
        {
            var entry = _context.Entry(request);
            if (entry.State == EntityState.Detached)
            {
                await _context.Requests.AddAsync(request);
            }
            await _context.SaveChangesAsync();
        }
        public async Task<Request[]> GetLogs()
        {
            return await _context.Requests.ToArrayAsync();
        }

        
    }
}

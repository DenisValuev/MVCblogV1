using MVCblogV1.Models.db;

namespace MVCblogV1.Models.Repository
{
    public interface ILogRepository
    {
        Task Log(Request request);
        Task<Request[]> GetLogs();
    }
}

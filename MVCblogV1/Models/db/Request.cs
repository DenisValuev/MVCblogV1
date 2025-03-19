namespace MVCblogV1.Models.db
{
    /// <summary>
    /// Модель запроса в блоге (для логгирования)
    /// </summary>
    public class Request
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Url { get; set; }
    }
}

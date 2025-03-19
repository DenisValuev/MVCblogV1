namespace MVCblogV1.Models.db
{
    /// <summary>
    /// Модель пользователя в блоге
    /// </summary>
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime JoinDate { get; set; }
    }
}

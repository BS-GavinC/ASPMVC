namespace MaPremiereAppMVC.Context
{
    public static class FakeDb
    {
        public static List<User> Users { get; set; } = new List<User>()
        {
            new User(1, "Popol@gmail.com", "Popol93", "Test123="),
            new User(2, "Pupul@gmail.com", "Pupul91", "Test123="),
            new User(3, "Papal@gmail.com", "Papal1000", "Test123=")
        };
    }

    public class User
    {
        public User(int id, string email, string username, string password)
        {
            Id = id;
            Email = email;
            UserName = username;
            Password = password;
        }
        public int Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }
    }
}

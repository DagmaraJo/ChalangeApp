namespace ChalangeApp
{
    
    public class User
    {
        public User (string login)
        {
            this.Login = login;
        }

        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }

        public string Login { get; set; }
        public string Password { get; set; }
    }
}

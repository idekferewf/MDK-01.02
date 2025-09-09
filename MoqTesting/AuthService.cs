namespace MoqTesting
{
    public class AuthService
    {
        private readonly IUserRepository userRepository_;

        public AuthService(IUserRepository userRepository)
        {
            userRepository_ = userRepository;
        }

        public bool LoginUser(string username, string password)
        {
            User user = userRepository_.LoginUser(username, password);
            if (user == null)
            {
                return false;
            }
            return true;
        }
    }
}

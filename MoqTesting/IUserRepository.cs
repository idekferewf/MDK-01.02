namespace MoqTesting
{
    public interface IUserRepository
    {
        User LoginUser(string username, string password);
    }
}

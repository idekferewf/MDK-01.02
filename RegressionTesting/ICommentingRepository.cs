namespace RegressionTesting
{
    public interface ICommentingRepository
    {
        string AddComment(string text, User user);
    }
}
